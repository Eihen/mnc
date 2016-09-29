namespace MNC.Public
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDerivatives = new System.Windows.Forms.Button();
            this.btnRoots = new System.Windows.Forms.Button();
            this.btnLinearSystems = new System.Windows.Forms.Button();
            this.btnInterpolations = new System.Windows.Forms.Button();
            this.btnFittings = new System.Windows.Forms.Button();
            this.btnIntegrals = new System.Windows.Forms.Button();
            this.btnNonLinearSystems = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDerivatives
            // 
            this.btnDerivatives.Location = new System.Drawing.Point(12, 12);
            this.btnDerivatives.Name = "btnDerivatives";
            this.btnDerivatives.Size = new System.Drawing.Size(216, 23);
            this.btnDerivatives.TabIndex = 0;
            this.btnDerivatives.Text = "Derivadas";
            this.btnDerivatives.UseVisualStyleBackColor = true;
            this.btnDerivatives.Click += new System.EventHandler(this.btnDerivatives_Click);
            // 
            // btnRoots
            // 
            this.btnRoots.Location = new System.Drawing.Point(12, 41);
            this.btnRoots.Name = "btnRoots";
            this.btnRoots.Size = new System.Drawing.Size(216, 23);
            this.btnRoots.TabIndex = 1;
            this.btnRoots.Text = "Raízes de Funções";
            this.btnRoots.UseVisualStyleBackColor = true;
            this.btnRoots.Click += new System.EventHandler(this.btnRoots_Click);
            // 
            // btnLinearSystems
            // 
            this.btnLinearSystems.Location = new System.Drawing.Point(12, 70);
            this.btnLinearSystems.Name = "btnLinearSystems";
            this.btnLinearSystems.Size = new System.Drawing.Size(216, 23);
            this.btnLinearSystems.TabIndex = 2;
            this.btnLinearSystems.Text = "Sistemas Lineares";
            this.btnLinearSystems.UseVisualStyleBackColor = true;
            this.btnLinearSystems.Click += new System.EventHandler(this.btnLinearSystems_Click);
            // 
            // btnInterpolations
            // 
            this.btnInterpolations.Location = new System.Drawing.Point(12, 99);
            this.btnInterpolations.Name = "btnInterpolations";
            this.btnInterpolations.Size = new System.Drawing.Size(216, 23);
            this.btnInterpolations.TabIndex = 3;
            this.btnInterpolations.Text = "Interpolação de pontos";
            this.btnInterpolations.UseVisualStyleBackColor = true;
            this.btnInterpolations.Click += new System.EventHandler(this.btnInterpolations_Click);
            // 
            // btnFittings
            // 
            this.btnFittings.Enabled = false;
            this.btnFittings.Location = new System.Drawing.Point(12, 128);
            this.btnFittings.Name = "btnFittings";
            this.btnFittings.Size = new System.Drawing.Size(216, 23);
            this.btnFittings.TabIndex = 4;
            this.btnFittings.Text = "Ajuste de Curvas";
            this.btnFittings.UseVisualStyleBackColor = true;
            // 
            // btnIntegrals
            // 
            this.btnIntegrals.Location = new System.Drawing.Point(12, 157);
            this.btnIntegrals.Name = "btnIntegrals";
            this.btnIntegrals.Size = new System.Drawing.Size(216, 23);
            this.btnIntegrals.TabIndex = 5;
            this.btnIntegrals.Text = "Integrais";
            this.btnIntegrals.UseVisualStyleBackColor = true;
            this.btnIntegrals.Click += new System.EventHandler(this.btnIntegrals_Click);
            // 
            // btnNonLinearSystems
            // 
            this.btnNonLinearSystems.Enabled = false;
            this.btnNonLinearSystems.Location = new System.Drawing.Point(12, 186);
            this.btnNonLinearSystems.Name = "btnNonLinearSystems";
            this.btnNonLinearSystems.Size = new System.Drawing.Size(216, 23);
            this.btnNonLinearSystems.TabIndex = 6;
            this.btnNonLinearSystems.Text = "Sistemas Não Lineares";
            this.btnNonLinearSystems.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 334);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(216, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(12, 279);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(216, 23);
            this.btnAbout.TabIndex = 8;
            this.btnAbout.Text = "Sobre";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(12, 250);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(216, 23);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.Text = "Ajuda";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 367);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnNonLinearSystems);
            this.Controls.Add(this.btnIntegrals);
            this.Controls.Add(this.btnFittings);
            this.Controls.Add(this.btnInterpolations);
            this.Controls.Add(this.btnLinearSystems);
            this.Controls.Add(this.btnRoots);
            this.Controls.Add(this.btnDerivatives);
            this.Name = "frmMain";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDerivatives;
        private System.Windows.Forms.Button btnRoots;
        private System.Windows.Forms.Button btnLinearSystems;
        private System.Windows.Forms.Button btnInterpolations;
        private System.Windows.Forms.Button btnFittings;
        private System.Windows.Forms.Button btnIntegrals;
        private System.Windows.Forms.Button btnNonLinearSystems;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnHelp;
    }
}