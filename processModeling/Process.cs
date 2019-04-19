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
    public class State
    {
        public Sensor sensor { get; }
        public double Y { get; }

        public State(Sensor s, double y)
        {
            sensor = s;
            Y = y;
        }
    }

    public class Sensor
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
        const int NumS= 10;//number of sensors
        public List<Sensor> InputS = new List<Sensor>();// S = {(x,t)}
        List<Sensor> FromOutlineS = new List<Sensor>(); // S = {(x,t): x = xmin, x = xmax}
        List<Sensor> FromAreaS = new List<Sensor>();// S = {(x,t): t = 0}
        List<Sensor> PrehistoryS = new List<Sensor>(); // предісторія
        List<Sensor> NotInS = new List<Sensor>(); // не з заданої області S

        List<double> ValFromArea = new List<double>(); // y(s) з області   t=0                     
        List<double> ValFromOutline = new List<double>(); // y(s) з контура
        // List<double> ValCurrent; // y(s) поточні

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


        Process(int Size, List<double> InitX, List<double> InitT)
        {
            for (int i = 0; i < InputS.Count; i++)
                InputS.Add(new Sensor(InitX[i], InitT[i]));
        }

        public Process(double x1, double xn, double T)
        {
            InputS = GenerateS(x1, xn, T);
        }

        public List<Sensor> GenerateS(double x1, double xn, double T)
        {
            List<Sensor> S = new List<Sensor>();

            for (int i = 0; i < NumS; i++)
            {
                Sensor sensor = new Sensor(DRandom.Range(x1, xn), DRandom.Range(0, T));
                S.Add(sensor);

                Sensor prehistoryS = new Sensor(DRandom.Range(x1, xn), DRandom.Range(-T, 0));
                PrehistoryS.Add(prehistoryS);

                Sensor notInS = new Sensor(DRandom.Range(xn + 1, xn + x1), DRandom.Range(0, T));
                NotInS.Add(notInS); //on the right side of our range = (xn; xn+x1]
            }
            for (int j = 0; j < NumS / 5; j++)
            {
                Sensor sensor = new Sensor(DRandom.Range(x1, xn), 0);
                S.Add(sensor);
            }
            return S;
        }

        private double YFunc(Sensor s)
        {
            return Math.Cos(s.T) * Math.Cos(s.X);
        }

        public double UFunc(Sensor s)
        {
            return -Math.Cos(s.X) * Math.Sin(s.T) - Math.Pow(-Math.Cos(s.T) * Math.Sin(s.X), 2);
        }

        private int HeavisideFunc(double x)
        {
            if (x < 0)
                return 0;
           else return 1;
        }

        public double GreenFunc(Sensor s, Sensor s_) // s, s`
        {
            //return 1 / (2 * Math.PI) * Math.Log(1 / (Math.Pow((s.X - s_.X), 2) + Math.Pow((s.T - s_.T), 2)));
            // return (HeavisideFunc(s.T - s_.T) / (Math.Sqrt(4 * Math.PI * (s.T - s_.T)))) * Math.Exp(-Math.Pow(Math.Abs(s.X - s_.X), 2) / (4 * (s.T - s_.T)));
            double hf = HeavisideFunc(s.T - s_.T);
            double denomimator = Math.Sqrt(4 * Math.PI *Math.Abs(s.T - s_.T));
            double expArg = -Math.Pow(Math.Abs(s.X - s_.X) + 0.0001, 2) / (4 * (Math.Abs(s.T - s_.T) + 0.0001));
            double expRes = Math.Exp(expArg);
            double res = (hf * expRes) / denomimator;
            return res;
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
                {
                    FromAreaS.Add(InputS[i]);
                    ValFromArea.Add(YFunc(InputS[i]));
                }
        }

        private void FillValFromOutline()
        {
            List<Sensor> SortedInputS = SortSensors(InputS);
            //Find min x
            FromOutlineS.Add(SortedInputS[0]);
            ValFromOutline.Add(YFunc(SortedInputS[0]));
            //FInd max x
            FromOutlineS.Add(SortedInputS[SortedInputS.Count - 1]);
            ValFromOutline.Add(YFunc(SortedInputS[SortedInputS.Count-1]));

            ////find values with min x
            //double minX = SortedInputS[0].X;
            //for (int i = 0; i < InputS.Count; i++)
            //    if (SortedInputS[i].X == minX)
            //        ValFromOutline.Add(YFunc(SortedInputS[i]));

            ////find values with max x
            //double maxX = SortedInputS[InputS.Count - 1].X;
            //for (int i = InputS.Count - 1; i >= 0; i--)
            //    if (SortedInputS[i].X == maxX)
            //        ValFromOutline.Add(SortedInputS[i]);
        }

        //private void FillValCurrent()
        //{
        //    for (int i = 0; i < InputS.Count; i++)
        //    {
        //        if (InputS[i] != ValFromOutline[i])
        //            ValCurrent.Add(YInputS[i]);
        //    }
        //}

        //public void FillPrehistoryS(int size, List<Sensor> values) {
        //    for (int i = 0; i < size; i++)
        //        PrehistoryS.Add(values[i]);
        //}

        //public void FillNotInS(int size, List<Sensor> values)
        //{
        //    for (int i = 0; i < size; i++)
        //        NotInS.Add(values[i]);
        //}

        private void FormA11()
        {
            A11 = Matrix<double>.Build.Dense(FromAreaS.Count, PrehistoryS.Count);
            for (int i = 0; i < A11.RowCount; i++)
                for (int j = 0; j < A11.ColumnCount; j++)
                    A11[i,j] = GreenFunc(FromAreaS[i], PrehistoryS[j]);
        }

        private void FormA12()
        {
            A12 = Matrix<double>.Build.Dense(FromAreaS.Count, NotInS.Count);
            for (int i = 0; i < A12.RowCount; i++)
                for (int j = 0; j < A12.ColumnCount; j++)
                    A12[i, j] = GreenFunc(FromAreaS[i], NotInS[j]);
        }

        private void FormA21()
        {
            A21 = Matrix<double>.Build.Dense(FromOutlineS.Count, PrehistoryS.Count);
            for (int i = 0; i < A21.RowCount; i++)
                for (int j = 0; j < A21.ColumnCount; j++)
                    A21[i,j] = GreenFunc(FromOutlineS[i], PrehistoryS[j]);
        }

        private void FormA22()
        {
            A22 = Matrix<double>.Build.Dense(FromOutlineS.Count, NotInS.Count);
            for (int i = 0; i < A22.RowCount; i++)
                for (int j = 0; j < A22.ColumnCount; j++)
                    A22[i, j] = GreenFunc(FromOutlineS[i], NotInS[j]);
    }

        public void FormMatrixA()
        {
            A = Matrix<double>.Build.Dense(FromAreaS.Count + ValFromOutline.Count , PrehistoryS.Count + NotInS.Count());

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
                    A[A11.RowCount + i,j] = A21[i, j];

            //Copy from A22
            for (int i = 0; i < A22.RowCount; i++)
                for (int j = 0; j < A22.ColumnCount; j++)
                    A[A12.RowCount + i, A21.ColumnCount + j] = A22[i, j];
        }

        public void FormP1() {
           Matrix<double> At = A.Transpose();
           P1 = A * At;
        }

        public void FormY()
        {
            //Form Y0
            //Vector<double> Y0 = Vector<Double>.Build.Dense(PrehistoryS.Count);
            //for (int i = 0; i < PrehistoryS.Count; i++)
            //    Y0[i] = YFunc(PrehistoryS[i]);

            ////Form Yg
            //Vector<double> Yg = Vector<Double>.Build.Dense(NotInS.Count);
            //for (int i = 0; i < NotInS.Count; i++)
            //    Yg[i] = YFunc(NotInS[i]);
            FillValFromArea();
            FillValFromOutline();

            Y = Vector<double>.Build.DenseOfEnumerable(ValFromArea.Concat(ValFromOutline));
        }

        public void FormU0() {
            Matrix<double> A11t = A11.Transpose();
            Matrix<double> A21t = A21.Transpose();
            Matrix<double> P1Pseudo = P1.PseudoInverse();

            Matrix<double> A11tA21t = Matrix<double>.Build.Dense(A11t.RowCount, A11t.ColumnCount + A21t.ColumnCount);

            //Copy from A11t
            for (int i = 0; i < A11t.RowCount; i++)
                for (int j = 0; j < A11t.ColumnCount; j++)
                    A11tA21t[i, j] = A11t[i, j];

            //Copy from A21t
            for (int i = 0; i < A21t.RowCount; i++)
                for (int j = 0; j < A21t.ColumnCount; j++)
                    A11tA21t[i, A11t.ColumnCount + j] = A21t[i, j];
            
            U0 = A11tA21t * P1Pseudo * Y;
        }

        public void FormUg()
        {
            Matrix<double> A12t = A12.Transpose();
            Matrix<double> A22t = A22.Transpose();
            Matrix<double> P1Pseudo = P1.PseudoInverse();

            Matrix<double> A12tA22t = Matrix<double>.Build.Dense(A12t.RowCount, A12t.ColumnCount + A22t.ColumnCount);

            //Copy from A11t
            for (int i = 0; i < A12t.RowCount; i++)
                for (int j = 0; j < A12t.ColumnCount; j++)
                    A12tA22t[i, j] = A12t[i, j];

            //Copy from A21t
            for (int i = 0; i < A22t.RowCount; i++)
                for (int j = 0; j < A22t.ColumnCount; j++)
                    A12tA22t[i, A12t.ColumnCount + j] = A22t[i, j];

            Ug = A12tA22t * P1Pseudo * Y; ;
        }

        public Vector<Double> CalcYComponent(List<Sensor> S, List<Sensor> Sm, Vector<double> u)
        {
            Vector<Double> res = Vector<Double>.Build.Dense(S.Count, 0);
            for (int i = 0; i < u.Count; i++)
                res[i] += GreenFunc(S[i], Sm[i]) * u[i];
            return res;
        }

        private Vector<Double> CalcYinf(List<Sensor> S)
        {
            Vector<Double> res = Vector<Double>.Build.Dense(S.Count);
            for (int i = 0; i < res.Count; i++)
                res[i] = UFunc(InputS[i]);
            return res;
        }

        private Vector<Double> CalcY0(List<Sensor> S)
        {
            return CalcYComponent(S, PrehistoryS, U0);
        }

        private Vector<Double> CalcYg(List<Sensor> S)
        {
            return CalcYComponent(S, NotInS, Ug);
        }

        private Vector<Double> CalcY(List<Sensor> S) {
            return CalcYinf(S) + CalcY0(S) + CalcYg(S);
        }

        public List<State> BuildFuncOfState(List<Sensor> S) {
            Vector<Double> y = CalcY(S);
            List<State> res = new List<State>();
            for (int i = 0; i < InputS.Count; i++)
                res.Add(new State(InputS[i], y[i]));
            return res;
        }
    }
}
