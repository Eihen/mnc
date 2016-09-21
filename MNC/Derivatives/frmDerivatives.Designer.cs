namespace MNC.Derivatives
{
    partial class frmDerivatives
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabJacobiana = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.grdJ = new System.Windows.Forms.DataGridView();
            this.grdF = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdX2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaxIt3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtE3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabDerivadas = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grdHessian = new System.Windows.Forms.DataGridView();
            this.grdGradient = new System.Windows.Forms.DataGridView();
            this.gi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdX = new System.Windows.Forms.DataGridView();
            this.xi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaxIt2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtE2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFx2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear1 = new System.Windows.Forms.Button();
            this.btnCalc1 = new System.Windows.Forms.Button();
            this.txtF2x = new System.Windows.Forms.TextBox();
            this.txtF1x = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxIt = new System.Windows.Forms.TextBox();
            this.lblMaxIt = new System.Windows.Forms.Label();
            this.txtE = new System.Windows.Forms.TextBox();
            this.lblE = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblFx = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtFx = new System.Windows.Forms.TextBox();
            this.tabJacobiana.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdX2)).BeginInit();
            this.tabs.SuspendLayout();
            this.tabDerivadas.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHessian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGradient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdX)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabJacobiana
            // 
            this.tabJacobiana.Controls.Add(this.groupBox3);
            this.tabJacobiana.Location = new System.Drawing.Point(4, 22);
            this.tabJacobiana.Name = "tabJacobiana";
            this.tabJacobiana.Padding = new System.Windows.Forms.Padding(3);
            this.tabJacobiana.Size = new System.Drawing.Size(743, 539);
            this.tabJacobiana.TabIndex = 1;
            this.tabJacobiana.Text = "Matriz Jacobiana";
            this.tabJacobiana.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.grdJ);
            this.groupBox3.Controls.Add(this.grdF);
            this.groupBox3.Controls.Add(this.grdX2);
            this.groupBox3.Controls.Add(this.txtMaxIt3);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtE3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(737, 528);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Função Real com n variáveis Reais ( f : Rn --> R )";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(369, 261);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(280, 261);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Calcular";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // grdJ
            // 
            this.grdJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdJ.Location = new System.Drawing.Point(8, 290);
            this.grdJ.Name = "grdJ";
            this.grdJ.ReadOnly = true;
            this.grdJ.Size = new System.Drawing.Size(721, 246);
            this.grdJ.TabIndex = 11;
            // 
            // grdF
            // 
            this.grdF.AllowUserToResizeColumns = false;
            this.grdF.AllowUserToResizeRows = false;
            this.grdF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.grdF.Location = new System.Drawing.Point(181, 53);
            this.grdF.Name = "grdF";
            this.grdF.Size = new System.Drawing.Size(548, 202);
            this.grdF.TabIndex = 10;
            this.grdF.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.grdF_UserAddedRow);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "f[i]";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // grdX2
            // 
            this.grdX2.AllowUserToResizeColumns = false;
            this.grdX2.AllowUserToResizeRows = false;
            this.grdX2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdX2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.grdX2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.grdX2.Location = new System.Drawing.Point(8, 53);
            this.grdX2.Name = "grdX2";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdX2.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Format = "N6";
            dataGridViewCellStyle2.NullValue = null;
            this.grdX2.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grdX2.Size = new System.Drawing.Size(154, 202);
            this.grdX2.TabIndex = 9;
            this.grdX2.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.grdX2_UserAddedRow);
            this.grdX2.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.grdX2_UserDeletedRow);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "x[i]";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // txtMaxIt3
            // 
            this.txtMaxIt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxIt3.Location = new System.Drawing.Point(409, 22);
            this.txtMaxIt3.Name = "txtMaxIt3";
            this.txtMaxIt3.Size = new System.Drawing.Size(320, 20);
            this.txtMaxIt3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(366, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "MaxIt = ";
            // 
            // txtE3
            // 
            this.txtE3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtE3.Location = new System.Drawing.Point(35, 22);
            this.txtE3.Name = "txtE3";
            this.txtE3.Size = new System.Drawing.Size(320, 20);
            this.txtE3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "ε = ";
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabDerivadas);
            this.tabs.Controls.Add(this.tabJacobiana);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(751, 565);
            this.tabs.TabIndex = 0;
            // 
            // tabDerivadas
            // 
            this.tabDerivadas.AutoScroll = true;
            this.tabDerivadas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabDerivadas.Controls.Add(this.groupBox2);
            this.tabDerivadas.Controls.Add(this.groupBox1);
            this.tabDerivadas.Location = new System.Drawing.Point(4, 22);
            this.tabDerivadas.Name = "tabDerivadas";
            this.tabDerivadas.Padding = new System.Windows.Forms.Padding(3);
            this.tabDerivadas.Size = new System.Drawing.Size(743, 539);
            this.tabDerivadas.TabIndex = 0;
            this.tabDerivadas.Text = "Derivadas, Gradiente e Hessiana";
            this.tabDerivadas.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.grdHessian);
            this.groupBox2.Controls.Add(this.grdGradient);
            this.groupBox2.Controls.Add(this.grdX);
            this.groupBox2.Controls.Add(this.txtMaxIt2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtE2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtFx2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(737, 327);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Função Real com n variáveis Reais ( f : Rn --> R )";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(369, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(280, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // grdHessian
            // 
            this.grdHessian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHessian.Location = new System.Drawing.Point(361, 119);
            this.grdHessian.Name = "grdHessian";
            this.grdHessian.ReadOnly = true;
            this.grdHessian.Size = new System.Drawing.Size(368, 202);
            this.grdHessian.TabIndex = 11;
            // 
            // grdGradient
            // 
            this.grdGradient.AllowUserToAddRows = false;
            this.grdGradient.AllowUserToDeleteRows = false;
            this.grdGradient.AllowUserToResizeColumns = false;
            this.grdGradient.AllowUserToResizeRows = false;
            this.grdGradient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGradient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gi});
            this.grdGradient.Location = new System.Drawing.Point(181, 119);
            this.grdGradient.Name = "grdGradient";
            this.grdGradient.ReadOnly = true;
            this.grdGradient.Size = new System.Drawing.Size(154, 202);
            this.grdGradient.TabIndex = 10;
            // 
            // gi
            // 
            this.gi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gi.HeaderText = "G[i]";
            this.gi.Name = "gi";
            this.gi.ReadOnly = true;
            // 
            // grdX
            // 
            this.grdX.AllowUserToResizeColumns = false;
            this.grdX.AllowUserToResizeRows = false;
            this.grdX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xi});
            this.grdX.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.grdX.Location = new System.Drawing.Point(8, 119);
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
            this.grdX.Size = new System.Drawing.Size(154, 202);
            this.grdX.TabIndex = 9;
            this.grdX.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.grdX_UserAddedRow);
            // 
            // xi
            // 
            this.xi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xi.HeaderText = "x[i]";
            this.xi.Name = "xi";
            // 
            // txtMaxIt2
            // 
            this.txtMaxIt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxIt2.Location = new System.Drawing.Point(409, 53);
            this.txtMaxIt2.Name = "txtMaxIt2";
            this.txtMaxIt2.Size = new System.Drawing.Size(320, 20);
            this.txtMaxIt2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(366, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "MaxIt = ";
            // 
            // txtE2
            // 
            this.txtE2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtE2.Location = new System.Drawing.Point(35, 53);
            this.txtE2.Name = "txtE2";
            this.txtE2.Size = new System.Drawing.Size(320, 20);
            this.txtE2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "ε = ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "f(x) =";
            // 
            // txtFx2
            // 
            this.txtFx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFx2.Location = new System.Drawing.Point(35, 21);
            this.txtFx2.Name = "txtFx2";
            this.txtFx2.Size = new System.Drawing.Size(694, 20);
            this.txtFx2.TabIndex = 0;
            this.txtFx2.Text = "x1+x2+x3+x4+x5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear1);
            this.groupBox1.Controls.Add(this.btnCalc1);
            this.groupBox1.Controls.Add(this.txtF2x);
            this.groupBox1.Controls.Add(this.txtF1x);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaxIt);
            this.groupBox1.Controls.Add(this.lblMaxIt);
            this.groupBox1.Controls.Add(this.txtE);
            this.groupBox1.Controls.Add(this.lblE);
            this.groupBox1.Controls.Add(this.lblX);
            this.groupBox1.Controls.Add(this.lblFx);
            this.groupBox1.Controls.Add(this.txtX);
            this.groupBox1.Controls.Add(this.txtFx);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 186);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Função Real com uma variável Real ( f : R --> R )";
            // 
            // btnClear1
            // 
            this.btnClear1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear1.Location = new System.Drawing.Point(369, 83);
            this.btnClear1.Name = "btnClear1";
            this.btnClear1.Size = new System.Drawing.Size(75, 23);
            this.btnClear1.TabIndex = 5;
            this.btnClear1.Text = "Limpar";
            this.btnClear1.UseVisualStyleBackColor = true;
            this.btnClear1.Click += new System.EventHandler(this.btnClear1_Click);
            // 
            // btnCalc1
            // 
            this.btnCalc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc1.Location = new System.Drawing.Point(280, 83);
            this.btnCalc1.Name = "btnCalc1";
            this.btnCalc1.Size = new System.Drawing.Size(75, 23);
            this.btnCalc1.TabIndex = 4;
            this.btnCalc1.Text = "Calcular";
            this.btnCalc1.UseVisualStyleBackColor = true;
            this.btnCalc1.Click += new System.EventHandler(this.btnCalc1_Click);
            // 
            // txtF2x
            // 
            this.txtF2x.Enabled = false;
            this.txtF2x.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtF2x.Location = new System.Drawing.Point(35, 147);
            this.txtF2x.Name = "txtF2x";
            this.txtF2x.Size = new System.Drawing.Size(694, 20);
            this.txtF2x.TabIndex = 11;
            // 
            // txtF1x
            // 
            this.txtF1x.Enabled = false;
            this.txtF1x.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtF1x.Location = new System.Drawing.Point(35, 116);
            this.txtF1x.Name = "txtF1x";
            this.txtF1x.Size = new System.Drawing.Size(694, 20);
            this.txtF1x.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "f\'\'(x) =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "f\'(x) =";
            // 
            // txtMaxIt
            // 
            this.txtMaxIt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxIt.Location = new System.Drawing.Point(524, 53);
            this.txtMaxIt.Name = "txtMaxIt";
            this.txtMaxIt.Size = new System.Drawing.Size(205, 20);
            this.txtMaxIt.TabIndex = 3;
            // 
            // lblMaxIt
            // 
            this.lblMaxIt.AutoSize = true;
            this.lblMaxIt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxIt.Location = new System.Drawing.Point(481, 56);
            this.lblMaxIt.Name = "lblMaxIt";
            this.lblMaxIt.Size = new System.Drawing.Size(45, 13);
            this.lblMaxIt.TabIndex = 8;
            this.lblMaxIt.Text = "MaxIt = ";
            // 
            // txtE
            // 
            this.txtE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtE.Location = new System.Drawing.Point(269, 53);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(205, 20);
            this.txtE.TabIndex = 2;
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE.Location = new System.Drawing.Point(248, 56);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(25, 13);
            this.lblE.TabIndex = 5;
            this.lblE.Text = "ε = ";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(14, 56);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(21, 13);
            this.lblX.TabIndex = 3;
            this.lblX.Text = "x =";
            // 
            // lblFx
            // 
            this.lblFx.AutoSize = true;
            this.lblFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFx.Location = new System.Drawing.Point(5, 24);
            this.lblFx.Name = "lblFx";
            this.lblFx.Size = new System.Drawing.Size(30, 13);
            this.lblFx.TabIndex = 2;
            this.lblFx.Text = "f(x) =";
            // 
            // txtX
            // 
            this.txtX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX.Location = new System.Drawing.Point(35, 53);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(205, 20);
            this.txtX.TabIndex = 1;
            // 
            // txtFx
            // 
            this.txtFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFx.Location = new System.Drawing.Point(35, 21);
            this.txtFx.Name = "txtFx";
            this.txtFx.Size = new System.Drawing.Size(694, 20);
            this.txtFx.TabIndex = 0;
            this.txtFx.Text = "x^2+3";
            // 
            // frmDerivatives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 565);
            this.Controls.Add(this.tabs);
            this.Name = "frmDerivatives";
            this.Text = "Derivadas";
            this.Load += new System.EventHandler(this.frmDerivatives_Load);
            this.tabJacobiana.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdX2)).EndInit();
            this.tabs.ResumeLayout(false);
            this.tabDerivadas.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHessian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGradient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdX)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabJacobiana;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabDerivadas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdHessian;
        private System.Windows.Forms.DataGridView grdGradient;
        private System.Windows.Forms.DataGridView grdX;
        private System.Windows.Forms.TextBox txtMaxIt2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtE2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFx2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtF2x;
        private System.Windows.Forms.TextBox txtF1x;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaxIt;
        private System.Windows.Forms.Label lblMaxIt;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblFx;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtFx;
        private System.Windows.Forms.DataGridViewTextBoxColumn gi;
        private System.Windows.Forms.DataGridViewTextBoxColumn xi;
        private System.Windows.Forms.Button btnClear1;
        private System.Windows.Forms.Button btnCalc1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView grdJ;
        private System.Windows.Forms.DataGridView grdF;
        private System.Windows.Forms.DataGridView grdX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox txtMaxIt3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtE3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}