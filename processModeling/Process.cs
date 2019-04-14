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
    class Process
    {
        Vector<Point2D> InputS; // S = {(x,t)}
        Vector<Point2D> PrehistoryS; // предісторія
        Vector<Point2D> NotInS; // не з заданої області S

        Vector<Point2D> ValFromArea; // y(s) з області
        Vector<Point2D> ValFromOutline; // y(s) з контура
        Vector<Point2D> ValCurrent; // y(s) поточні

        Matrix<double> A;
        Matrix<double> A11;
        Matrix<double> A12;
        Matrix<double> A21;
        Matrix<double> A22;

        List<string> ListLinearOperator = new List<string>() { "Dt - Dx^2" };
        List<string> ListGreenFunction = new List<string>() { "H(t-t')/(....)" };

        private double YFunc(Point2D s)
        {
            return Math.Sin(s.X) * Math.Cos(s.Y);
        }

        private void FillValFromArea()
        {
            for (int i = 0; i < InputS.Count; i++)
                if (InputS[i].Y == 0)
                    ValFromArea.Add(InputS[i]);
        }

       private void FillValFromOutline()
        {
            List<Point2D> SortedInputS = SortInputSPoints();
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

        private List<Point2D> SortInputSPoints() {
            List<Point2D> SortedS = new List<Point2D>(InputS);
            for (int p = 0; p <= InputS.Count - 2; p++)
            {
                for (int i = 0; i <= InputS.Count -2; i++)
                {
                    if (SortedS[i].X > SortedS[i + 1].X)
                    {
                        Point2D temp = SortedS[i + 1];
                        SortedS[i + 1] = SortedS[i];
                        SortedS[i] = temp;
                    }
                }
            }
            return SortedS;
        }

       private void FillValCurrent()
        {
            for (int i = 0; i < InputS.Count; i++) {
                if (InputS[i] != ValFromOutline[i])
                    ValCurrent.Add(InputS[i]);
            }
        }

        public void FillPrehistoryS(int size, List<Point2D> values) {
            for (int i = 0; i < size; i++)
                PrehistoryS.Add(values[i]);
        }

        public void FillNotInS(int size, List<Point2D> values)
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

        private void FormMatrixA()
        {
            A = Matrix<double>.Build.Dense(InputS.Count + ValFromOutline.Count , PrehistoryS.Count + NotInS.Count());
           
        }

        private Matrix<double> calcP1() {
           Matrix<double>At = A.Transpose();
            return A * At;
        }

        public double UFunc(Point2D s)
        { 
            return Math.Cos(s.Y)*Math.Sin(s.X) - Math.Pow(Math.Sin(s.Y)*Math.Cos(s.X), 2);
        }

        private int HeavisideFunc(double x) {
            if (x < 0)
                return 0;
            return 1;
        }

        public double GreenFunc(Point2D s, Point2D s_) // s, s`
        {
            return HeavisideFunc(s.Y - s_.Y) / (Math.Sqrt(4 * Math.PI * (s.Y - s_.Y))) * Math.Exp(-Math.Pow(Math.Abs(s.X - s_.X), 2) / 4 * (s.Y - s_.Y));
        }

        Process(int Size, List<double> InitX, List<double> InitT) {
            for (int i = 0; i < InputS.Count; i++)
                InputS.Add(new Point2D(InitX[i], InitT[i]));
        }



    }
}
