namespace MNC.Interpolations
{
    partial class frmInterpolations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPlot = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdExpression = new System.Windows.Forms.RadioButton();
            this.rdPoints = new System.Windows.Forms.RadioButton();
            this.lblFx = new System.Windows.Forms.Label();
            this.txtFx = new System.Windows.Forms.TextBox();
            this.chkLinearSystem = new System.Windows.Forms.CheckBox();
            this.chkNewton = new System.Windows.Forms.CheckBox();
            this.chkNewtonGregory = new System.Windows.Forms.CheckBox();
            this.btnClear1 = new System.Windows.Forms.Button();
            this.btnCalc1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLinearSystem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewtonGregory = new System.Windows.Forms.TextBox();
            this.txtNewton = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdX = new System.Windows.Forms.DataGridView();
            this.xi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdX)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlot
            // 
            this.btnPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlot.Location = new System.Drawing.Point(208, 6);
            this.btnPlot.Name = "btnPlot";
            this.btnPlot.Size = new System.Drawing.Size(75, 23);
            this.btnPlot.TabIndex = 46;
            this.btnPlot.Text = "Desenhar";
            this.btnPlot.UseVisualStyleBackColor = true;
            this.btnPlot.Click += new System.EventHandler(this.btnPlot_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdExpression);
            this.groupBox5.Controls.Add(this.rdPoints);
            this.groupBox5.Controls.Add(this.lblFx);
            this.groupBox5.Controls.Add(this.txtFx);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(5, 51);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(496, 84);
            this.groupBox5.TabIndex = 41;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Parâmetros";
            // 
            // rdExpression
            // 
            this.rdExpression.AutoSize = true;
            this.rdExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdExpression.Location = new System.Drawing.Point(159, 19);
            this.rdExpression.Name = "rdExpression";
            this.rdExpression.Size = new System.Drawing.Size(74, 17);
            this.rdExpression.TabIndex = 30;
            this.rdExpression.Text = "Expressao";
            this.rdExpression.UseVisualStyleBackColor = true;
            this.rdExpression.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdPoints
            // 
            this.rdPoints.AutoSize = true;
            this.rdPoints.Checked = true;
            this.rdPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPoints.Location = new System.Drawing.Point(16, 19);
            this.rdPoints.Name = "rdPoints";
            this.rdPoints.Size = new System.Drawing.Size(110, 17);
            this.rdPoints.TabIndex = 29;
            this.rdPoints.TabStop = true;
            this.rdPoints.Text = "Nuvem de Pontos";
            this.rdPoints.UseVisualStyleBackColor = true;
            // 
            // lblFx
            // 
            this.lblFx.AutoSize = true;
            this.lblFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFx.Location = new System.Drawing.Point(13, 54);
            this.lblFx.Name = "lblFx";
            this.lblFx.Size = new System.Drawing.Size(30, 13);
            this.lblFx.TabIndex = 18;
            this.lblFx.Text = "f(x) =";
            // 
            // txtFx
            // 
            this.txtFx.Enabled = false;
            this.txtFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFx.Location = new System.Drawing.Point(43, 51);
            this.txtFx.Name = "txtFx";
            this.txtFx.ReadOnly = true;
            this.txtFx.Size = new System.Drawing.Size(447, 20);
            this.txtFx.TabIndex = 15;
            this.txtFx.Text = "sin(x)*0.1";
            // 
            // chkLinearSystem
            // 
            this.chkLinearSystem.AutoSize = true;
            this.chkLinearSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLinearSystem.Location = new System.Drawing.Point(14, 19);
            this.chkLinearSystem.Name = "chkLinearSystem";
            this.chkLinearSystem.Size = new System.Drawing.Size(95, 17);
            this.chkLinearSystem.TabIndex = 0;
            this.chkLinearSystem.Text = "Sistema Linear";
            this.chkLinearSystem.UseVisualStyleBackColor = true;
            // 
            // chkNewton
            // 
            this.chkNewton.AutoSize = true;
            this.chkNewton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNewton.Location = new System.Drawing.Point(159, 19);
            this.chkNewton.Name = "chkNewton";
            this.chkNewton.Size = new System.Drawing.Size(63, 17);
            this.chkNewton.TabIndex = 2;
            this.chkNewton.Text = "Newton";
            this.chkNewton.UseVisualStyleBackColor = true;
            // 
            // chkNewtonGregory
            // 
            this.chkNewtonGregory.AutoSize = true;
            this.chkNewtonGregory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNewtonGregory.Location = new System.Drawing.Point(275, 19);
            this.chkNewtonGregory.Name = "chkNewtonGregory";
            this.chkNewtonGregory.Size = new System.Drawing.Size(103, 17);
            this.chkNewtonGregory.TabIndex = 5;
            this.chkNewtonGregory.Text = "Newton-Gregory";
            this.chkNewtonGregory.UseVisualStyleBackColor = true;
            // 
            // btnClear1
            // 
            this.btnClear1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear1.Location = new System.Drawing.Point(289, 6);
            this.btnClear1.Name = "btnClear1";
            this.btnClear1.Size = new System.Drawing.Size(75, 23);
            this.btnClear1.TabIndex = 44;
            this.btnClear1.Text = "Limpar";
            this.btnClear1.UseVisualStyleBackColor = true;
            this.btnClear1.Click += new System.EventHandler(this.btnClear1_Click);
            // 
            // btnCalc1
            // 
            this.btnCalc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc1.Location = new System.Drawing.Point(127, 6);
            this.btnCalc1.Name = "btnCalc1";
            this.btnCalc1.Size = new System.Drawing.Size(75, 23);
            this.btnCalc1.TabIndex = 43;
            this.btnCalc1.Text = "Calcular";
            this.btnCalc1.UseVisualStyleBackColor = true;
            this.btnCalc1.Click += new System.EventHandler(this.btnCalc1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkNewtonGregory);
            this.groupBox4.Controls.Add(this.chkNewton);
            this.groupBox4.Controls.Add(this.chkLinearSystem);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(5, 5);
            this.groupBox4.MaximumSize = new System.Drawing.Size(1000, 90);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(496, 46);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Métodos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPlot);
            this.panel1.Controls.Add(this.btnCalc1);
            this.panel1.Controls.Add(this.btnClear1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 34);
            this.panel1.TabIndex = 47;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLinearSystem);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNewtonGregory);
            this.groupBox1.Controls.Add(this.txtNewton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 385);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 170);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados";
            // 
            // txtLinearSystem
            // 
            this.txtLinearSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinearSystem.Location = new System.Drawing.Point(40, 32);
            this.txtLinearSystem.Name = "txtLinearSystem";
            this.txtLinearSystem.Size = new System.Drawing.Size(450, 20);
            this.txtLinearSystem.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "f(x) =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Newton";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Newton-Gregory";
            // 
            // txtNewtonGregory
            // 
            this.txtNewtonGregory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewtonGregory.Location = new System.Drawing.Point(40, 142);
            this.txtNewtonGregory.Name = "txtNewtonGregory";
            this.txtNewtonGregory.Size = new System.Drawing.Size(450, 20);
            this.txtNewtonGregory.TabIndex = 22;
            // 
            // txtNewton
            // 
            this.txtNewton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewton.Location = new System.Drawing.Point(40, 88);
            this.txtNewton.Name = "txtNewton";
            this.txtNewton.Size = new System.Drawing.Size(450, 20);
            this.txtNewton.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Sistema Linear";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "f(x) =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "f(s) =";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdX);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(496, 216);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados";
            // 
            // grdX
            // 
            this.grdX.AllowUserToResizeColumns = false;
            this.grdX.AllowUserToResizeRows = false;
            this.grdX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xi,
            this.fxi});
            this.grdX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdX.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.grdX.Location = new System.Drawing.Point(5, 18);
            this.grdX.Name = "grdX";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdX.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Format = "N6";
            dataGridViewCellStyle4.NullValue = null;
            this.grdX.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdX.Size = new System.Drawing.Size(486, 193);
            this.grdX.TabIndex = 10;
            this.grdX.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.grdX_UserAddedRow_1);
            // 
            // xi
            // 
            this.xi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xi.FillWeight = 50F;
            this.xi.HeaderText = "x[i]";
            this.xi.Name = "xi";
            // 
            // fxi
            // 
            this.fxi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fxi.FillWeight = 50F;
            this.fxi.HeaderText = "f(x[i])";
            this.fxi.Name = "fxi";
            // 
            // frmInterpolations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 560);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInterpolations";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Interpolações";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.frmInterpolations_HelpButtonClicked);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlot;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblFx;
        private System.Windows.Forms.TextBox txtFx;
        private System.Windows.Forms.CheckBox chkLinearSystem;
        private System.Windows.Forms.CheckBox chkNewton;
        private System.Windows.Forms.CheckBox chkNewtonGregory;
        private System.Windows.Forms.Button btnClear1;
        private System.Windows.Forms.Button btnCalc1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdExpression;
        private System.Windows.Forms.RadioButton rdPoints;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLinearSystem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewtonGregory;
        private System.Windows.Forms.TextBox txtNewton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdX;
        private System.Windows.Forms.DataGridViewTextBoxColumn xi;
        private System.Windows.Forms.DataGridViewTextBoxColumn fxi;
    }
}