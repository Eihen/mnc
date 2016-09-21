namespace MNC.LinearSystems
{
    partial class frmLinearSystems
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdGaussSeidel = new System.Windows.Forms.RadioButton();
            this.rdJacobi = new System.Windows.Forms.RadioButton();
            this.rdGaussFull = new System.Windows.Forms.RadioButton();
            this.rdLU = new System.Windows.Forms.RadioButton();
            this.rdCholesky = new System.Windows.Forms.RadioButton();
            this.rdGaussCompact = new System.Windows.Forms.RadioButton();
            this.rdGaussPartial = new System.Windows.Forms.RadioButton();
            this.rdGauss = new System.Windows.Forms.RadioButton();
            this.btnClear1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkDeterminant = new System.Windows.Forms.CheckBox();
            this.chkReverse = new System.Windows.Forms.CheckBox();
            this.chkSystem = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaxIt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.btnCalc1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.rdGaussSeidel);
            this.groupBox4.Controls.Add(this.rdJacobi);
            this.groupBox4.Controls.Add(this.rdGaussFull);
            this.groupBox4.Controls.Add(this.rdLU);
            this.groupBox4.Controls.Add(this.rdCholesky);
            this.groupBox4.Controls.Add(this.rdGaussCompact);
            this.groupBox4.Controls.Add(this.rdGaussPartial);
            this.groupBox4.Controls.Add(this.rdGauss);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(5, 55);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(50);
            this.groupBox4.MaximumSize = new System.Drawing.Size(0, 110);
            this.groupBox4.MinimumSize = new System.Drawing.Size(0, 110);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(490, 110);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Métodos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Diretos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(363, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Iterativos:";
            // 
            // rdGaussSeidel
            // 
            this.rdGaussSeidel.AutoSize = true;
            this.rdGaussSeidel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdGaussSeidel.Location = new System.Drawing.Point(366, 65);
            this.rdGaussSeidel.Name = "rdGaussSeidel";
            this.rdGaussSeidel.Size = new System.Drawing.Size(87, 17);
            this.rdGaussSeidel.TabIndex = 7;
            this.rdGaussSeidel.TabStop = true;
            this.rdGaussSeidel.Text = "Gauss-Seidel";
            this.rdGaussSeidel.UseVisualStyleBackColor = true;
            // 
            // rdJacobi
            // 
            this.rdJacobi.AutoSize = true;
            this.rdJacobi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdJacobi.Location = new System.Drawing.Point(366, 42);
            this.rdJacobi.Name = "rdJacobi";
            this.rdJacobi.Size = new System.Drawing.Size(113, 17);
            this.rdJacobi.TabIndex = 6;
            this.rdJacobi.TabStop = true;
            this.rdJacobi.Text = "Jacobi-Richardson";
            this.rdJacobi.UseVisualStyleBackColor = true;
            // 
            // rdGaussFull
            // 
            this.rdGaussFull.AutoSize = true;
            this.rdGaussFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdGaussFull.Location = new System.Drawing.Point(9, 88);
            this.rdGaussFull.Name = "rdGaussFull";
            this.rdGaussFull.Size = new System.Drawing.Size(167, 17);
            this.rdGaussFull.TabIndex = 5;
            this.rdGaussFull.TabStop = true;
            this.rdGaussFull.Text = "Gauss com Pivotamento Total";
            this.rdGaussFull.UseVisualStyleBackColor = true;
            // 
            // rdLU
            // 
            this.rdLU.AutoSize = true;
            this.rdLU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdLU.Location = new System.Drawing.Point(193, 64);
            this.rdLU.Name = "rdLU";
            this.rdLU.Size = new System.Drawing.Size(116, 17);
            this.rdLU.TabIndex = 4;
            this.rdLU.TabStop = true;
            this.rdLU.Text = "Decomposição L.U";
            this.rdLU.UseVisualStyleBackColor = true;
            this.rdLU.CheckedChanged += new System.EventHandler(this.rdModifiedFalsePosition_CheckedChanged);
            // 
            // rdCholesky
            // 
            this.rdCholesky.AutoSize = true;
            this.rdCholesky.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCholesky.Location = new System.Drawing.Point(193, 87);
            this.rdCholesky.Name = "rdCholesky";
            this.rdCholesky.Size = new System.Drawing.Size(68, 17);
            this.rdCholesky.TabIndex = 3;
            this.rdCholesky.TabStop = true;
            this.rdCholesky.Text = "Cholesky";
            this.rdCholesky.UseVisualStyleBackColor = true;
            this.rdCholesky.CheckedChanged += new System.EventHandler(this.rdModifiedNewton_CheckedChanged);
            // 
            // rdGaussCompact
            // 
            this.rdGaussCompact.AutoSize = true;
            this.rdGaussCompact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdGaussCompact.Location = new System.Drawing.Point(193, 41);
            this.rdGaussCompact.Name = "rdGaussCompact";
            this.rdGaussCompact.Size = new System.Drawing.Size(106, 17);
            this.rdGaussCompact.TabIndex = 2;
            this.rdGaussCompact.TabStop = true;
            this.rdGaussCompact.Text = "Gauss Compacto";
            this.rdGaussCompact.UseVisualStyleBackColor = true;
            this.rdGaussCompact.CheckedChanged += new System.EventHandler(this.rdBissection_CheckedChanged);
            // 
            // rdGaussPartial
            // 
            this.rdGaussPartial.AutoSize = true;
            this.rdGaussPartial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdGaussPartial.Location = new System.Drawing.Point(9, 65);
            this.rdGaussPartial.Name = "rdGaussPartial";
            this.rdGaussPartial.Size = new System.Drawing.Size(175, 17);
            this.rdGaussPartial.TabIndex = 1;
            this.rdGaussPartial.TabStop = true;
            this.rdGaussPartial.Text = "Gauss com Pivotamento Parcial";
            this.rdGaussPartial.UseVisualStyleBackColor = true;
            // 
            // rdGauss
            // 
            this.rdGauss.AutoSize = true;
            this.rdGauss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdGauss.Location = new System.Drawing.Point(9, 42);
            this.rdGauss.Name = "rdGauss";
            this.rdGauss.Size = new System.Drawing.Size(94, 17);
            this.rdGauss.TabIndex = 0;
            this.rdGauss.TabStop = true;
            this.rdGauss.Text = "Gauss Simples";
            this.rdGauss.UseVisualStyleBackColor = true;
            // 
            // btnClear1
            // 
            this.btnClear1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear1.Location = new System.Drawing.Point(358, 173);
            this.btnClear1.Name = "btnClear1";
            this.btnClear1.Size = new System.Drawing.Size(75, 23);
            this.btnClear1.TabIndex = 37;
            this.btnClear1.Text = "Limpar";
            this.btnClear1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkDeterminant);
            this.groupBox1.Controls.Add(this.chkReverse);
            this.groupBox1.Controls.Add(this.chkSystem);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(506, 55);
            this.groupBox1.MaximumSize = new System.Drawing.Size(0, 110);
            this.groupBox1.MinimumSize = new System.Drawing.Size(0, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 110);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções";
            // 
            // chkDeterminant
            // 
            this.chkDeterminant.AutoSize = true;
            this.chkDeterminant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDeterminant.Location = new System.Drawing.Point(9, 42);
            this.chkDeterminant.Name = "chkDeterminant";
            this.chkDeterminant.Size = new System.Drawing.Size(89, 17);
            this.chkDeterminant.TabIndex = 2;
            this.chkDeterminant.Text = "Determinante";
            this.chkDeterminant.UseVisualStyleBackColor = true;
            // 
            // chkReverse
            // 
            this.chkReverse.AutoSize = true;
            this.chkReverse.Enabled = false;
            this.chkReverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReverse.Location = new System.Drawing.Point(9, 65);
            this.chkReverse.Name = "chkReverse";
            this.chkReverse.Size = new System.Drawing.Size(61, 17);
            this.chkReverse.TabIndex = 1;
            this.chkReverse.Text = "Inversa";
            this.chkReverse.UseVisualStyleBackColor = true;
            // 
            // chkSystem
            // 
            this.chkSystem.AutoSize = true;
            this.chkSystem.Checked = true;
            this.chkSystem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSystem.Location = new System.Drawing.Point(9, 20);
            this.chkSystem.Name = "chkSystem";
            this.chkSystem.Size = new System.Drawing.Size(63, 17);
            this.chkSystem.TabIndex = 0;
            this.chkSystem.Text = "Sistema";
            this.chkSystem.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtE);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.txtMaxIt);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.txtN);
            this.groupBox5.Controls.Add(this.lblX);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(5, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(728, 50);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Parâmetros";
            // 
            // txtE
            // 
            this.txtE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtE.Location = new System.Drawing.Point(552, 19);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(170, 20);
            this.txtE.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(529, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "ε = ";
            // 
            // txtMaxIt
            // 
            this.txtMaxIt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxIt.Location = new System.Drawing.Point(346, 19);
            this.txtMaxIt.Name = "txtMaxIt";
            this.txtMaxIt.Size = new System.Drawing.Size(170, 20);
            this.txtMaxIt.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "MaxIt =";
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(119, 19);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(170, 20);
            this.txtN.TabIndex = 16;
            this.txtN.TextChanged += new System.EventHandler(this.txtN_TextChanged);
            this.txtN.Validated += new System.EventHandler(this.txtA_Validated);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(6, 22);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(116, 13);
            this.lblX.TabIndex = 20;
            this.lblX.Text = "Número de váriaveis = ";
            // 
            // btnCalc1
            // 
            this.btnCalc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc1.Location = new System.Drawing.Point(277, 173);
            this.btnCalc1.Name = "btnCalc1";
            this.btnCalc1.Size = new System.Drawing.Size(75, 23);
            this.btnCalc1.TabIndex = 36;
            this.btnCalc1.Text = "Calcular";
            this.btnCalc1.UseVisualStyleBackColor = true;
            this.btnCalc1.Click += new System.EventHandler(this.btnCalc1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdData);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(728, 385);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados";
            // 
            // grdData
            // 
            this.grdData.AllowUserToAddRows = false;
            this.grdData.AllowUserToDeleteRows = false;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdData.Location = new System.Drawing.Point(3, 16);
            this.grdData.Name = "grdData";
            this.grdData.ReadOnly = true;
            this.grdData.Size = new System.Drawing.Size(722, 366);
            this.grdData.TabIndex = 16;
            // 
            // frmLinearSystems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 592);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnClear1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnCalc1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmLinearSystems";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "frmLinearSystems";
            this.Load += new System.EventHandler(this.frmLinearSystems_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdGaussFull;
        private System.Windows.Forms.RadioButton rdLU;
        private System.Windows.Forms.RadioButton rdCholesky;
        private System.Windows.Forms.RadioButton rdGaussCompact;
        private System.Windows.Forms.RadioButton rdGaussPartial;
        private System.Windows.Forms.RadioButton rdGauss;
        private System.Windows.Forms.Button btnClear1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkReverse;
        private System.Windows.Forms.CheckBox chkSystem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtMaxIt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Button btnCalc1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdGaussSeidel;
        private System.Windows.Forms.RadioButton rdJacobi;
        private System.Windows.Forms.CheckBox chkDeterminant;
    }
}