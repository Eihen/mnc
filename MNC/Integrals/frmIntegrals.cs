using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MNC.Integrals
{
    public partial class frmIntegrals : Form
    {
        public frmIntegrals()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rdModifiedFalsePosition_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdBissection_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            txtA.Text = txtB.Text = txtN.Text = txtFx.Text = txtS.Text = String.Empty;
        }

        private void btnCalc1_Click(object sender, EventArgs e)
        {
            if (txtFx.Text == String.Empty)
            {
                MessageBox.Show("Você não preencheu a função!");
                return;
            }
            if (txtA.Text == String.Empty)
            {
                MessageBox.Show("Você não preencheu o a!");
                return;
            }
            if (txtB.Text == String.Empty)
            {
                MessageBox.Show("Você não preencheu o b!");
                return;
            }
            if (txtN.Text == String.Empty)
            {
                MessageBox.Show("Você não preencheu o n!");
                return;
            }

            Integral i = new Integral(txtFx.Text, double.Parse(txtA.Text), double.Parse(txtB.Text), int.Parse(txtN.Text));
            if (rdLeftRectangle.Checked)
            {
                txtS.Text = i.leftRectangle().ToString();
            }
            else if (rdRightRectangle.Checked)
            {
                txtS.Text = i.rightRectangle().ToString();
            }
            else if (rdTrapezium.Checked)
            {
                txtS.Text = i.trapezium().ToString();
            }
            else if (rdGaussianQuadrature.Checked)
            {
                txtS.Text = i.gaussianQuadrature().ToString();
            }
            else if (rdSimpson13.Checked)
            {
                txtS.Text = i.simpson13().ToString();
            }
            else if (rdSimpson38.Checked)
            {
                txtS.Text = i.simpson38().ToString();
            }
        }
    }
}
