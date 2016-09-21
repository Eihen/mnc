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
            this.rdSimpson13 = new System.Windows.Forms.RadioButton();
            this.rdGaussianQuadrature = new System.Windows.Forms.RadioButton();
            this.rdSimpson38 = new System.Windows.Forms.RadioButton();
            this.rdTrapezium = new System.Windows.Forms.RadioButton();
            this.rdRightRectangle = new System.Windows.Forms.RadioButton();
            this.rdLeftRectangle = new System.Windows.Forms.RadioButton();
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtS = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // rdSimpson13
            // 
            this.rdSimpson13.AutoSize = true;
            this.rdSimpson13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSimpson13.Location = new System.Drawing.Point(323, 19);
            this.rdSimpson13.Name = "rdSimpson13";
            this.rdSimpson13.Size = new System.Drawing.Size(100, 17);
            this.rdSimpson13.TabIndex = 5;
            this.rdSimpson13.TabStop = true;
            this.rdSimpson13.Text = "1/3 de Simpson";
            this.rdSimpson13.UseVisualStyleBackColor = true;
            // 
            // rdGaussianQuadrature
            // 
            this.rdGaussianQuadrature.AutoSize = true;
            this.rdGaussianQuadrature.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdGaussianQuadrature.Location = new System.Drawing.Point(167, 42);
            this.rdGaussianQuadrature.Name = "rdGaussianQuadrature";
            this.rdGaussianQuadrature.Size = new System.Drawing.Size(131, 17);
            this.rdGaussianQuadrature.TabIndex = 4;
            this.rdGaussianQuadrature.TabStop = true;
            this.rdGaussianQuadrature.Text = "Quadratura Gaussiana";
            this.rdGaussianQuadrature.UseVisualStyleBackColor = true;
            this.rdGaussianQuadrature.CheckedChanged += new System.EventHandler(this.rdModifiedFalsePosition_CheckedChanged);
            // 
            // rdSimpson38
            // 
            this.rdSimpson38.AutoSize = true;
            this.rdSimpson38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSimpson38.Location = new System.Drawing.Point(323, 42);
            this.rdSimpson38.Name = "rdSimpson38";
            this.rdSimpson38.Size = new System.Drawing.Size(100, 17);
            this.rdSimpson38.TabIndex = 3;
            this.rdSimpson38.TabStop = true;
            this.rdSimpson38.Text = "3/8 de Simpson";
            this.rdSimpson38.UseVisualStyleBackColor = true;
            // 
            // rdTrapezium
            // 
            this.rdTrapezium.AutoSize = true;
            this.rdTrapezium.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTrapezium.Location = new System.Drawing.Point(167, 19);
            this.rdTrapezium.Name = "rdTrapezium";
            this.rdTrapezium.Size = new System.Drawing.Size(66, 17);
            this.rdTrapezium.TabIndex = 2;
            this.rdTrapezium.TabStop = true;
            this.rdTrapezium.Text = "Trapézio";
            this.rdTrapezium.UseVisualStyleBackColor = true;
            this.rdTrapezium.CheckedChanged += new System.EventHandler(this.rdBissection_CheckedChanged);
            // 
            // rdRightRectangle
            // 
            this.rdRightRectangle.AutoSize = true;
            this.rdRightRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdRightRectangle.Location = new System.Drawing.Point(14, 42);
            this.rdRightRectangle.Name = "rdRightRectangle";
            this.rdRightRectangle.Size = new System.Drawing.Size(116, 17);
            this.rdRightRectangle.TabIndex = 1;
            this.rdRightRectangle.TabStop = true;
            this.rdRightRectangle.Text = "Retângulo a Direita";
            this.rdRightRectangle.UseVisualStyleBackColor = true;
            // 
            // rdLeftRectangle
            // 
            this.rdLeftRectangle.AutoSize = true;
            this.rdLeftRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdLeftRectangle.Location = new System.Drawing.Point(14, 19);
            this.rdLeftRectangle.Name = "rdLeftRectangle";
            this.rdLeftRectangle.Size = new System.Drawing.Size(131, 17);
            this.rdLeftRectangle.TabIndex = 0;
            this.rdLeftRectangle.TabStop = true;
            this.rdLeftRectangle.Text = "Retângulo a Esquerda";
            this.rdLeftRectangle.UseVisualStyleBackColor = true;
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
            this.groupBox4.Controls.Add(this.rdSimpson13);
            this.groupBox4.Controls.Add(this.rdGaussianQuadrature);
            this.groupBox4.Controls.Add(this.rdSimpson38);
            this.groupBox4.Controls.Add(this.rdTrapezium);
            this.groupBox4.Controls.Add(this.rdRightRectangle);
            this.groupBox4.Controls.Add(this.rdLeftRectangle);
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
            this.groupBox1.Controls.Add(this.txtS);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 193);
            this.groupBox1.MaximumSize = new System.Drawing.Size(1000, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 50);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solução";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "∫ f(x) =";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtS
            // 
            this.txtS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtS.Location = new System.Drawing.Point(38, 20);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(385, 20);
            this.txtS.TabIndex = 19;
            this.txtS.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmIntegrals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 248);
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
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClear1;
        private System.Windows.Forms.RadioButton rdSimpson13;
        private System.Windows.Forms.RadioButton rdGaussianQuadrature;
        private System.Windows.Forms.RadioButton rdSimpson38;
        private System.Windows.Forms.RadioButton rdTrapezium;
        private System.Windows.Forms.RadioButton rdRightRectangle;
        private System.Windows.Forms.RadioButton rdLeftRectangle;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtS;
    }
}