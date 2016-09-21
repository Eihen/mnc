namespace MNC.Roots
{
    partial class frmRoots
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtMaxIt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBigDelta = new System.Windows.Forms.TextBox();
            this.txtDelta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblMaxIt = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblE = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblFx = new System.Windows.Forms.Label();
            this.txtFx = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grdRanges = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdRoots = new System.Windows.Forms.DataGridView();
            this.xi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdNewton = new System.Windows.Forms.RadioButton();
            this.rdModifiedFalsePosition = new System.Windows.Forms.RadioButton();
            this.rdModifiedNewton = new System.Windows.Forms.RadioButton();
            this.rdBissection = new System.Windows.Forms.RadioButton();
            this.rdFalsePosition = new System.Windows.Forms.RadioButton();
            this.rdUniformSearch = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkRangesOnly = new System.Windows.Forms.CheckBox();
            this.chkPlot = new System.Windows.Forms.CheckBox();
            this.chkRanges = new System.Windows.Forms.CheckBox();
            this.btnClear1 = new System.Windows.Forms.Button();
            this.btnCalc1 = new System.Windows.Forms.Button();
            this.btnPlot = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRanges)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRoots)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtMaxIt);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.txtBigDelta);
            this.groupBox5.Controls.Add(this.txtDelta);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.txtA);
            this.groupBox5.Controls.Add(this.lblMaxIt);
            this.groupBox5.Controls.Add(this.txtB);
            this.groupBox5.Controls.Add(this.lblE);
            this.groupBox5.Controls.Add(this.lblX);
            this.groupBox5.Controls.Add(this.lblFx);
            this.groupBox5.Controls.Add(this.txtFx);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(5, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(728, 84);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Busca por raízes no intervalo";
            // 
            // txtMaxIt
            // 
            this.txtMaxIt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxIt.Location = new System.Drawing.Point(622, 51);
            this.txtMaxIt.Name = "txtMaxIt";
            this.txtMaxIt.Size = new System.Drawing.Size(100, 20);
            this.txtMaxIt.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(580, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "MaxIt =";
            // 
            // txtBigDelta
            // 
            this.txtBigDelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBigDelta.Location = new System.Drawing.Point(288, 51);
            this.txtBigDelta.Name = "txtBigDelta";
            this.txtBigDelta.Size = new System.Drawing.Size(130, 20);
            this.txtBigDelta.TabIndex = 19;
            // 
            // txtDelta
            // 
            this.txtDelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelta.Location = new System.Drawing.Point(445, 51);
            this.txtDelta.Name = "txtDelta";
            this.txtDelta.Size = new System.Drawing.Size(130, 20);
            this.txtDelta.TabIndex = 25;
            this.txtDelta.TextChanged += new System.EventHandler(this.txtDelta_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(424, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "δ = ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(34, 51);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 16;
            // 
            // lblMaxIt
            // 
            this.lblMaxIt.AutoSize = true;
            this.lblMaxIt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxIt.Location = new System.Drawing.Point(265, 54);
            this.lblMaxIt.Name = "lblMaxIt";
            this.lblMaxIt.Size = new System.Drawing.Size(26, 13);
            this.lblMaxIt.TabIndex = 24;
            this.lblMaxIt.Text = "Δ = ";
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(160, 51);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 17;
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE.Location = new System.Drawing.Point(139, 54);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(25, 13);
            this.lblE.TabIndex = 23;
            this.lblE.Text = "b = ";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(13, 54);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(22, 13);
            this.lblX.TabIndex = 20;
            this.lblX.Text = "a =";
            // 
            // lblFx
            // 
            this.lblFx.AutoSize = true;
            this.lblFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFx.Location = new System.Drawing.Point(4, 22);
            this.lblFx.Name = "lblFx";
            this.lblFx.Size = new System.Drawing.Size(30, 13);
            this.lblFx.TabIndex = 18;
            this.lblFx.Text = "f(x) =";
            // 
            // txtFx
            // 
            this.txtFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFx.Location = new System.Drawing.Point(34, 19);
            this.txtFx.Name = "txtFx";
            this.txtFx.Size = new System.Drawing.Size(688, 20);
            this.txtFx.TabIndex = 15;
            this.txtFx.Text = "sin(x)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grdRanges);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(5, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(728, 119);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Intervalos que podem conter raízes";
            // 
            // grdRanges
            // 
            this.grdRanges.AllowUserToAddRows = false;
            this.grdRanges.AllowUserToDeleteRows = false;
            this.grdRanges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRanges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdRanges.Location = new System.Drawing.Point(3, 16);
            this.grdRanges.Name = "grdRanges";
            this.grdRanges.ReadOnly = true;
            this.grdRanges.Size = new System.Drawing.Size(722, 100);
            this.grdRanges.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdRoots);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(728, 264);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Raízes encontradas";
            // 
            // grdRoots
            // 
            this.grdRoots.AllowUserToAddRows = false;
            this.grdRoots.AllowUserToDeleteRows = false;
            this.grdRoots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRoots.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xi,
            this.fxi});
            this.grdRoots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdRoots.Location = new System.Drawing.Point(3, 16);
            this.grdRoots.Name = "grdRoots";
            this.grdRoots.ReadOnly = true;
            this.grdRoots.Size = new System.Drawing.Size(722, 245);
            this.grdRoots.TabIndex = 16;
            // 
            // xi
            // 
            this.xi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xi.FillWeight = 40F;
            this.xi.HeaderText = "x[i]";
            this.xi.Name = "xi";
            this.xi.ReadOnly = true;
            // 
            // fxi
            // 
            this.fxi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fxi.FillWeight = 60F;
            this.fxi.HeaderText = "f(x[i])";
            this.fxi.Name = "fxi";
            this.fxi.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdNewton);
            this.groupBox4.Controls.Add(this.rdModifiedFalsePosition);
            this.groupBox4.Controls.Add(this.rdModifiedNewton);
            this.groupBox4.Controls.Add(this.rdBissection);
            this.groupBox4.Controls.Add(this.rdFalsePosition);
            this.groupBox4.Controls.Add(this.rdUniformSearch);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(5, 84);
            this.groupBox4.MaximumSize = new System.Drawing.Size(1000, 90);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(371, 90);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Métodos";
            // 
            // rdNewton
            // 
            this.rdNewton.AutoSize = true;
            this.rdNewton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNewton.Location = new System.Drawing.Point(7, 65);
            this.rdNewton.Name = "rdNewton";
            this.rdNewton.Size = new System.Drawing.Size(116, 17);
            this.rdNewton.TabIndex = 5;
            this.rdNewton.TabStop = true;
            this.rdNewton.Text = "Método de Newton";
            this.rdNewton.UseVisualStyleBackColor = true;
            // 
            // rdModifiedFalsePosition
            // 
            this.rdModifiedFalsePosition.AutoSize = true;
            this.rdModifiedFalsePosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdModifiedFalsePosition.Location = new System.Drawing.Point(164, 42);
            this.rdModifiedFalsePosition.Name = "rdModifiedFalsePosition";
            this.rdModifiedFalsePosition.Size = new System.Drawing.Size(197, 17);
            this.rdModifiedFalsePosition.TabIndex = 4;
            this.rdModifiedFalsePosition.TabStop = true;
            this.rdModifiedFalsePosition.Text = "Método daFalse Posição Modificado";
            this.rdModifiedFalsePosition.UseVisualStyleBackColor = true;
            // 
            // rdModifiedNewton
            // 
            this.rdModifiedNewton.AutoSize = true;
            this.rdModifiedNewton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdModifiedNewton.Location = new System.Drawing.Point(164, 65);
            this.rdModifiedNewton.Name = "rdModifiedNewton";
            this.rdModifiedNewton.Size = new System.Drawing.Size(171, 17);
            this.rdModifiedNewton.TabIndex = 3;
            this.rdModifiedNewton.TabStop = true;
            this.rdModifiedNewton.Text = "Método de Newton Modificado";
            this.rdModifiedNewton.UseVisualStyleBackColor = true;
            this.rdModifiedNewton.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rdBissection
            // 
            this.rdBissection.AutoSize = true;
            this.rdBissection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBissection.Location = new System.Drawing.Point(164, 19);
            this.rdBissection.Name = "rdBissection";
            this.rdBissection.Size = new System.Drawing.Size(122, 17);
            this.rdBissection.TabIndex = 2;
            this.rdBissection.TabStop = true;
            this.rdBissection.Text = "Método da Bisseção";
            this.rdBissection.UseVisualStyleBackColor = true;
            // 
            // rdFalsePosition
            // 
            this.rdFalsePosition.AutoSize = true;
            this.rdFalsePosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFalsePosition.Location = new System.Drawing.Point(7, 42);
            this.rdFalsePosition.Name = "rdFalsePosition";
            this.rdFalsePosition.Size = new System.Drawing.Size(145, 17);
            this.rdFalsePosition.TabIndex = 1;
            this.rdFalsePosition.TabStop = true;
            this.rdFalsePosition.Text = "Método da Falsa Posição";
            this.rdFalsePosition.UseVisualStyleBackColor = true;
            // 
            // rdUniformSearch
            // 
            this.rdUniformSearch.AutoSize = true;
            this.rdUniformSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdUniformSearch.Location = new System.Drawing.Point(7, 19);
            this.rdUniformSearch.Name = "rdUniformSearch";
            this.rdUniformSearch.Size = new System.Drawing.Size(100, 17);
            this.rdUniformSearch.TabIndex = 0;
            this.rdUniformSearch.TabStop = true;
            this.rdUniformSearch.Text = "Busca Uniforme";
            this.rdUniformSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkRangesOnly);
            this.groupBox1.Controls.Add(this.chkPlot);
            this.groupBox1.Controls.Add(this.chkRanges);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(382, 84);
            this.groupBox1.MaximumSize = new System.Drawing.Size(1000, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 90);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções adicionais";
            // 
            // chkRangesOnly
            // 
            this.chkRangesOnly.AutoSize = true;
            this.chkRangesOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRangesOnly.Location = new System.Drawing.Point(6, 42);
            this.chkRangesOnly.Name = "chkRangesOnly";
            this.chkRangesOnly.Size = new System.Drawing.Size(164, 17);
            this.chkRangesOnly.TabIndex = 2;
            this.chkRangesOnly.Text = "Calcular apenas os intervalos";
            this.chkRangesOnly.UseVisualStyleBackColor = true;
            // 
            // chkPlot
            // 
            this.chkPlot.AutoSize = true;
            this.chkPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPlot.Location = new System.Drawing.Point(6, 65);
            this.chkPlot.Name = "chkPlot";
            this.chkPlot.Size = new System.Drawing.Size(170, 17);
            this.chkPlot.TabIndex = 1;
            this.chkPlot.Text = "Desenhar gráfico após cálculo";
            this.chkPlot.UseVisualStyleBackColor = true;
            // 
            // chkRanges
            // 
            this.chkRanges.AutoSize = true;
            this.chkRanges.Checked = true;
            this.chkRanges.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRanges.Location = new System.Drawing.Point(6, 20);
            this.chkRanges.Name = "chkRanges";
            this.chkRanges.Size = new System.Drawing.Size(223, 17);
            this.chkRanges.TabIndex = 0;
            this.chkRanges.Text = "Exibir os intervalos com indícios de raízes";
            this.chkRanges.UseVisualStyleBackColor = true;
            // 
            // btnClear1
            // 
            this.btnClear1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear1.Location = new System.Drawing.Point(423, 180);
            this.btnClear1.Name = "btnClear1";
            this.btnClear1.Size = new System.Drawing.Size(75, 23);
            this.btnClear1.TabIndex = 30;
            this.btnClear1.Text = "Limpar";
            this.btnClear1.UseVisualStyleBackColor = true;
            this.btnClear1.Click += new System.EventHandler(this.btnClear1_Click);
            // 
            // btnCalc1
            // 
            this.btnCalc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc1.Location = new System.Drawing.Point(261, 180);
            this.btnCalc1.Name = "btnCalc1";
            this.btnCalc1.Size = new System.Drawing.Size(75, 23);
            this.btnCalc1.TabIndex = 29;
            this.btnCalc1.Text = "Calcular";
            this.btnCalc1.UseVisualStyleBackColor = true;
            this.btnCalc1.Click += new System.EventHandler(this.btnCalc1_Click);
            // 
            // btnPlot
            // 
            this.btnPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlot.Location = new System.Drawing.Point(342, 180);
            this.btnPlot.Name = "btnPlot";
            this.btnPlot.Size = new System.Drawing.Size(75, 23);
            this.btnPlot.TabIndex = 31;
            this.btnPlot.Text = "Desenhar";
            this.btnPlot.UseVisualStyleBackColor = true;
            this.btnPlot.Click += new System.EventHandler(this.btnPlot_Click);
            // 
            // frmRoots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 592);
            this.Controls.Add(this.btnPlot);
            this.Controls.Add(this.btnClear1);
            this.Controls.Add(this.btnCalc1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmRoots";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Text = "Raízes de Funções";
            this.Load += new System.EventHandler(this.frmRoots_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdRanges)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdRoots)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtBigDelta;
        private System.Windows.Forms.TextBox txtDelta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblMaxIt;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblFx;
        private System.Windows.Forms.TextBox txtFx;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView grdRanges;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdRoots;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdNewton;
        private System.Windows.Forms.RadioButton rdModifiedFalsePosition;
        private System.Windows.Forms.RadioButton rdModifiedNewton;
        private System.Windows.Forms.RadioButton rdBissection;
        private System.Windows.Forms.RadioButton rdFalsePosition;
        private System.Windows.Forms.RadioButton rdUniformSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkPlot;
        private System.Windows.Forms.CheckBox chkRanges;
        private System.Windows.Forms.Button btnClear1;
        private System.Windows.Forms.Button btnCalc1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xi;
        private System.Windows.Forms.DataGridViewTextBoxColumn fxi;
        private System.Windows.Forms.TextBox txtMaxIt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkRangesOnly;
        private System.Windows.Forms.Button btnPlot;
    }
}