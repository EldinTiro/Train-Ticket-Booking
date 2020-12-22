namespace eZeljeznice.WinUI.Putovanja
{
    partial class frmPutovanjaDetalji
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
            this.components = new System.ComponentModel.Container();
            this.cmbPocetna = new System.Windows.Forms.ComboBox();
            this.cmbKrajnja = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timePickerPolazak = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.timePickerDolazak = new System.Windows.Forms.DateTimePicker();
            this.txtBoxCijena = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPocetna
            // 
            this.cmbPocetna.FormattingEnabled = true;
            this.cmbPocetna.Location = new System.Drawing.Point(33, 51);
            this.cmbPocetna.Name = "cmbPocetna";
            this.cmbPocetna.Size = new System.Drawing.Size(201, 21);
            this.cmbPocetna.TabIndex = 0;
            this.cmbPocetna.Validating += new System.ComponentModel.CancelEventHandler(this.cmbPocetna_Validating);
            // 
            // cmbKrajnja
            // 
            this.cmbKrajnja.FormattingEnabled = true;
            this.cmbKrajnja.Location = new System.Drawing.Point(33, 105);
            this.cmbKrajnja.Name = "cmbKrajnja";
            this.cmbKrajnja.Size = new System.Drawing.Size(201, 21);
            this.cmbKrajnja.TabIndex = 1;
            this.cmbKrajnja.Validating += new System.ComponentModel.CancelEventHandler(this.cmbKrajnja_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Početna stanica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Krajnja stanica";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(33, 161);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum polaska";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vrijeme polaska";
            // 
            // timePickerPolazak
            // 
            this.timePickerPolazak.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerPolazak.Location = new System.Drawing.Point(425, 54);
            this.timePickerPolazak.MinDate = new System.DateTime(1753, 1, 24, 0, 0, 0, 0);
            this.timePickerPolazak.Name = "timePickerPolazak";
            this.timePickerPolazak.Size = new System.Drawing.Size(201, 20);
            this.timePickerPolazak.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Vrijeme dolaska";
            // 
            // timePickerDolazak
            // 
            this.timePickerDolazak.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerDolazak.Location = new System.Drawing.Point(425, 109);
            this.timePickerDolazak.Name = "timePickerDolazak";
            this.timePickerDolazak.Size = new System.Drawing.Size(201, 20);
            this.timePickerDolazak.TabIndex = 8;
            // 
            // txtBoxCijena
            // 
            this.txtBoxCijena.Location = new System.Drawing.Point(425, 158);
            this.txtBoxCijena.Name = "txtBoxCijena";
            this.txtBoxCijena.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCijena.TabIndex = 10;
            this.txtBoxCijena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxCijena_KeyPress);
            this.txtBoxCijena.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxCijena_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cijena putovanja";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(609, 218);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(88, 28);
            this.btnSacuvaj.TabIndex = 12;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmPutovanjaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxCijena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timePickerDolazak);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timePickerPolazak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKrajnja);
            this.Controls.Add(this.cmbPocetna);
            this.Name = "frmPutovanjaDetalji";
            this.Text = "frmPutovanjaDetalji";
            this.Load += new System.EventHandler(this.frmPutovanjaDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPocetna;
        private System.Windows.Forms.ComboBox cmbKrajnja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker timePickerPolazak;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker timePickerDolazak;
        private System.Windows.Forms.TextBox txtBoxCijena;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}