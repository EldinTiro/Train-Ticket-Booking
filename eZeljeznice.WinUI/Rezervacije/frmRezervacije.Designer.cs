namespace eZeljeznice.WinUI.Rezervacije
{
    partial class frmRezervacije
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
            this.dvgRezervacije = new System.Windows.Forms.DataGridView();
            this.textBoxRelacija = new System.Windows.Forms.TextBox();
            this.textBoxKupac = new System.Windows.Forms.TextBox();
            this.textBoxDatumPolaska = new System.Windows.Forms.TextBox();
            this.textBoxCijena = new System.Windows.Forms.TextBox();
            this.buttonPotvrdi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgRezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgRezervacije
            // 
            this.dvgRezervacije.AllowUserToAddRows = false;
            this.dvgRezervacije.AllowUserToDeleteRows = false;
            this.dvgRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgRezervacije.Location = new System.Drawing.Point(25, 47);
            this.dvgRezervacije.Name = "dvgRezervacije";
            this.dvgRezervacije.ReadOnly = true;
            this.dvgRezervacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgRezervacije.Size = new System.Drawing.Size(723, 150);
            this.dvgRezervacije.TabIndex = 0;
            this.dvgRezervacije.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgRezervacije_CellClick);
            // 
            // textBoxRelacija
            // 
            this.textBoxRelacija.Location = new System.Drawing.Point(125, 234);
            this.textBoxRelacija.Name = "textBoxRelacija";
            this.textBoxRelacija.ReadOnly = true;
            this.textBoxRelacija.Size = new System.Drawing.Size(191, 20);
            this.textBoxRelacija.TabIndex = 12;
            // 
            // textBoxKupac
            // 
            this.textBoxKupac.Location = new System.Drawing.Point(125, 278);
            this.textBoxKupac.Name = "textBoxKupac";
            this.textBoxKupac.ReadOnly = true;
            this.textBoxKupac.Size = new System.Drawing.Size(191, 20);
            this.textBoxKupac.TabIndex = 13;
            // 
            // textBoxDatumPolaska
            // 
            this.textBoxDatumPolaska.Location = new System.Drawing.Point(125, 324);
            this.textBoxDatumPolaska.Name = "textBoxDatumPolaska";
            this.textBoxDatumPolaska.ReadOnly = true;
            this.textBoxDatumPolaska.Size = new System.Drawing.Size(153, 20);
            this.textBoxDatumPolaska.TabIndex = 14;
            // 
            // textBoxCijena
            // 
            this.textBoxCijena.Location = new System.Drawing.Point(125, 367);
            this.textBoxCijena.Name = "textBoxCijena";
            this.textBoxCijena.ReadOnly = true;
            this.textBoxCijena.Size = new System.Drawing.Size(50, 20);
            this.textBoxCijena.TabIndex = 15;
            // 
            // buttonPotvrdi
            // 
            this.buttonPotvrdi.Location = new System.Drawing.Point(454, 367);
            this.buttonPotvrdi.Name = "buttonPotvrdi";
            this.buttonPotvrdi.Size = new System.Drawing.Size(79, 23);
            this.buttonPotvrdi.TabIndex = 20;
            this.buttonPotvrdi.Text = "Potvrdi";
            this.buttonPotvrdi.UseVisualStyleBackColor = true;
            this.buttonPotvrdi.Click += new System.EventHandler(this.buttonPotvrdi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Relacija";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Kupac";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Datum polaska";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Cijena";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "Neprocesirane rezervacije";
            // 
            // frmRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPotvrdi);
            this.Controls.Add(this.textBoxCijena);
            this.Controls.Add(this.textBoxDatumPolaska);
            this.Controls.Add(this.textBoxKupac);
            this.Controls.Add(this.textBoxRelacija);
            this.Controls.Add(this.dvgRezervacije);
            this.Name = "frmRezervacije";
            this.Text = "frmRezervacije";
            this.Load += new System.EventHandler(this.frmRezervacije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgRezervacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgRezervacije;
        private System.Windows.Forms.TextBox textBoxRelacija;
        private System.Windows.Forms.TextBox textBoxKupac;
        private System.Windows.Forms.TextBox textBoxDatumPolaska;
        private System.Windows.Forms.TextBox textBoxCijena;
        private System.Windows.Forms.Button buttonPotvrdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}