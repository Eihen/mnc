using MNC.Plots;
using MNC.Public;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MNC.Roots
{
    public partial class frmRoots : Form
    {
        Root r;
        SortedList<double, double> roots;

        public frmRoots()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmRoots_Load(object sender, EventArgs e)
        {
            grdRanges.TopLeftHeaderCell.Value = grdRoots.TopLeftHeaderCell.Value = "i";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtDelta_TextChanged(object sender, EventArgs e)
        {

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
            if (txtBigDelta.Text == String.Empty)
            {
                MessageBox.Show("Você não preencheu o Δ!");
                return;
            }
            if (txtDelta.Text == String.Empty)
            {
                MessageBox.Show("Você não preencheu o δ!");
                return;
            }
            if (txtMaxIt.Text == String.Empty)
            {
                MessageBox.Show("Você não preencheu o MaxIt!");
                return;
            }

            try
            {
                r = new Root(txtFx.Text, double.Parse(txtA.Text), double.Parse(txtB.Text), double.Parse(txtBigDelta.Text), double.Parse(txtDelta.Text), int.Parse(txtMaxIt.Text), double.Parse(txtDelta.Text));
                if (!chkRangesOnly.Checked)
                {
                    if (rdBissection.Checked)
                        roots = r.bisection();
                    else if (rdFalsePosition.Checked)
                        roots = r.falsePosition();
                    else if (rdNewton.Checked)
                        roots = r.newton();
                    else if (rdUniformSearch.Checked)
                        roots = r.uniformSearch();
                    else if (rdModifiedFalsePosition.Checked)
                        roots = r.modifiedFalsePosition();
                    else if (rdModifiedNewton.Checked)
                        roots = r.modifiedNewton();

                    grdRoots.Rows.Clear();

                    for (int i = 0; i < roots.Count; i++)
                    {
                        grdRoots.Rows.Add();
                        grdRoots.Rows[i].Cells[0].Value = roots.Keys[i];
                        grdRoots.Rows[i].Cells[1].Value = roots.Values[i];
                    }
                }

                grdRanges.Rows.Clear();
                grdRanges.Columns.Clear();
                if (chkRanges.Checked)
                {
                    grdRanges.Columns.Add("1", "1");
                    grdRanges.Rows.Add(2);
                    grdRanges.Rows[0].HeaderCell.Value = "a[i]";
                    grdRanges.Rows[1].HeaderCell.Value = "b[i]";
                    grdRanges.Rows[0].Cells[0].Value = r.Ranges[0].a;
                    grdRanges.Rows[1].Cells[0].Value = r.Ranges[0].b;
                    for (int i = 1; i < r.Ranges.Count; i++)
                    {
                        grdRanges.Columns.Add((i + 1).ToString(), (i + 1).ToString());
                        grdRanges.Rows[0].Cells[i].Value = r.Ranges[i].a;
                        grdRanges.Rows[1].Cells[i].Value = r.Ranges[i].b;
                    }
                }

                if (chkPlot.Checked)
                {
                    btnPlot.PerformClick();
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

        private void btnClear1_Click(object sender, EventArgs e)
        {
            txtA.Text = txtB.Text = txtDelta.Text = txtBigDelta.Text = txtFx.Text = txtMaxIt.Text = String.Empty;
            grdRoots.Rows.Clear();
            grdRanges.Rows.Clear();
            grdRanges.Columns.Clear();
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
            if (txtBigDelta.Text == String.Empty)
            {
                MessageBox.Show("Você não preencheu o Δ!");
                return;
            }

            List<Function> functions = new List<Function>();
            functions.Add(new Function("f(x)", txtFx.Text, "x", double.Parse(txtA.Text), double.Parse(txtB.Text), double.Parse(txtBigDelta.Text)));
            frmPlots plot = new frmPlots(functions);
            plot.Show();
        }

        private void frmRoots_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            new frmHelp().Show();
        }
    }
}
