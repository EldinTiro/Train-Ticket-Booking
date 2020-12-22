namespace eZeljeznice.WinUI.Putovanja
{
    partial class frmPutovanjaAkcije
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
            this.cmbxPolazisteAkcija = new System.Windows.Forms.ComboBox();
            this.cmbxOdredisteAkcija = new System.Windows.Forms.ComboBox();
            this.comboBoxVrijednostAkcije = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datetimePickerPocetkaAkcije = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerZavrsetkaAkcije = new System.Windows.Forms.DateTimePicker();
            this.btnKreirajAkciju = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbxPolazisteAkcija
            // 
            this.cmbxPolazisteAkcija.FormattingEnabled = true;
            this.cmbxPolazisteAkcija.Location = new System.Drawing.Point(92, 65);
            this.cmbxPolazisteAkcija.Name = "cmbxPolazisteAkcija";
            this.cmbxPolazisteAkcija.Size = new System.Drawing.Size(173, 21);
            this.cmbxPolazisteAkcija.TabIndex = 0;
            // 
            // cmbxOdredisteAkcija
            // 
            this.cmbxOdredisteAkcija.FormattingEnabled = true;
            this.cmbxOdredisteAkcija.Location = new System.Drawing.Point(372, 65);
            this.cmbxOdredisteAkcija.Name = "cmbxOdredisteAkcija";
            this.cmbxOdredisteAkcija.Size = new System.Drawing.Size(200, 21);
            this.cmbxOdredisteAkcija.TabIndex = 1;
            // 
            // comboBoxVrijednostAkcije
            // 
            this.comboBoxVrijednostAkcije.FormattingEnabled = true;
            this.comboBoxVrijednostAkcije.Location = new System.Drawing.Point(187, 225);
            this.comboBoxVrijednostAkcije.Name = "comboBoxVrijednostAkcije";
            this.comboBoxVrijednostAkcije.Size = new System.Drawing.Size(77, 21);
            this.comboBoxVrijednostAkcije.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Polaziste";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Odrediste";
            // 
            // datetimePickerPocetkaAkcije
            // 
            this.datetimePickerPocetkaAkcije.Location = new System.Drawing.Point(92, 151);
            this.datetimePickerPocetkaAkcije.Name = "datetimePickerPocetkaAkcije";
            this.datetimePickerPocetkaAkcije.Size = new System.Drawing.Size(173, 20);
            this.datetimePickerPocetkaAkcije.TabIndex = 5;
            // 
            // dateTimePickerZavrsetkaAkcije
            // 
            this.dateTimePickerZavrsetkaAkcije.Location = new System.Drawing.Point(372, 151);
            this.dateTimePickerZavrsetkaAkcije.Name = "dateTimePickerZavrsetkaAkcije";
            this.dateTimePickerZavrsetkaAkcije.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerZavrsetkaAkcije.TabIndex = 6;
            // 
            // btnKreirajAkciju
            // 
            this.btnKreirajAkciju.Location = new System.Drawing.Point(478, 270);
            this.btnKreirajAkciju.Name = "btnKreirajAkciju";
            this.btnKreirajAkciju.Size = new System.Drawing.Size(94, 38);
            this.btnKreirajAkciju.TabIndex = 7;
            this.btnKreirajAkciju.Text = "Kreiraj akciju!";
            this.btnKreirajAkciju.UseVisualStyleBackColor = true;
            this.btnKreirajAkciju.Click += new System.EventHandler(this.btnKreirajAkciju_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Akcija od";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Akcija do";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vrijednost akcije u % :";
            // 
            // frmPutovanjaAkcije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKreirajAkciju);
            this.Controls.Add(this.dateTimePickerZavrsetkaAkcije);
            this.Controls.Add(this.datetimePickerPocetkaAkcije);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxVrijednostAkcije);
            this.Controls.Add(this.cmbxOdredisteAkcija);
            this.Controls.Add(this.cmbxPolazisteAkcija);
            this.Name = "frmPutovanjaAkcije";
            this.Text = "frmPutovanjaAkcije";
            this.Load += new System.EventHandler(this.frmPutovanjaAkcije_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxPolazisteAkcija;
        private System.Windows.Forms.ComboBox cmbxOdredisteAkcija;
        private System.Windows.Forms.ComboBox comboBoxVrijednostAkcije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datetimePickerPocetkaAkcije;
        private System.Windows.Forms.DateTimePicker dateTimePickerZavrsetkaAkcije;
        private System.Windows.Forms.Button btnKreirajAkciju;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}