namespace MNC.Integrals
{
    partial class frmIntegrals
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
            this.btnClear1 = new System.Windows.Forms.Button();
            this.btnCalc1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblE = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblFx = new System.Windows.Forms.Label();
            this.txtFx = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkLeftRectangle = new System.Windows.Forms.CheckBox();
            this.chkRightRectangle = new System.Windows.Forms.CheckBox();
            this.chkTrapezium = new System.Windows.Forms.CheckBox();
            this.chkGaussianQuadrature = new System.Windows.Forms.CheckBox();
            this.chkSimpson38 = new System.Windows.Forms.CheckBox();
            this.chkSimpson13 = new System.Windows.Forms.CheckBox();
            this.grdIntegrals = new System.Windows.Forms.DataGridView();
            this.method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdIntegrals)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear1
            // 
            this.btnClear1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear1.Location = new System.Drawing.Point(225, 164);
            this.btnClear1.Name = "btnClear1";
            this.btnClear1.Size = new System.Drawing.Size(75, 23);
            this.btnClear1.TabIndex = 38;
            this.btnClear1.Text = "Limpar";
            this.btnClear1.UseVisualStyleBackColor = true;
            this.btnClear1.Click += new System.EventHandler(this.btnClear1_Click);
            // 
            // btnCalc1
            // 
            this.btnCalc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc1.Location = new System.Drawing.Point(144, 164);
            this.btnCalc1.Name = "btnCalc1";
            this.btnCalc1.Size = new System.Drawing.Size(75, 23);
            this.btnCalc1.TabIndex = 37;
            this.btnCalc1.Text = "Calcular";
            this.btnCalc1.UseVisualStyleBackColor = true;
            this.btnCalc1.Click += new System.EventHandler(this.btnCalc1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkSimpson13);
            this.groupBox4.Controls.Add(this.chkSimpson38);
            this.groupBox4.Controls.Add(this.chkGaussianQuadrature);
            this.groupBox4.Controls.Add(this.chkTrapezium);
            this.groupBox4.Controls.Add(this.chkRightRectangle);
            this.groupBox4.Controls.Add(this.chkLeftRectangle);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(5, 89);
            this.groupBox4.MaximumSize = new System.Drawing.Size(1000, 90);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(435, 69);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Métodos";
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(313, 51);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(110, 20);
            this.txtN.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "n =";
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(41, 51);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(110, 20);
            this.txtA.TabIndex = 16;
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(177, 51);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(110, 20);
            this.txtB.TabIndex = 17;
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE.Location = new System.Drawing.Point(156, 54);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(25, 13);
            this.lblE.TabIndex = 23;
            this.lblE.Text = "b = ";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(20, 54);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(22, 13);
            this.lblX.TabIndex = 20;
            this.lblX.Text = "a =";
            // 
            // lblFx
            // 
            this.lblFx.AutoSize = true;
            this.lblFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFx.Location = new System.Drawing.Point(11, 22);
            this.lblFx.Name = "lblFx";
            this.lblFx.Size = new System.Drawing.Size(30, 13);
            this.lblFx.TabIndex = 18;
            this.lblFx.Text = "f(x) =";
            // 
            // txtFx
            // 
            this.txtFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFx.Location = new System.Drawing.Point(41, 19);
            this.txtFx.Name = "txtFx";
            this.txtFx.Size = new System.Drawing.Size(382, 20);
            this.txtFx.TabIndex = 15;
            this.txtFx.Text = "sin(x)";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtN);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.txtA);
            this.groupBox5.Controls.Add(this.txtB);
            this.groupBox5.Controls.Add(this.lblE);
            this.groupBox5.Controls.Add(this.lblX);
            this.groupBox5.Controls.Add(this.lblFx);
            this.groupBox5.Controls.Add(this.txtFx);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(5, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(435, 84);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Parâmetros";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdIntegrals);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 145);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Soluções";
            // 
            // chkLeftRectangle
            // 
            this.chkLeftRectangle.AutoSize = true;
            this.chkLeftRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLeftRectangle.Location = new System.Drawing.Point(14, 19);
            this.chkLeftRectangle.Name = "chkLeftRectangle";
            this.chkLeftRectangle.Size = new System.Drawing.Size(132, 17);
            this.chkLeftRectangle.TabIndex = 0;
            this.chkLeftRectangle.Text = "Retângulo à Esquerda";
            this.chkLeftRectangle.UseVisualStyleBackColor = true;
            // 
            // chkRightRectangle
            // 
            this.chkRightRectangle.AutoSize = true;
            this.chkRightRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRightRectangle.Location = new System.Drawing.Point(14, 42);
            this.chkRightRectangle.Name = "chkRightRectangle";
            this.chkRightRectangle.Size = new System.Drawing.Size(117, 17);
            this.chkRightRectangle.TabIndex = 1;
            this.chkRightRectangle.Text = "Retângulo à Direita";
            this.chkRightRectangle.UseVisualStyleBackColor = true;
            // 
            // chkTrapezium
            // 
            this.chkTrapezium.AutoSize = true;
            this.chkTrapezium.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTrapezium.Location = new System.Drawing.Point(159, 19);
            this.chkTrapezium.Name = "chkTrapezium";
            this.chkTrapezium.Size = new System.Drawing.Size(67, 17);
            this.chkTrapezium.TabIndex = 2;
            this.chkTrapezium.Text = "Trapézio";
            this.chkTrapezium.UseVisualStyleBackColor = true;
            // 
            // chkGaussianQuadrature
            // 
            this.chkGaussianQuadrature.AutoSize = true;
            this.chkGaussianQuadrature.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGaussianQuadrature.Location = new System.Drawing.Point(159, 42);
            this.chkGaussianQuadrature.Name = "chkGaussianQuadrature";
            this.chkGaussianQuadrature.Size = new System.Drawing.Size(132, 17);
            this.chkGaussianQuadrature.TabIndex = 3;
            this.chkGaussianQuadrature.Text = "Quadratura Gaussiana";
            this.chkGaussianQuadrature.UseVisualStyleBackColor = true;
            // 
            // chkSimpson38
            // 
            this.chkSimpson38.AutoSize = true;
            this.chkSimpson38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSimpson38.Location = new System.Drawing.Point(296, 42);
            this.chkSimpson38.Name = "chkSimpson38";
            this.chkSimpson38.Size = new System.Drawing.Size(101, 17);
            this.chkSimpson38.TabIndex = 4;
            this.chkSimpson38.Text = "3/8 de Simpson";
            this.chkSimpson38.UseVisualStyleBackColor = true;
            // 
            // chkSimpson13
            // 
            this.chkSimpson13.AutoSize = true;
            this.chkSimpson13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSimpson13.Location = new System.Drawing.Point(296, 19);
            this.chkSimpson13.Name = "chkSimpson13";
            this.chkSimpson13.Size = new System.Drawing.Size(101, 17);
            this.chkSimpson13.TabIndex = 5;
            this.chkSimpson13.Text = "1/3 de Simpson";
            this.chkSimpson13.UseVisualStyleBackColor = true;
            // 
            // grdIntegrals
            // 
            this.grdIntegrals.AllowUserToAddRows = false;
            this.grdIntegrals.AllowUserToDeleteRows = false;
            this.grdIntegrals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdIntegrals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.method,
            this.fx});
            this.grdIntegrals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdIntegrals.Location = new System.Drawing.Point(3, 16);
            this.grdIntegrals.Name = "grdIntegrals";
            this.grdIntegrals.ReadOnly = true;
            this.grdIntegrals.Size = new System.Drawing.Size(429, 126);
            this.grdIntegrals.TabIndex = 17;
            // 
            // method
            // 
            this.method.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.method.FillWeight = 40F;
            this.method.HeaderText = "Método";
            this.method.Name = "method";
            this.method.ReadOnly = true;
            // 
            // fx
            // 
            this.fx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fx.FillWeight = 60F;
            this.fx.HeaderText = "∫ f(x)";
            this.fx.Name = "fx";
            this.fx.ReadOnly = true;
            // 
            // frmIntegrals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 343);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear1);
            this.Controls.Add(this.btnCalc1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Name = "frmIntegrals";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Integrais";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdIntegrals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClear1;
        private System.Windows.Forms.Button btnCalc1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblFx;
        private System.Windows.Forms.TextBox txtFx;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSimpson13;
        private System.Windows.Forms.CheckBox chkSimpson38;
        private System.Windows.Forms.CheckBox chkGaussianQuadrature;
        private System.Windows.Forms.CheckBox chkTrapezium;
        private System.Windows.Forms.CheckBox chkRightRectangle;
        private System.Windows.Forms.CheckBox chkLeftRectangle;
        private System.Windows.Forms.DataGridView grdIntegrals;
        private System.Windows.Forms.DataGridViewTextBoxColumn method;
        private System.Windows.Forms.DataGridViewTextBoxColumn fx;
    }
}