using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MNC.Public;
using MNC.Derivatives;

namespace MNC.NonLinearSystems
{
    public partial class frmNonLinearSystems : Form
    {
        public frmNonLinearSystems()
        {
            InitializeComponent();
        }

        private void frmNonLinearSystems_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            new frmHelp().Show();
        }

        private void btnCalc1_Click(object sender, EventArgs e)
        {
            try
            {
                var xs = new SortedList<String, double>();
                var exps = new String[grdX.Rows.Count - 1];
                for (int i = 0; i < grdX.Rows.Count - 1; i++)
                {
                    xs.Add("x" + (i + 1), double.Parse(grdX.Rows[i].Cells[0].Value.ToString()));
                    exps[i] = grdX.Rows[i].Cells[1].Value.ToString();
                }

                var n = new NonLinearSystem(exps, xs, int.Parse(txtMaxIt.Text), double.Parse(txtE.Text));

                if (rdNewton.Checked)
                {
                    xs = n.newton();
                }
                else if (rdModifiedNewton.Checked)
                {
                    xs = n.modifiedNewton();
                }
                else
                {
                    return;
                }

                for (int i = 0; i < xs.Count; i++)
                {
                    grdX.Rows[i].Cells[0].Value = xs.Values[i];
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
