using MNC.Plots;
using MNC.Public;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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

        private void chkModifiedFalsePosition_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkBissection_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            txtA.Text = txtB.Text = txtN.Text = txtFx.Text = String.Empty;
            grdIntegrals.Rows.Clear();
            chkLeftRectangle.Checked = chkRightRectangle.Checked = chkTrapezium.Checked = chkSimpson13.Checked = chkSimpson38.Checked = chkGaussianQuadrature.Checked = false;
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

            grdIntegrals.Rows.Clear();
            try
            {
                Integral i = new Integral(txtFx.Text, double.Parse(txtA.Text), double.Parse(txtB.Text), int.Parse(txtN.Text));
                if (chkLeftRectangle.Checked)
                {
                    grdIntegrals.Rows.Add(new String[] { chkLeftRectangle.Text, i.leftRectangle().ToString() });
                }
                if (chkRightRectangle.Checked)
                {
                    grdIntegrals.Rows.Add(new String[] { chkRightRectangle.Text, i.rightRectangle().ToString() });
                }
                if (chkTrapezium.Checked)
                {
                    grdIntegrals.Rows.Add(new String[] { chkTrapezium.Text, i.trapezium().ToString() });
                }
                if (chkGaussianQuadrature.Checked)
                {
                    grdIntegrals.Rows.Add(new String[] { chkGaussianQuadrature.Text, i.gaussianQuadrature().ToString() });
                }
                if (chkSimpson13.Checked)
                {
                    grdIntegrals.Rows.Add(new String[] { chkSimpson13.Text, i.simpson13().ToString() });
                }
                if (chkSimpson38.Checked)
                {
                    grdIntegrals.Rows.Add(new String[] { chkSimpson38.Text, i.simpson38().ToString() });
                }
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is OverflowException)
                {
                    MessageBox.Show("Um ou mais dos valores digitados são inválidos.");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnPlot_Click(object sender, EventArgs e)
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

            List<Function> functions = new List<Function>();
            functions.Add(new Function("f(x)", txtFx.Text, "x", double.Parse(txtA.Text), double.Parse(txtB.Text), 0.5, SeriesChartType.SplineArea));
            frmPlots plot = new frmPlots(functions);
            plot.Show();
        }

        private void frmIntegrals_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            new frmHelp().Show();
        }
    }
}
