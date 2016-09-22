using System;
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

            try
            {
                txtDeterminant.Clear();

                double[] x = new double[grdData.Rows.Count - 1];
                double[][] a = new double[grdData.Rows.Count - 1][], a2 = new double[grdData.Rows.Count - 1][], b = new double[1][], inv = null;
                b[0] = new double[a.Length];
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = new double[a.Length];
                    a2[i] = new double[a.Length];
                    x[i] = double.Parse(grdData.Rows[a.Length].Cells[i].FormattedValue.ToString());
                    b[0][i] = double.Parse(grdData.Rows[i].Cells[a.Length].FormattedValue.ToString());
                    for (int j = 0; j < a.Length; j++)
                    {
                        a2[i][j] = a[i][j] = double.Parse(grdData.Rows[i].Cells[j].FormattedValue.ToString());
                    }
                }

                if (rdGauss.Checked)
                {
                    var r = LinearSystem.gauss(a2, b);
                    x = LinearSystem.retrosubstitution(r, b[0]);

                    if (chkDeterminant.Checked)
                    {
                        txtDeterminant.Text = LinearSystem.determinant(r).ToString();
                    }

                    if (chkReverse.Checked)
                    {
                        if (LinearSystem.determinant(r) == 0)
                        {
                            MessageBox.Show("Não foi possível calcular a inversa, o determinante é nulo.");
                        }
                        else
                        {
                            inv = LinearSystem.gaussReverse(a);
                        }
                    }
                }
                else if (rdGaussPartial.Checked)
                {
                    var n = LinearSystem.gaussPartial(a2, b);
                    x = LinearSystem.retrosubstitution(a2, b[0]);

                    if (chkDeterminant.Checked)
                    {
                        txtDeterminant.Text = (LinearSystem.determinant(a) * Math.Pow(-1, n)).ToString();
                    }

                    if (chkReverse.Checked)
                    {
                        if (LinearSystem.determinant(a) == 0)
                        {
                            MessageBox.Show("Não foi possível calcular a inversa, o determinante é nulo.");
                        }
                        else
                        {
                            inv = LinearSystem.gaussPartialReverse(a);
                        }
                    }
                }
                else if (rdGaussFull.Checked)
                {
                    var v = new int[a.Length];
                    for (int i = 0; i < a.Length; i++)
                        v[i] = i;
                    var n = LinearSystem.gaussFull(a2, b, v);
                    var aux = LinearSystem.retrosubstitution(a2, b[0]);
                    int j;
                    x = new double[a.Length];

                    for (int i = 0; i < a.Length; i++)
                    {
                        for (j = 0; j < a.Length && v[j] != i; j++) ;
                        x[i] = aux[j];
                    }

                    if (chkDeterminant.Checked)
                    {
                        txtDeterminant.Text = (LinearSystem.determinant(a2) * Math.Pow(-1, n)).ToString();
                    }

                    if (chkReverse.Checked)
                    {
                        if (LinearSystem.determinant(a2) == 0)
                        {
                            MessageBox.Show("Não foi possível calcular a inversa, o determinante é nulo.");
                        }
                        else
                        {
                            MessageBox.Show("Nota: Inversa por Gauss Total não funcionando corretament.");
                            inv = LinearSystem.gaussFullReverse(a2);
                        }
                    }
                }
                else if (rdLU.Checked)
                {
                    var r = LinearSystem.lu(a2);
                    x = LinearSystem.retrosubstitution(r[1], LinearSystem.substitution(r[0], b[0]));

                    if (chkDeterminant.Checked)
                    {
                        txtDeterminant.Text = LinearSystem.determinant(r[1]).ToString();
                    }

                    if (chkReverse.Checked)
                    {
                        if (LinearSystem.determinant(r[1]) == 0)
                        {
                            MessageBox.Show("Não foi possível calcular a inversa, o determinante é nulo.");
                        }
                        else
                        {
                            var id = new double[a.Length];
                            inv = new double[a.Length][];

                            for (int i = 0; i < a.Length; i++)
                            {
                                id[i] = 1;
                                if (i != 0)
                                {
                                    id[i - 1] = 0;
                                }
                                inv[i] = LinearSystem.retrosubstitution(r[1], LinearSystem.substitution(r[0], id));
                            }
                            inv = LinearSystem.transposed(inv);
                        }
                    }
                }
                else if (rdGaussCompact.Checked)
                {
                    var r = LinearSystem.gaussCompact(a2, b);
                    x = LinearSystem.retrosubstitution(r, b[0]);

                    if (chkDeterminant.Checked)
                    {
                        txtDeterminant.Text = LinearSystem.determinant(r).ToString();
                    }

                    if (chkReverse.Checked)
                    {
                        var id = LinearSystem.identity(a.Length);
                        var lu = LinearSystem.gaussCompact(a2, id);
                        if (LinearSystem.determinant(lu) == 0)
                        {
                            MessageBox.Show("Não foi possível calcular a inversa, o determinante é nulo.");
                        }
                        else
                        {
                            inv = new double[a.Length][];
                            for (int i = 0; i < a.Length; i++)
                            {
                                inv[i] = LinearSystem.retrosubstitution(lu, id[i]);
                            }
                            inv = LinearSystem.transposed(inv);
                        }
                    }
                }
                else if (rdCholesky.Checked)
                {
                    var r = LinearSystem.cholesky(a2, b[0]);
                    x = LinearSystem.retrosubstitution(r[1], LinearSystem.substitution(r[0], b[0]));

                    if (chkDeterminant.Checked)
                    {
                        var d = LinearSystem.determinant(r[0]);
                        txtDeterminant.Text = (d * d).ToString();
                    }

                    if (chkReverse.Checked)
                    {
                        if (LinearSystem.determinant(r[0]) == 0)
                        {
                            MessageBox.Show("Não foi possível calcular a inversa, o determinante é nulo.");
                        }
                        else
                        {
                            double[] id = new double[a.Length];
                            inv = new double[a.Length][];
                            for (int i = 0; i < a.Length; i++)
                            {
                                id[i] = 1;
                                if (i != 0)
                                {
                                    id[i - 1] = 0;
                                }
                                inv[i] = LinearSystem.retrosubstitution(r[1], LinearSystem.substitution(r[0], id));
                            }
                        }
                    }
                }
                else if (rdJacobi.Checked)
                {
                    x = LinearSystem.jacobi(a2, b[0], x, double.Parse(txtE.Text), int.Parse(txtMaxIt.Text));
                }
                else if (rdGaussSeidel.Checked)
                {
                    x = LinearSystem.gaussSeidel(a2, b[0], x, double.Parse(txtE.Text), int.Parse(txtMaxIt.Text));
                }
                else
                {
                    MessageBox.Show("Nenhum método foi selecionado.");
                    return;
                }

                for (int i = 0; i < x.Length; i++)
                {
                    grdData.Rows[x.Length].Cells[i].Value = x[i];
                    if (inv != null)
                    {
                        for (int j = 0; j < inv.Length; j++)
                        {
                            grdData.Rows[i].Cells[j].Value = inv[i][j];
                        }
                    }
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
            txtE.Text = txtMaxIt.Text = txtN.Text = String.Empty;
            grdData.Rows.Clear();
            grdData.Columns.Clear();
        }
    }
}
