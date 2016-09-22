using MNC.Plots;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MNC.Interpolations
{
    public partial class frmInterpolations : Form
    {
        public frmInterpolations()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtFx.Enabled = rdExpression.Checked;
            grdX.Columns[1].Visible = txtFx.ReadOnly = !rdExpression.Checked;
        }

        private void btnCalc1_Click(object sender, EventArgs e)
        {
            if (grdX.Rows.Count < 2)
            {
                MessageBox.Show("Você não forneceu nenhum ponto!");
                return;
            }

            var points = new List<KeyValuePair<double, double>>();

            if (rdExpression.Checked)
            {
                if (txtFx.Text == String.Empty)
                {
                    MessageBox.Show("Você não preencheu a função!");
                    return;
                }

                var exp = new org.mariuszgromada.math.mxparser.Expression(txtFx.Text);
                exp.defineArgument("x", 0);
                if (!exp.checkSyntax())
                {
                    MessageBox.Show("A expressão informada não é válida.");
                }


                for (int i = 0; i < grdX.Rows.Count - 1; i++)
                {
                    exp.setArgumentValue("x", double.Parse(grdX.Rows[i].Cells[0].FormattedValue.ToString()));
                    points.Add(new KeyValuePair<double, double>(exp.getArgumentValue("x"), exp.calculate()));
                }
            }
            else
            {
                for (int i = 0; i < grdX.Rows.Count - 1; i++)
                {
                    points.Add(new KeyValuePair<double, double>(double.Parse(grdX.Rows[i].Cells[0].FormattedValue.ToString()), double.Parse(grdX.Rows[i].Cells[1].FormattedValue.ToString())));
                }
            }

            Interpolation p = new Interpolation(points);

            txtLinearSystem.Text = chkLinearSystem.Checked ? p.linearSystem() : String.Empty;
            txtNewton.Text = chkNewton.Checked ? p.newton() : String.Empty;
            txtNewtonGregory.Text = chkNewtonGregory.Checked ? p.newtonGregory() : String.Empty;

        }

        private void grdX_UserAddedRow_1(object sender, DataGridViewRowEventArgs e)
        {
            grdX.Rows[e.Row.Index - 1].HeaderCell.Value = String.Format("{0}", e.Row.Index);
        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            chkLinearSystem.Checked = chkNewton.Checked = chkNewtonGregory.Checked = false;
            grdX.Rows.Clear();
            txtFx.Text = txtLinearSystem.Text = txtNewton.Text = txtNewtonGregory.Text = String.Empty;
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            try
            {
                List<Function> functions = new List<Function>();
                var a = -10;
                var b = 10;

                if (rdExpression.Checked)
                {
                    if (txtFx.Text == String.Empty)
                        throw new Exception("Você não preencheu Fx");
                    functions.Add(new Function("Original", txtFx.Text, "x", a, b, 0.1));
                }
                if (chkLinearSystem.Checked)
                {
                    if (txtLinearSystem.Text == String.Empty)
                        throw new Exception("Você precisa realizar o calculo primeiro!");

                    functions.Add(new Function("Sistema Linear", txtLinearSystem.Text, "x", a, b, 0.1));
                }
                if (chkNewton.Checked)
                {
                    if (txtNewton.Text == String.Empty)
                        throw new Exception("Você precisa realizar o calculo primeiro!");
                    functions.Add(new Function("Newton", txtNewton.Text, "x", a, b, 0.1));
                }
                if (chkNewtonGregory.Checked)
                {
                    if (txtNewtonGregory.Text == String.Empty)
                        throw new Exception("Você precisa realizar o calculo primeiro!");
                    functions.Add(new Function("Newton-Gregory", txtNewtonGregory.Text, "s", a, b, 0.1));
                }
                if (functions.Count > 0)
                {
                    frmPlots plot = new frmPlots(functions);
                    plot.Show();
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
    }
}
