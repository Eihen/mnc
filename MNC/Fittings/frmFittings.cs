using MNC.Plots;
using MNC.Public;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace MNC.Fittings
{
    public partial class frmFittings : Form
    {
        public frmFittings()
        {
            InitializeComponent();
        }

        private void frmFittings_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            new frmHelp().Show();
        }

        private void frmFittings_Load(object sender, EventArgs e)
        {
        }

        private void btnCalc1_Click(object sender, EventArgs e)
        {
            if (grdX.Rows.Count < 2)
            {
                MessageBox.Show("Você não forneceu nenhum ponto!");
                return;
            }

            if (chkPolynomial.Checked && txtO.Text == String.Empty)
                MessageBox.Show("Você não preencheu a ordem do polinômio!");

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

            Fitting f = new Fitting(points);

            txtPolynomialF.Text = chkPolynomial.Checked ? f.fittingPolynomial(int.Parse(txtO.Text)) : String.Empty;
            txtPolynomialR.Text = chkPolynomial.Checked ? f.coefficient(txtPolynomialF.Text, "x").ToString() : String.Empty;

            txtAbxF.Text = chkAbx.Checked ? f.fittingAbx() : String.Empty;
            txtAbxR.Text = chkAbx.Checked ? f.coefficient(txtAbxF.Text, "x").ToString() : String.Empty;

            txtAebxF.Text = chkAebx.Checked ? f.fittingAebx() : String.Empty;
            txtAebxR.Text = chkAebx.Checked ? f.coefficient(txtAebxF.Text, "x").ToString() : String.Empty;

            txtAxbF.Text = chkAxb.Checked ? f.fittingAxb() : String.Empty;
            txtAxbR.Text = chkAxb.Checked ? f.coefficient(txtAxbF.Text, "x").ToString() : String.Empty;

            txt1abxF.Text = chk1abx.Checked ? f.fitting1abx() : String.Empty;
            txt1abxR.Text = chk1abx.Checked ? f.coefficient(txt1abxF.Text, "x").ToString() : String.Empty;

        }

        private void grdX_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            grdX.Rows[e.Row.Index - 1].HeaderCell.Value = String.Format("{0}", e.Row.Index);
        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            grdX.Rows.Clear();
            txtFx.Text = txtPolynomialF.Text = txtPolynomialR.Text = txtAbxF.Text = txtAbxR.Text = 
                txtAebxF.Text = txtAebxR.Text = txtAxbF.Text = txtAxbR.Text = txt1abxF.Text = txt1abxR.Text = String.Empty;
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
                if (chkPolynomial.Checked)
                {
                    if (txtPolynomialF.Text == String.Empty)
                        throw new Exception("Você precisa realizar o calculo primeiro!");

                    functions.Add(new Function("Sistema Linear", txtPolynomialF.Text, "x", a, b, 0.1));
                }
                if (chkAbx.Checked)
                {
                    if (txtAbxF.Text == String.Empty)
                        throw new Exception("Você precisa realizar o calculo primeiro!");
                    functions.Add(new Function("Newton", txtAbxF.Text, "x", a, b, 0.1));
                }
                if (chkAebx.Checked)
                {
                    if (txtAebxF.Text == String.Empty)
                        throw new Exception("Você precisa realizar o calculo primeiro!");
                    functions.Add(new Function("Newton-Gregory", txtAebxF.Text, "s", a, b, 0.1));
                }
                if (chkAxb.Checked)
                {
                    if (txtAxbF.Text == String.Empty)
                        throw new Exception("Você precisa realizar o calculo primeiro!");
                    functions.Add(new Function("Newton-Gregory", txtAxbF.Text, "s", a, b, 0.1));
                }
                if (chk1abx.Checked)
                {
                    if (txt1abxF.Text == String.Empty)
                        throw new Exception("Você precisa realizar o calculo primeiro!");
                    functions.Add(new Function("Newton-Gregory", txt1abxF.Text, "s", a, b, 0.1));
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

        private void rdExpression_CheckedChanged(object sender, EventArgs e)
        {
            txtFx.Enabled = rdExpression.Checked;
            grdX.Columns[1].Visible = txtFx.ReadOnly = !rdExpression.Checked;
        }
    }
}
