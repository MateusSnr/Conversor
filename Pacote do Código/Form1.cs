using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP01_200581
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtR1.Clear();
            TxtR2.Clear();
            TxtR3.Clear();

            LblCalculoR4.Text = "";
            LblCalculoR5.Text = "";
            LblCalculoR6.Text = "";


        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            float calculo4;
            float calculo5;
            float calculo6;

            calculo4 = ((float.Parse(TxtR1.Text) * float.Parse(TxtR2.Text)) / (int.Parse(TxtR1.Text) + int.Parse(TxtR2.Text) + int.Parse(TxtR3.Text)));
            calculo5 = ((float.Parse(TxtR2.Text) * float.Parse(TxtR3.Text)) / (int.Parse(TxtR1.Text) + int.Parse(TxtR2.Text) + int.Parse(TxtR3.Text)));
            calculo6 = ((float.Parse(TxtR3.Text) * float.Parse(TxtR1.Text)) / (int.Parse(TxtR1.Text) + int.Parse(TxtR2.Text) + int.Parse(TxtR3.Text)));

            LblCalculoR4.Text = Convert.ToString(calculo4) + " ohms";
            LblCalculoR5.Text = Convert.ToString(calculo5) + " ohms";
            LblCalculoR6.Text = Convert.ToString(calculo6) + " ohms";

        }
    }
}
