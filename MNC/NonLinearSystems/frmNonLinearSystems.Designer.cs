namespace MNC.NonLinearSystems
{
    partial class frmNonLinearSystems
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCalc1 = new System.Windows.Forms.Button();
            this.btnClear1 = new System.Windows.Forms.Button();
            this.rdNewton = new System.Windows.Forms.RadioButton();
            this.rdModifiedNewton = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grdX = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaxIt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.xi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdX)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdX);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 107);
            this.groupBox2.MaximumSize = new System.Drawing.Size(10000, 385);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(732, 385);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados e Resultados";
            // 
            // btnCalc1
            // 
            this.btnCalc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc1.Location = new System.Drawing.Point(277, 78);
            this.btnCalc1.Name = "btnCalc1";
            this.btnCalc1.Size = new System.Drawing.Size(75, 23);
            this.btnCalc1.TabIndex = 42;
            this.btnCalc1.Text = "Calcular";
            this.btnCalc1.UseVisualStyleBackColor = true;
            this.btnCalc1.Click += new System.EventHandler(this.btnCalc1_Click);
            // 
            // btnClear1
            // 
            this.btnClear1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear1.Location = new System.Drawing.Point(358, 78);
            this.btnClear1.Name = "btnClear1";
            this.btnClear1.Size = new System.Drawing.Size(75, 23);
            this.btnClear1.TabIndex = 43;
            this.btnClear1.Text = "Limpar";
            this.btnClear1.UseVisualStyleBackColor = true;
            // 
            // rdNewton
            // 
            this.rdNewton.AutoSize = true;
            this.rdNewton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNewton.Location = new System.Drawing.Point(6, 23);
            this.rdNewton.Name = "rdNewton";
            this.rdNewton.Size = new System.Drawing.Size(62, 17);
            this.rdNewton.TabIndex = 0;
            this.rdNewton.TabStop = true;
            this.rdNewton.Text = "Newton";
            this.rdNewton.UseVisualStyleBackColor = true;
            // 
            // rdModifiedNewton
            // 
            this.rdModifiedNewton.AutoSize = true;
            this.rdModifiedNewton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdModifiedNewton.Location = new System.Drawing.Point(184, 23);
            this.rdModifiedNewton.Name = "rdModifiedNewton";
            this.rdModifiedNewton.Size = new System.Drawing.Size(117, 17);
            this.rdModifiedNewton.TabIndex = 2;
            this.rdModifiedNewton.TabStop = true;
            this.rdModifiedNewton.Text = "Newton Modificado";
            this.rdModifiedNewton.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdModifiedNewton);
            this.groupBox4.Controls.Add(this.rdNewton);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(10, 10);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(50);
            this.groupBox4.MaximumSize = new System.Drawing.Size(1000, 50);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(342, 50);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Métodos";
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
            this.grdX.Location = new System.Drawing.Point(3, 16);
            this.grdX.Name = "grdX";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.Format = "N0";
            dataGridViewCellStyle13.NullValue = null;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdX.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Format = "N6";
            dataGridViewCellStyle14.NullValue = null;
            this.grdX.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.grdX.Size = new System.Drawing.Size(726, 366);
            this.grdX.TabIndex = 11;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtE);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.txtMaxIt);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(358, 10);
            this.groupBox5.MaximumSize = new System.Drawing.Size(1000, 50);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(384, 50);
            this.groupBox5.TabIndex = 44;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Parâmetros";
            // 
            // txtE
            // 
            this.txtE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtE.Location = new System.Drawing.Point(225, 22);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(145, 20);
            this.txtE.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "ε = ";
            // 
            // txtMaxIt
            // 
            this.txtMaxIt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxIt.Location = new System.Drawing.Point(48, 22);
            this.txtMaxIt.Name = "txtMaxIt";
            this.txtMaxIt.Size = new System.Drawing.Size(145, 20);
            this.txtMaxIt.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "MaxIt =";
            // 
            // xi
            // 
            this.xi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xi.FillWeight = 30F;
            this.xi.HeaderText = "x[i]";
            this.xi.Name = "xi";
            // 
            // fxi
            // 
            this.fxi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fxi.FillWeight = 70F;
            this.fxi.HeaderText = "f(x[i])";
            this.fxi.Name = "fxi";
            // 
            // frmNonLinearSystems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 502);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCalc1);
            this.Controls.Add(this.btnClear1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNonLinearSystems";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Sistemas Não Lineares";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.frmNonLinearSystems_HelpButtonClicked);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdX)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCalc1;
        private System.Windows.Forms.Button btnClear1;
        private System.Windows.Forms.RadioButton rdNewton;
        private System.Windows.Forms.RadioButton rdModifiedNewton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView grdX;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaxIt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xi;
        private System.Windows.Forms.DataGridViewTextBoxColumn fxi;
    }
}