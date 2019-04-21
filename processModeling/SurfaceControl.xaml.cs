using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFSurfacePlot3D;

namespace processModeling
{
    /// <summary>
    /// Логика взаимодействия для SurfaceControl.xaml
    /// </summary>
    public partial class SurfaceControl : UserControl
    {
        public List<State> Data { get; set; }

        public SurfaceControl()
        {
            InitializeComponent();

            //Func<double, double, double> sampleFunction = (x, y) => 10 * Math.Sin(Math.Sqrt(x * x + y * y)) / Math.Sqrt(x * x + y * y);
            //mySurfacePlotModel.PlotFunction(sampleFunction, -10, 5);
            // }
        }

        public void Redraw()
        {

            SurfacePlotModel mySurfacePlotModel = new SurfacePlotModel();
            mySurfacePlotView.DataContext = mySurfacePlotModel;

            if (Data != null)
            {
                //Convert list of states 
                double[] xArray = new double[Data.Count];
                double[] tArray = new double[Data.Count];
                double[,] yArray = new double[Data.Count, Data.Count];
                for (int i = 0; i < Data.Count; i++)
                {
                    xArray[i] = Data[i].sensor.X;
                    tArray[i] = Data[i].sensor.T;
                    for (int j = 0; j < Data.Count; j++)
                    {
                        if (i == j)
                            yArray[i, j] = Data[i].Y;
                        else
                            yArray[i, j] = 0;
                    }
                }
                //draw
                mySurfacePlotModel.PlotData(yArray, xArray, tArray);
            }
        }
    }
}
