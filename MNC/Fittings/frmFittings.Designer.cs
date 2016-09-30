namespace MNC.Fittings
{
    partial class frmFittings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fxi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdX = new System.Windows.Forms.DataGridView();
            this.xi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPolynomialF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.txtAbxF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chk1abx = new System.Windows.Forms.CheckBox();
            this.chkAxb = new System.Windows.Forms.CheckBox();
            this.chkAebx = new System.Windows.Forms.CheckBox();
            this.chkAbx = new System.Windows.Forms.CheckBox();
            this.chkPolynomial = new System.Windows.Forms.CheckBox();
            this.btnCalc1 = new System.Windows.Forms.Button();
            this.btnClear1 = new System.Windows.Forms.Button();
            this.rdExpression = new System.Windows.Forms.RadioButton();
            this.rdPoints = new System.Windows.Forms.RadioButton();
            this.lblFx = new System.Windows.Forms.Label();
            this.txtFx = new System.Windows.Forms.TextBox();
            this.btnPlot = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtPolynomialR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAbxR = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAebxR = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAebxF = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt1abxR = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt1abxF = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAxbR = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.txtAxbF = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtO = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdX)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // fxi
            // 
            this.fxi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fxi.FillWeight = 50F;
            this.fxi.HeaderText = "f(x[i])";
            this.fxi.Name = "fxi";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdX.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Format = "N6";
            dataGridViewCellStyle2.NullValue = null;
            this.grdX.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grdX.Size = new System.Drawing.Size(489, 194);
            this.grdX.TabIndex = 10;
            this.grdX.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.grdX_UserAddedRow);
            // 
            // xi
            // 
            this.xi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xi.FillWeight = 50F;
            this.xi.HeaderText = "x[i]";
            this.xi.Name = "xi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdX);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(499, 217);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados";
            // 
            // txtPolynomialF
            // 
            this.txtPolynomialF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPolynomialF.Location = new System.Drawing.Point(40, 32);
            this.txtPolynomialF.Name = "txtPolynomialF";
            this.txtPolynomialF.Size = new System.Drawing.Size(450, 20);
            this.txtPolynomialF.TabIndex = 19;
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
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.Location = new System.Drawing.Point(6, 86);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(40, 13);
            this.a.TabIndex = 24;
            this.a.Text = "a*(b^x)";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b.Location = new System.Drawing.Point(6, 159);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(50, 13);
            this.b.TabIndex = 23;
            this.b.Text = "a*e^(b*x)";
            // 
            // txtAbxF
            // 
            this.txtAbxF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbxF.Location = new System.Drawing.Point(40, 102);
            this.txtAbxF.Name = "txtAbxF";
            this.txtAbxF.Size = new System.Drawing.Size(450, 20);
            this.txtAbxF.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Polinômio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "f(x) =";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt1abxR);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt1abxF);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtAxbR);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.c);
            this.groupBox1.Controls.Add(this.d);
            this.groupBox1.Controls.Add(this.txtAxbF);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtAebxR);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtAebxF);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtAbxR);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtPolynomialR);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPolynomialF);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.a);
            this.groupBox1.Controls.Add(this.b);
            this.groupBox1.Controls.Add(this.txtAbxF);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 431);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 379);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtO);
            this.groupBox4.Controls.Add(this.chk1abx);
            this.groupBox4.Controls.Add(this.chkAxb);
            this.groupBox4.Controls.Add(this.chkAebx);
            this.groupBox4.Controls.Add(this.chkAbx);
            this.groupBox4.Controls.Add(this.chkPolynomial);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(10, 128);
            this.groupBox4.MaximumSize = new System.Drawing.Size(1000, 90);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(499, 86);
            this.groupBox4.TabIndex = 55;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Métodos";
            // 
            // chk1abx
            // 
            this.chk1abx.AutoSize = true;
            this.chk1abx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk1abx.Location = new System.Drawing.Point(9, 51);
            this.chk1abx.Name = "chk1abx";
            this.chk1abx.Size = new System.Drawing.Size(70, 17);
            this.chk1abx.TabIndex = 7;
            this.chk1abx.Text = "1/(a+b*x)";
            this.chk1abx.UseVisualStyleBackColor = true;
            // 
            // chkAxb
            // 
            this.chkAxb.AutoSize = true;
            this.chkAxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAxb.Location = new System.Drawing.Point(305, 19);
            this.chkAxb.Name = "chkAxb";
            this.chkAxb.Size = new System.Drawing.Size(59, 17);
            this.chkAxb.TabIndex = 6;
            this.chkAxb.Text = "a*(x^b)";
            this.chkAxb.UseVisualStyleBackColor = true;
            // 
            // chkAebx
            // 
            this.chkAebx.AutoSize = true;
            this.chkAebx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAebx.Location = new System.Drawing.Point(159, 19);
            this.chkAebx.Name = "chkAebx";
            this.chkAebx.Size = new System.Drawing.Size(69, 17);
            this.chkAebx.TabIndex = 5;
            this.chkAebx.Text = "a*e^(b*x)";
            this.chkAebx.UseVisualStyleBackColor = true;
            // 
            // chkAbx
            // 
            this.chkAbx.AutoSize = true;
            this.chkAbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAbx.Location = new System.Drawing.Point(9, 19);
            this.chkAbx.Name = "chkAbx";
            this.chkAbx.Size = new System.Drawing.Size(59, 17);
            this.chkAbx.TabIndex = 2;
            this.chkAbx.Text = "a*(b^x)";
            this.chkAbx.UseVisualStyleBackColor = true;
            // 
            // chkPolynomial
            // 
            this.chkPolynomial.AutoSize = true;
            this.chkPolynomial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPolynomial.Location = new System.Drawing.Point(159, 51);
            this.chkPolynomial.Name = "chkPolynomial";
            this.chkPolynomial.Size = new System.Drawing.Size(109, 17);
            this.chkPolynomial.TabIndex = 0;
            this.chkPolynomial.Text = "Polinômio ordem: ";
            this.chkPolynomial.UseVisualStyleBackColor = true;
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
            this.rdExpression.CheckedChanged += new System.EventHandler(this.rdExpression_CheckedChanged);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPlot);
            this.panel1.Controls.Add(this.btnCalc1);
            this.panel1.Controls.Add(this.btnClear1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 34);
            this.panel1.TabIndex = 56;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdExpression);
            this.groupBox5.Controls.Add(this.rdPoints);
            this.groupBox5.Controls.Add(this.lblFx);
            this.groupBox5.Controls.Add(this.txtFx);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(10, 10);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(499, 84);
            this.groupBox5.TabIndex = 54;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Parâmetros";
            // 
            // txtPolynomialR
            // 
            this.txtPolynomialR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPolynomialR.Location = new System.Drawing.Point(40, 58);
            this.txtPolynomialR.Name = "txtPolynomialR";
            this.txtPolynomialR.Size = new System.Drawing.Size(450, 20);
            this.txtPolynomialR.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "R² =";
            // 
            // txtAbxR
            // 
            this.txtAbxR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbxR.Location = new System.Drawing.Point(40, 128);
            this.txtAbxR.Name = "txtAbxR";
            this.txtAbxR.Size = new System.Drawing.Size(450, 20);
            this.txtAbxR.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "R² = ";
            // 
            // txtAebxR
            // 
            this.txtAebxR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAebxR.Location = new System.Drawing.Point(40, 203);
            this.txtAebxR.Name = "txtAebxR";
            this.txtAebxR.Size = new System.Drawing.Size(450, 20);
            this.txtAebxR.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "R² = ";
            // 
            // txtAebxF
            // 
            this.txtAebxF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAebxF.Location = new System.Drawing.Point(40, 177);
            this.txtAebxF.Name = "txtAebxF";
            this.txtAebxF.Size = new System.Drawing.Size(450, 20);
            this.txtAebxF.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "f(x) =";
            // 
            // txt1abxR
            // 
            this.txt1abxR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1abxR.Location = new System.Drawing.Point(40, 353);
            this.txt1abxR.Name = "txt1abxR";
            this.txt1abxR.Size = new System.Drawing.Size(450, 20);
            this.txt1abxR.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "R² = ";
            // 
            // txt1abxF
            // 
            this.txt1abxF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1abxF.Location = new System.Drawing.Point(40, 327);
            this.txt1abxF.Name = "txt1abxF";
            this.txt1abxF.Size = new System.Drawing.Size(450, 20);
            this.txt1abxF.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 330);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "f(x) =";
            // 
            // txtAxbR
            // 
            this.txtAxbR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAxbR.Location = new System.Drawing.Point(40, 278);
            this.txtAxbR.Name = "txtAxbR";
            this.txtAxbR.Size = new System.Drawing.Size(450, 20);
            this.txtAxbR.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 281);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "R² = ";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.Location = new System.Drawing.Point(6, 236);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(40, 13);
            this.c.TabIndex = 38;
            this.c.Text = "a*(x^b)";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d.Location = new System.Drawing.Point(6, 309);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(51, 13);
            this.d.TabIndex = 37;
            this.d.Text = "1/(a+b*x)";
            // 
            // txtAxbF
            // 
            this.txtAxbF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAxbF.Location = new System.Drawing.Point(40, 252);
            this.txtAxbF.Name = "txtAxbF";
            this.txtAxbF.Size = new System.Drawing.Size(450, 20);
            this.txtAxbF.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 255);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "f(x) =";
            // 
            // txtO
            // 
            this.txtO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtO.Location = new System.Drawing.Point(262, 49);
            this.txtO.Name = "txtO";
            this.txtO.Size = new System.Drawing.Size(30, 20);
            this.txtO.TabIndex = 26;
            // 
            // frmFittings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 820);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFittings";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Ajuste de Curvas";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.frmFittings_HelpButtonClicked);
            this.Load += new System.EventHandler(this.frmFittings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn fxi;
        private System.Windows.Forms.DataGridView grdX;
        private System.Windows.Forms.DataGridViewTextBoxColumn xi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPolynomialF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.TextBox txtAbxF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chk1abx;
        private System.Windows.Forms.CheckBox chkAxb;
        private System.Windows.Forms.CheckBox chkAebx;
        private System.Windows.Forms.CheckBox chkAbx;
        private System.Windows.Forms.CheckBox chkPolynomial;
        private System.Windows.Forms.Button btnCalc1;
        private System.Windows.Forms.Button btnClear1;
        private System.Windows.Forms.RadioButton rdExpression;
        private System.Windows.Forms.RadioButton rdPoints;
        private System.Windows.Forms.Label lblFx;
        private System.Windows.Forms.TextBox txtFx;
        private System.Windows.Forms.Button btnPlot;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txt1abxR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt1abxF;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAxbR;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.TextBox txtAxbF;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAebxR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAebxF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAbxR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPolynomialR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtO;
    }
}