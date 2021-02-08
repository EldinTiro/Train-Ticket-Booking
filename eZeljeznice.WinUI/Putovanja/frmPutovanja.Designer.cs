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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDestOD = new System.Windows.Forms.TextBox();
            this.textBoxDestDO = new System.Windows.Forms.TextBox();
            this.textBoxCijena = new System.Windows.Forms.TextBox();
            this.buttonIzmjeni = new System.Windows.Forms.Button();
            this.dateTimePickerPolazak = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDolazak = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDatumPolaska = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPutovanja)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPutovanja);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 362);
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
            this.dgvPutovanja.ReadOnly = true;
            this.dgvPutovanja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPutovanja.Size = new System.Drawing.Size(726, 343);
            this.dgvPutovanja.TabIndex = 0;
            this.dgvPutovanja.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPutovanja_CellClick);
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
            this.label2.Location = new System.Drawing.Point(345, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Destinacija do :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Destinacija od :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 509);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vrijeme polaska :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 509);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Vrijeme dolaska :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 549);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cijena :";
            // 
            // textBoxDestOD
            // 
            this.textBoxDestOD.Location = new System.Drawing.Point(105, 460);
            this.textBoxDestOD.Name = "textBoxDestOD";
            this.textBoxDestOD.ReadOnly = true;
            this.textBoxDestOD.Size = new System.Drawing.Size(153, 20);
            this.textBoxDestOD.TabIndex = 11;
            // 
            // textBoxDestDO
            // 
            this.textBoxDestDO.Location = new System.Drawing.Point(441, 460);
            this.textBoxDestDO.Name = "textBoxDestDO";
            this.textBoxDestDO.ReadOnly = true;
            this.textBoxDestDO.Size = new System.Drawing.Size(153, 20);
            this.textBoxDestDO.TabIndex = 12;
            // 
            // textBoxCijena
            // 
            this.textBoxCijena.Location = new System.Drawing.Point(441, 546);
            this.textBoxCijena.Name = "textBoxCijena";
            this.textBoxCijena.Size = new System.Drawing.Size(65, 20);
            this.textBoxCijena.TabIndex = 15;
            this.textBoxCijena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCijena_KeyPress);
            // 
            // buttonIzmjeni
            // 
            this.buttonIzmjeni.Location = new System.Drawing.Point(457, 604);
            this.buttonIzmjeni.Name = "buttonIzmjeni";
            this.buttonIzmjeni.Size = new System.Drawing.Size(79, 23);
            this.buttonIzmjeni.TabIndex = 16;
            this.buttonIzmjeni.Text = "Izmjeni";
            this.buttonIzmjeni.UseVisualStyleBackColor = true;
            this.buttonIzmjeni.Click += new System.EventHandler(this.buttonIzmjeni_Click);
            // 
            // dateTimePickerPolazak
            // 
            this.dateTimePickerPolazak.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerPolazak.Location = new System.Drawing.Point(106, 503);
            this.dateTimePickerPolazak.Name = "dateTimePickerPolazak";
            this.dateTimePickerPolazak.ShowUpDown = true;
            this.dateTimePickerPolazak.Size = new System.Drawing.Size(201, 20);
            this.dateTimePickerPolazak.TabIndex = 5;
            // 
            // dateTimePickerDolazak
            // 
            this.dateTimePickerDolazak.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerDolazak.Location = new System.Drawing.Point(441, 503);
            this.dateTimePickerDolazak.Name = "dateTimePickerDolazak";
            this.dateTimePickerDolazak.ShowUpDown = true;
            this.dateTimePickerDolazak.Size = new System.Drawing.Size(201, 20);
            this.dateTimePickerDolazak.TabIndex = 17;
            // 
            // dateTimePickerDatumPolaska
            // 
            this.dateTimePickerDatumPolaska.Location = new System.Drawing.Point(106, 546);
            this.dateTimePickerDatumPolaska.Name = "dateTimePickerDatumPolaska";
            this.dateTimePickerDatumPolaska.Size = new System.Drawing.Size(201, 20);
            this.dateTimePickerDatumPolaska.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 549);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Datum polaska";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(647, 604);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(94, 23);
            this.btnPrint.TabIndex = 20;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmPutovanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 750);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePickerDatumPolaska);
            this.Controls.Add(this.dateTimePickerDolazak);
            this.Controls.Add(this.dateTimePickerPolazak);
            this.Controls.Add(this.buttonIzmjeni);
            this.Controls.Add(this.textBoxCijena);
            this.Controls.Add(this.textBoxDestDO);
            this.Controls.Add(this.textBoxDestOD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDestOD;
        private System.Windows.Forms.TextBox textBoxDestDO;
        private System.Windows.Forms.TextBox textBoxCijena;
        private System.Windows.Forms.Button buttonIzmjeni;
        private System.Windows.Forms.DateTimePicker dateTimePickerPolazak;
        private System.Windows.Forms.DateTimePicker dateTimePickerDolazak;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumPolaska;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnPrint;
    }
}