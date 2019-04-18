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
            if (textBoxX1.Text != null && textBoxXn.Text != null && comboBoxT.SelectedItem == comboBoxT.Items[0])
            {
                Process process = new Process(Convert.ToDouble(textBoxX1.Text), Convert.ToDouble(textBoxXn.Text), Convert.ToDouble(comboBoxT.SelectedItem));
                //Calculate
                process.FormY();
                process.FormMatrixA();
                process.FormP1();
                process.FormU0();
                process.FormUg();
                process.BuildFuncOfState();
                //y(s) = yinf + y0 + yg
            }

        }

        private void comboBoxT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
