namespace eZeljeznice.WinUI.Putovanja
{
    partial class frmPutovanja
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPutovanja = new System.Windows.Forms.DataGridView();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.cmbOD = new System.Windows.Forms.ComboBox();
            this.cmbDO = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPutovanja)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPutovanja);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 373);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Putovanja";
            // 
            // dgvPutovanja
            // 
            this.dgvPutovanja.AllowUserToAddRows = false;
            this.dgvPutovanja.AllowUserToDeleteRows = false;
            this.dgvPutovanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPutovanja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPutovanja.Location = new System.Drawing.Point(3, 16);
            this.dgvPutovanja.Name = "dgvPutovanja";
            this.dgvPutovanja.Size = new System.Drawing.Size(758, 354);
            this.dgvPutovanja.TabIndex = 0;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(694, 21);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(79, 23);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // cmbOD
            // 
            this.cmbOD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOD.FormattingEnabled = true;
            this.cmbOD.Items.AddRange(new object[] {
            " "});
            this.cmbOD.Location = new System.Drawing.Point(98, 21);
            this.cmbOD.Name = "cmbOD";
            this.cmbOD.Size = new System.Drawing.Size(209, 21);
            this.cmbOD.TabIndex = 3;
            this.cmbOD.SelectedIndexChanged += new System.EventHandler(this.cmbOD_SelectedIndexChanged);
            // 
            // cmbDO
            // 
            this.cmbDO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDO.FormattingEnabled = true;
            this.cmbDO.Items.AddRange(new object[] {
            " "});
            this.cmbDO.Location = new System.Drawing.Point(420, 23);
            this.cmbDO.Name = "cmbDO";
            this.cmbDO.Size = new System.Drawing.Size(220, 21);
            this.cmbDO.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Destinacija od :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Destinacija do :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmPutovanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDO);
            this.Controls.Add(this.cmbOD);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPutovanja";
            this.Text = "frmPutovanja";
            this.Load += new System.EventHandler(this.frmPutovanja_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPutovanja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPutovanja;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.ComboBox cmbOD;
        private System.Windows.Forms.ComboBox cmbDO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}