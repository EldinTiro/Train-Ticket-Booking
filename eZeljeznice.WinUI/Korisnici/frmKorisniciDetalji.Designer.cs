namespace eZeljeznice.WinUI.Korisnici
{
    partial class frmKorisniciDetalji
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.Ime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDatumRodjenja = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPotvrda = new System.Windows.Forms.TextBox();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(13, 43);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(365, 20);
            this.txtIme.TabIndex = 0;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
            // 
            // Ime
            // 
            this.Ime.AutoSize = true;
            this.Ime.Location = new System.Drawing.Point(10, 27);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(24, 13);
            this.Ime.TabIndex = 1;
            this.Ime.Text = "Ime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Prezime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(13, 93);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(365, 20);
            this.txtPrezime.TabIndex = 2;
            this.txtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezime_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(13, 141);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(365, 20);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Datum Rođenja";
            // 
            // txtDatumRodjenja
            // 
            this.txtDatumRodjenja.Location = new System.Drawing.Point(13, 189);
            this.txtDatumRodjenja.Name = "txtDatumRodjenja";
            this.txtDatumRodjenja.Size = new System.Drawing.Size(365, 20);
            this.txtDatumRodjenja.TabIndex = 6;
            this.txtDatumRodjenja.Validating += new System.ComponentModel.CancelEventHandler(this.txtDatumRodjenja_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Korisničko ime";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(13, 237);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(365, 20);
            this.txtKorisnickoIme.TabIndex = 8;
            this.txtKorisnickoIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtKorisnickoIme_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(10, 289);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(165, 20);
            this.txtPassword.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Potvrda";
            // 
            // txtPotvrda
            // 
            this.txtPotvrda.Location = new System.Drawing.Point(213, 289);
            this.txtPotvrda.Name = "txtPotvrda";
            this.txtPotvrda.Size = new System.Drawing.Size(165, 20);
            this.txtPotvrda.TabIndex = 14;
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(246, 346);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(132, 23);
            this.btnSnimi.TabIndex = 16;
            this.btnSnimi.Text = "Sačuvaj";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmKorisniciDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPotvrda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDatumRodjenja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.txtIme);
            this.Name = "frmKorisniciDetalji";
            this.Text = "frmKorisniciDetalji";
            this.Load += new System.EventHandler(this.frmKorisniciDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label Ime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDatumRodjenja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPotvrda;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}