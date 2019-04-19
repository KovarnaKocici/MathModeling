using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace processModeling
{
    public partial class FormMM : Form
    {
        public FormMM()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (comboBoxDynamic.SelectedIndex != 0 || comboBoxProcess.SelectedIndex != 0 || comboBoxX.SelectedIndex != 0 || comboBoxY.SelectedIndex!=0)
            { MessageBox.Show("Даний випадок не передбачений"); }
            if (textBoxX1.Text==String.Empty || textBoxXn.Text == String.Empty) { MessageBox.Show("Введіть, будь ласка, всі дані!"); }
            if (textBoxX1.Text != String.Empty && textBoxXn.Text != String.Empty && textBoxT.Text != String.Empty)
            {
                Process process = new Process(Convert.ToDouble(textBoxX1.Text), Convert.ToDouble(textBoxXn.Text), Convert.ToDouble(textBoxT.Text));
                //Calculate
                process.FormY();
                process.FormMatrixA();
                process.FormP1();
                process.FormU0();
                process.FormUg();
                //Y from InputS
                List<State> res = process.BuildFuncOfState(process.InputS);
                //Y from RandomS
                //process.BuildFuncOfState(process.GenerateS(0, 1000, 500));
                //y(s) = yinf + y0 + yg
                SurfaceControl surface = new SurfaceControl();
                surface.Data = res;
                surface.Redraw();
                elementHost1.Child = surface;
                
            }

        }

       
    }
}
