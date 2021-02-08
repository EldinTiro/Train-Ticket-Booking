namespace eZeljeznice.WinUI.Kupljene_Karte
{
    partial class frmKupljeneKarte
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
            this.cmbZeljeznicke = new System.Windows.Forms.ComboBox();
            this.dvgPolaznaPutovanja = new System.Windows.Forms.DataGridView();
            this.dvgDolaznaPutovanja = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerDatumKarte = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPolaznaPutovanja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDolaznaPutovanja)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbZeljeznicke
            // 
            this.cmbZeljeznicke.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZeljeznicke.FormattingEnabled = true;
            this.cmbZeljeznicke.Items.AddRange(new object[] {
            " "});
            this.cmbZeljeznicke.Location = new System.Drawing.Point(77, 66);
            this.cmbZeljeznicke.Name = "cmbZeljeznicke";
            this.cmbZeljeznicke.Size = new System.Drawing.Size(209, 21);
            this.cmbZeljeznicke.TabIndex = 4;
            // 
            // dvgPolaznaPutovanja
            // 
            this.dvgPolaznaPutovanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPolaznaPutovanja.Location = new System.Drawing.Point(77, 249);
            this.dvgPolaznaPutovanja.Name = "dvgPolaznaPutovanja";
            this.dvgPolaznaPutovanja.Size = new System.Drawing.Size(805, 209);
            this.dvgPolaznaPutovanja.TabIndex = 5;
            // 
            // dvgDolaznaPutovanja
            // 
            this.dvgDolaznaPutovanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDolaznaPutovanja.Location = new System.Drawing.Point(77, 550);
            this.dvgDolaznaPutovanja.Name = "dvgDolaznaPutovanja";
            this.dvgDolaznaPutovanja.Size = new System.Drawing.Size(805, 213);
            this.dvgDolaznaPutovanja.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Polazna putovanja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 522);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dolazna putovanja";
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(124, 163);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(122, 30);
            this.btnTrazi.TabIndex = 10;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1013, 743);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(122, 30);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Datum kupljene karte";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateTimePickerDatumKarte
            // 
            this.dateTimePickerDatumKarte.Location = new System.Drawing.Point(77, 125);
            this.dateTimePickerDatumKarte.Name = "dateTimePickerDatumKarte";
            this.dateTimePickerDatumKarte.Size = new System.Drawing.Size(209, 20);
            this.dateTimePickerDatumKarte.TabIndex = 12;
            this.dateTimePickerDatumKarte.Value = new System.DateTime(2021, 2, 4, 12, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Željeznička stanica";
            // 
            // frmKupljeneKarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 805);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerDatumKarte);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvgDolaznaPutovanja);
            this.Controls.Add(this.dvgPolaznaPutovanja);
            this.Controls.Add(this.cmbZeljeznicke);
            this.Name = "frmKupljeneKarte";
            this.Text = "frmKupljeneKarte";
            this.Load += new System.EventHandler(this.frmKupljeneKarte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgPolaznaPutovanja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDolaznaPutovanja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbZeljeznicke;
        private System.Windows.Forms.DataGridView dvgPolaznaPutovanja;
        private System.Windows.Forms.DataGridView dvgDolaznaPutovanja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumKarte;
        private System.Windows.Forms.Label label4;
    }
}