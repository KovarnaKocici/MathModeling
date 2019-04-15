using MathNet.Numerics.LinearAlgebra;
using MathNet.Spatial;
using MathNet.Spatial.Euclidean;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processModeling
{
    class Sensor
    {
        public double X { get; } // value
        public double T { get; } // time

        public Sensor(double value, double time) {
            X = value;
            T = time;
        }
    }

    class Process
    {
        List<Sensor> InputS; // S = {(x,t)}
        List<Sensor> PrehistoryS; // предісторія
        List<Sensor> NotInS; // не з заданої області S

        List<Sensor> ValFromArea; // y(s) з області
        List<Sensor> ValFromOutline; // y(s) з контура
        List<Sensor> ValCurrent; // y(s) поточні

        Matrix<double> A;
        Matrix<double> A11;
        Matrix<double> A12;
        Matrix<double> A21;
        Matrix<double> A22;

        Matrix<double> P1;
        Vector<double> U0; //u0m
        Vector<double> Ug; //uгm
        Vector<double> Y; //Y0+Yg x 1

      List<string> ListLinearOperator = new List<string>() { "Dt - Dx^2" };
        List<string> ListGreenFunction = new List<string>() { "H(t-t')/(....)" };

        private double YFunc(Sensor s)
        {
            return Math.Sin(s.T) * Math.Cos(s.X);
        }

        public double UFunc(Sensor s)
        {
            return Math.Cos(s.T) * Math.Sin(s.X) - Math.Pow(Math.Sin(s.T) * Math.Cos(s.X), 2);
        }

        private int HeavisideFunc(double x)
        {
            if (x < 0)
                return 0;
            return 1;
        }

        public double GreenFunc(Sensor s, Sensor s_) // s, s`
        {
            return HeavisideFunc(s.T - s_.T) / (Math.Sqrt(4 * Math.PI * (s.T - s_.T))) * Math.Exp(-Math.Pow(Math.Abs(s.X - s_.X), 2) / 4 * (s.T - s_.T));
        }

        public List<Sensor> SortSensors(List<Sensor> list)
        {
            List<Sensor> sorted = new List<Sensor>(list);
            for (int p = 0; p <= InputS.Count - 2; p++)
            {
                for (int i = 0; i <= InputS.Count - 2; i++)
                {
                    if (sorted[i].X > sorted[i + 1].X)
                    {
                        Sensor temp = sorted[i + 1];
                        sorted[i + 1] = sorted[i];
                        sorted[i] = temp;
                    }
                }
            }
            return sorted;
        }

        private void FillValFromArea()
        {
            for (int i = 0; i < InputS.Count; i++)
                if (InputS[i].T == 0)
                    ValFromArea.Add(InputS[i]);
        }

       private void FillValFromOutline()
        {
            List<Sensor> SortedInputS = SortSensors(InputS);
            //find values with min x
            double minX = SortedInputS[0].X;
            for (int i = 0; i < InputS.Count; i++)
                if(SortedInputS[i].X == minX)
                    ValFromOutline.Add(SortedInputS[i]);

            //find values with max x
            double maxX = SortedInputS[InputS.Count - 1].X;
            for (int i = InputS.Count - 1; i >=0; i--)
                if (SortedInputS[i].X == maxX)
                    ValFromOutline.Add(SortedInputS[i]);
        }

       private void FillValCurrent()
        {
            for (int i = 0; i < InputS.Count; i++) {
                if (InputS[i] != ValFromOutline[i])
                    ValCurrent.Add(InputS[i]);
            }
        }

        public void FillPrehistoryS(int size, List<Sensor> values) {
            for (int i = 0; i < size; i++)
                PrehistoryS.Add(values[i]);
        }

        public void FillNotInS(int size, List<Sensor> values)
        {
            for (int i = 0; i < size; i++)
                NotInS.Add(values[i]);
        }

        private void FormA11()
        {
            A11 = Matrix<double>.Build.Dense(InputS.Count, PrehistoryS.Count);
            for (int i = 0; i < A11.RowCount; i++)
                for (int j = 0; j < A11.ColumnCount; j++)
                    GreenFunc(InputS[i], PrehistoryS[j]);
        }

        private void FormA12()
        {
            A12 = Matrix<double>.Build.Dense(InputS.Count, NotInS.Count);
            for (int i = 0; i < A12.RowCount; i++)
                for (int j = 0; j < A12.ColumnCount; j++)
                    GreenFunc(InputS[i], NotInS[j]);
        }

        private void FormA21()
        {
            A21 = Matrix<double>.Build.Dense(ValFromOutline.Count, PrehistoryS.Count);
            for (int i = 0; i < A21.RowCount; i++)
                for (int j = 0; j < A22.ColumnCount; j++)
                    GreenFunc(ValFromOutline[i], PrehistoryS[j]);
        }

        private void FormA22()
        {
            A21 = Matrix<double>.Build.Dense(ValFromOutline.Count, NotInS.Count);
            for (int i = 0; i < A22.RowCount; i++)
                for (int j = 0; j < A21.ColumnCount; j++)
                    GreenFunc(ValFromOutline[i], NotInS[j]);
    }

        public void FormMatrixA()
        {
            A = Matrix<double>.Build.Dense(InputS.Count + ValFromOutline.Count , PrehistoryS.Count + NotInS.Count());

            //Form cells
            FormA11();
            FormA12();
            FormA21();
            FormA22();

            //Form A
            //Copy from A11 
            for (int i = 0; i < A11.RowCount; i++)
                for (int j = 0; j < A11.ColumnCount; j++)
                    A[i, j] = A11[i, j];

            //Copy from A12 
            for (int i = 0; i < A12.RowCount; i++)
                for (int j = 0; j < A12.ColumnCount; j++)
                    A[i, A12.ColumnCount + j] = A12[i, j];

            //Copy from A21
            for (int i = 0; i < A21.RowCount; i++)
                for (int j = 0; j < A21.ColumnCount; j++)
                    A[A21.RowCount + i,j] = A21[i, j];

            //Copy from A22
            for (int i = 0; i < A22.RowCount; i++)
                for (int j = 0; j < A22.ColumnCount; j++)
                    A[A21.RowCount + i, A22.ColumnCount + j] = A22[i, j];
        }

        public void FormP1() {
           Matrix<double> At = A.Transpose();
           P1 = A * At;
        }

        public void FormY()
        {
            //Form Y0
            Vector<double> Y0 = Vector<Double>.Build.Dense(PrehistoryS.Count);
            for (int i = 0; i < PrehistoryS.Count; i++)
                Y0[i] = YFunc(PrehistoryS[i]);

            //Form Yg
            Vector<double> Yg = Vector<Double>.Build.Dense(NotInS.Count);
            for (int i = 0; i < NotInS.Count; i++)
                Yg[i] = YFunc(NotInS[i]);

            Y = Vector<double>.Build.DenseOfEnumerable(Y0.Concat(Yg));
        }

        public void FormU0() {
            Matrix<double> A11t = A11.Transpose();
            Matrix<double> A21t = A21.Transpose();
            Matrix<double> P1Pseudo = P1.PseudoInverse();

            Matrix<double> A11tA21t = Matrix<double>.Build.Dense(A11.RowCount, A11.ColumnCount + A21.ColumnCount);

            //Copy from A11t
            for (int i = 0; i < A11t.RowCount; i++)
                for (int j = 0; j < A11t.RowCount; j++)
                    A11tA21t[i, j] = A11t[i, j];

            //Copy from A21t
            for (int i = 0; i < A21t.RowCount; i++)
                for (int j = 0; j < A21t.RowCount; j++)
                    A11tA21t[i, A11t.ColumnCount + j] = A21t[i, j];
            
            U0 = A11tA21t * P1Pseudo * Y;
        }

        public void FormUg()
        {
            Matrix<double> A12t = A12.Transpose();
            Matrix<double> A22t = A22.Transpose();
            Matrix<double> P1Pseudo = P1.PseudoInverse();

            Matrix<double> A12tA22t = Matrix<double>.Build.Dense(A12.RowCount, A12.ColumnCount + A22.ColumnCount);

            //Copy from A11t
            for (int i = 0; i < A12t.RowCount; i++)
                for (int j = 0; j < A12t.RowCount; j++)
                    A12tA22t[i, j] = A12t[i, j];

            //Copy from A21t
            for (int i = 0; i < A22t.RowCount; i++)
                for (int j = 0; j < A22t.RowCount; j++)
                    A12tA22t[i, A12t.ColumnCount + j] = A22t[i, j];

            Ug = A12tA22t * P1Pseudo * Y; ;
        }

        public Vector<Double> CalcYComponent(List<Sensor> S, Vector<double> u)
        {
            Vector<Double> res = Vector<Double>.Build.Dense(InputS.Count, 0);
            for (int i = 0; i < res.Count; i++)
                res[i] += GreenFunc(InputS[i], S[i]) * u[i];
            return res;
        }

        private Vector<Double> CalcYinf()
        {
            Vector<Double> res = Vector<Double>.Build.Dense(InputS.Count);
            for (int i = 0; i < res.Count; i++)
                res[i] = UFunc(InputS[i]);
            return res;
        }

        private Vector<Double> CalcY0()
        {
            return CalcYComponent(PrehistoryS, U0);
        }

        private Vector<Double> CalcYg()
        {
            return CalcYComponent(NotInS, Ug);
        }

        private Vector<Double> CalcY() {
            return CalcYinf() + CalcY0() + CalcYg();
        }

        public List<Sensor> BuildFuncOfState() {
            Vector<Double> y = CalcY();
            List<Sensor> res = new List<Sensor>();
            for (int i = 0; i < InputS.Count; i++)
                res.Add(new Sensor(y[i], InputS[i].T));
            return res;
        }

        Process(int Size, List<double> InitX, List<double> InitT) {
            for (int i = 0; i < InputS.Count; i++)
                InputS.Add(new Sensor(InitX[i], InitT[i]));
        }

    }
}
