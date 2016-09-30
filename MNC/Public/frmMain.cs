using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MNC.Derivatives;
using MNC.Roots;
using MNC.LinearSystems;
using MNC.Interpolations;
using MNC.Integrals;
using MNC.NonLinearSystems;

namespace MNC.Public
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new frmAbout().ShowDialog();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            new frmHelp().ShowDialog();
        }

        private void btnDerivatives_Click(object sender, EventArgs e)
        {
            new frmDerivatives().ShowDialog();
        }

        private void btnRoots_Click(object sender, EventArgs e)
        {
            new frmRoots().ShowDialog();
        }

        private void btnLinearSystems_Click(object sender, EventArgs e)
        {
            new frmLinearSystems().ShowDialog();
        }

        private void btnInterpolations_Click(object sender, EventArgs e)
        {
            new frmInterpolations().ShowDialog();
        }

        private void btnIntegrals_Click(object sender, EventArgs e)
        {
            new frmIntegrals().ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNonLinearSystems_Click(object sender, EventArgs e)
        {
            new frmNonLinearSystems().ShowDialog();
        }
    }
}
