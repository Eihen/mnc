using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MNC.LinearSystems
{
    public partial class frmLinearSystems : Form
    {
        public frmLinearSystems()
        {
            InitializeComponent();
        }

        private void rdBissection_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdModifiedFalsePosition_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdModifiedNewton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtA_Validated(object sender, EventArgs e)
        {

        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(txtN.Text, out n))
            {
                grdData.Rows.Clear();
                grdData.Columns.Clear();

                if (n > 0)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        grdData.Columns.Add((i).ToString(), (i).ToString());
                        grdData.Rows.Add();
                        grdData.Rows[i - 1].HeaderCell.Value = (i).ToString();
                    }
                    grdData.Columns.Add("b", "b");
                    grdData.Rows.Add();
                    grdData.Rows[grdData.Rows.Count - 1].HeaderCell.Value = "x";
                }
            }
        }

        private void frmLinearSystems_Load(object sender, EventArgs e)
        {
            grdData.TopLeftHeaderCell.Value = "A";
        }

        private void btnCalc1_Click(object sender, EventArgs e)
        {
            if (txtN.Text == String.Empty)
            {
                MessageBox.Show("Você não preencheu o número de variáveis!");
                return;
            }

            double[] x = new double[grdData.Rows.Count - 1];

            if (rdGaussSeidel.Checked || rdJacobi.Checked)
            {
                if (txtE.Text == String.Empty)
                {
                    MessageBox.Show("Você não preencheu o E!");
                    return;
                }
                if (txtMaxIt.Text == String.Empty)
                {
                    MessageBox.Show("Você não preencheu o MaxIt!");
                    return;
                }
            }

            double[][] a = new double[grdData.Rows.Count - 1][], b = new double[1][];
            double d;
            b[0] = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new double[a.Length];
                b[0][i] = double.TryParse(grdData.Rows[i].Cells[a.Length - 1].Value.ToString(), out d) ? d : 0;
                for (int j = 0; j < a.Length; j++)
                {
                    a[i][j] = double.TryParse(grdData.Rows[i].Cells[j].Value.ToString(), out d) ? d : 0;
                }
            }

            if (rdGauss.Checked)
            {

                if (chkSystem.Checked)
                    x = LinearSystem.retrosubstitution(LinearSystem.gauss(LinearSystem.copy(a), b), b[0]);

                if (chkDeterminant.Checked)
                    d = 0;

                if (chkReverse.Checked)
                    d = 0;
            }
            else if (rdGaussPartial.Checked)
            {
                if (chkSystem.Checked)
                    d = 0;

                if (chkDeterminant.Checked)
                    d = 0;

                if (chkReverse.Checked)
                    d = 0;
            }
            else if (rdGaussFull.Checked)
            {
                if (chkSystem.Checked)
                    d = 0;

                if (chkDeterminant.Checked)
                    d = 0;

                if (chkReverse.Checked)
                    d = 0;
            }
            else if (rdGaussCompact.Checked)
            {
                if (chkSystem.Checked)
                    d = 0;

                if (chkDeterminant.Checked)
                    d = 0;

                if (chkReverse.Checked)
                    d = 0;
            }
            else if (rdLU.Checked)
            {
                if (chkSystem.Checked)
                    d = 0;

                if (chkDeterminant.Checked)
                    d = 0;

                if (chkReverse.Checked)
                    d = 0;
            }
            else if (rdCholesky.Checked)
            {
                if (chkSystem.Checked)
                    d = 0;

                if (chkDeterminant.Checked)
                    d = 0;

                if (chkReverse.Checked)
                    d = 0;
            }
            else if (rdJacobi.Checked)
            {
                if (chkSystem.Checked)
                    d = 0;

                if (chkDeterminant.Checked)
                    d = 0;

                if (chkReverse.Checked)
                    d = 0;
            }
            else if (rdGaussSeidel.Checked)
            {
                if (chkSystem.Checked)
                    d = 0;

                if (chkDeterminant.Checked)
                    d = 0;

                if (chkReverse.Checked)
                    d = 0;
            }
        }
    }
}
