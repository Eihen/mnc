using MNC.Public;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MNC.Derivatives
{
    public partial class frmDerivatives : Form
    {
        Derivative d;
        SortedList<String, double> xs = new SortedList<String, double>();

        public frmDerivatives()
        {
            InitializeComponent();
        }

        private void frmDerivatives_Load(object sender, EventArgs e)
        {
            grdX.TopLeftHeaderCell.Value = "i";
            grdGradient.TopLeftHeaderCell.Value = "i";
            grdHessian.TopLeftHeaderCell.Value = "H[i,j]";
        }

        private void btnCalc1_Click(object sender, EventArgs e)
        {
            if (txtFx.Text == String.Empty)
            {
                MessageBox.Show("Você não preencheu a função!");
                return;
            }
            if (txtX.Text == String.Empty)
            {
                MessageBox.Show("Você não preencheu o x!");
                return;
            }
            if (txtE.Text == String.Empty)
            {
                MessageBox.Show("Você não preencheu o ε!");
                return;
            }
            if (txtMaxIt.Text == String.Empty)
            {
                MessageBox.Show("Você não preencheu o MaxIt!");
                return;
            }

            try
            {
                xs.Clear();
                xs.Add("x", double.Parse(txtX.Text));
                d = new Derivative(txtFx.Text, xs, double.Parse(txtE.Text), int.Parse(txtMaxIt.Text));
                txtF1x.Text = d.derivate1().ToString();
                txtF2x.Text = d.derivate2().ToString();
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

        private void btnClear1_Click(object sender, EventArgs e)
        {
            txtE.Text = txtMaxIt.Text = txtX.Text = txtFx.Text = txtF1x.Text = txtF2x.Text = String.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtFx2.Text == String.Empty)
            {
                MessageBox.Show("Você não preencheu a função!");
                return;
            }
            if (txtE2.Text == String.Empty)
            {
                MessageBox.Show("Você não preencheu o ε!");
                return;
            }
            if (txtMaxIt2.Text == String.Empty)
            {
                MessageBox.Show("Você não preencheu o MaxIt!");
                return;
            }
            if (grdX.Rows.Count < 1)
            {
                MessageBox.Show("Você não preencheu o x!");
                return;
            }

            try
            {
                xs.Clear();

                for (int i = 0; i < grdX.Rows.Count - 1; i++)
                {
                    xs.Add("x" + (i + 1), double.Parse(grdX.Rows[i].Cells[0].Value.ToString()));
                }

                d = new Derivative(txtFx2.Text, xs, double.Parse(txtE2.Text), int.Parse(txtMaxIt2.Text));

                var gradient = d.gradient();
                var hessian = d.hessian();

                grdGradient.Rows.Clear();
                grdHessian.Rows.Clear();
                grdHessian.Columns.Clear();

                DataGridViewRow h;

                for (int i = 0; i < gradient.Length; i++)
                {
                    grdGradient.Rows.Add();
                    grdGradient.Rows[i].Cells[0].Value = gradient[i];
                    grdGradient.Rows[i].HeaderCell.Value = String.Format("{0}", i + 1);

                    grdHessian.Columns.Add((i + 1).ToString(), (i + 1).ToString());

                }

                for (int i = 0; i < gradient.Length; i++)
                {
                    h = new DataGridViewRow();
                    h.HeaderCell.Value = String.Format("{0}", i + 1);
                    for (int j = 0; j < gradient.Length; j++)
                    {
                        h.Cells.Add(new DataGridViewTextBoxCell { Value = hessian[i, j] });
                    }
                    grdHessian.Rows.Add(h);
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

        private void grdX_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            grdX.Rows[e.Row.Index - 1].HeaderCell.Value = String.Format("{0}", e.Row.Index);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtE3.Text == String.Empty)
            {
                MessageBox.Show("Você não preencheu a função!");
                return;
            }
            if (txtMaxIt3.Text == String.Empty)
            {
                MessageBox.Show("Você não preencheu o MaxIt!");
                return;
            }
            if (grdX2.Rows.Count < 1)
            {
                MessageBox.Show("Você não preencheu o x!");
                return;
            }
            if (grdF.Rows.Count < 1)
            {
                MessageBox.Show("Você não preencheu o x!");
                return;
            }

            try
            {
                xs.Clear();
                String[] exps = new String[grdF.Rows.Count - 1];

                for (int i = 0; i < grdX2.Rows.Count - 1; i++)
                {
                    xs.Add("x" + (i + 1), double.Parse(grdX2.Rows[i].Cells[0].Value.ToString()));
                    exps[i] = grdF.Rows[i].Cells[0].Value.ToString();
                }

                d = new Derivative("1+1", xs, double.Parse(txtE3.Text), int.Parse(txtMaxIt3.Text));

                var jacobian = d.jacobian(exps);

                grdJ.Rows.Clear();
                grdJ.Columns.Clear();

                DataGridViewRow h;

                for (int i = 0; i < jacobian.Length; i++)
                {
                    grdJ.Columns.Add((i + 1).ToString(), (i + 1).ToString());
                }

                for (int i = 0; i < jacobian.Length; i++)
                {
                    h = new DataGridViewRow();
                    h.HeaderCell.Value = String.Format("{0}", i + 1);
                    for (int j = 0; j < jacobian.Length; j++)
                    {
                        h.Cells.Add(new DataGridViewTextBoxCell { Value = jacobian[i][j] });
                    }
                    grdJ.Rows.Add(h);
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

        private void grdX2_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            grdX2.Rows[e.Row.Index - 1].HeaderCell.Value = String.Format("{0}", e.Row.Index);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtFx2.Text = txtE2.Text = txtMaxIt2.Text = String.Empty;
            grdX.Rows.Clear();
            grdGradient.Rows.Clear();
            grdHessian.Rows.Clear();
            grdHessian.Columns.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtE3.Text = txtMaxIt3.Text = String.Empty;
            grdX2.Rows.Clear();
            grdF.Rows.Clear();
            grdJ.Rows.Clear();
            grdJ.Columns.Clear();
        }

        private void grdX2_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
        }

        private void grdF_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            grdF.Rows[e.Row.Index - 1].HeaderCell.Value = String.Format("{0}", e.Row.Index);
        }

        private void frmDerivatives_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            new frmHelp().Show();
        }
    }
}