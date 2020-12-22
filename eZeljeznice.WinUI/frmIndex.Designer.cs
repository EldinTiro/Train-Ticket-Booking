namespace eZeljeznice.WinUI
{
    partial class frmIndex
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviKorisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.putovanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.novoPutovanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajAkcijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topRelacijeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.programiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loyalityProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisniciToolStripMenuItem,
            this.putovanjaToolStripMenuItem,
            this.relacijeToolStripMenuItem,
            this.programiToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem,
            this.noviKorisnikToolStripMenuItem});
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.pretragaToolStripMenuItem.Text = "Pretraga";
            this.pretragaToolStripMenuItem.Click += new System.EventHandler(this.pretragaToolStripMenuItem_Click);
            // 
            // noviKorisnikToolStripMenuItem
            // 
            this.noviKorisnikToolStripMenuItem.Name = "noviKorisnikToolStripMenuItem";
            this.noviKorisnikToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.noviKorisnikToolStripMenuItem.Text = "Novi korisnik";
            this.noviKorisnikToolStripMenuItem.Click += new System.EventHandler(this.noviKorisnikToolStripMenuItem_Click);
            // 
            // putovanjaToolStripMenuItem
            // 
            this.putovanjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem1,
            this.novoPutovanjeToolStripMenuItem,
            this.kreirajAkcijuToolStripMenuItem});
            this.putovanjaToolStripMenuItem.Name = "putovanjaToolStripMenuItem";
            this.putovanjaToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.putovanjaToolStripMenuItem.Text = "Putovanja";
            // 
            // pretragaToolStripMenuItem1
            // 
            this.pretragaToolStripMenuItem1.Name = "pretragaToolStripMenuItem1";
            this.pretragaToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.pretragaToolStripMenuItem1.Text = "Pretraga";
            this.pretragaToolStripMenuItem1.Click += new System.EventHandler(this.pretragaToolStripMenuItem1_Click);
            // 
            // novoPutovanjeToolStripMenuItem
            // 
            this.novoPutovanjeToolStripMenuItem.Name = "novoPutovanjeToolStripMenuItem";
            this.novoPutovanjeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.novoPutovanjeToolStripMenuItem.Text = "Novo putovanje";
            this.novoPutovanjeToolStripMenuItem.Click += new System.EventHandler(this.novoPutovanjeToolStripMenuItem_Click);
            // 
            // kreirajAkcijuToolStripMenuItem
            // 
            this.kreirajAkcijuToolStripMenuItem.Name = "kreirajAkcijuToolStripMenuItem";
            this.kreirajAkcijuToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.kreirajAkcijuToolStripMenuItem.Text = "Kreiraj akciju";
            this.kreirajAkcijuToolStripMenuItem.Click += new System.EventHandler(this.kreirajAkcijuToolStripMenuItem_Click);
            // 
            // relacijeToolStripMenuItem
            // 
            this.relacijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topRelacijeToolStripMenuItem1});
            this.relacijeToolStripMenuItem.Name = "relacijeToolStripMenuItem";
            this.relacijeToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.relacijeToolStripMenuItem.Text = "Relacije";
            // 
            // topRelacijeToolStripMenuItem1
            // 
            this.topRelacijeToolStripMenuItem1.Name = "topRelacijeToolStripMenuItem1";
            this.topRelacijeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.topRelacijeToolStripMenuItem1.Text = "Top relacije";
            this.topRelacijeToolStripMenuItem1.Click += new System.EventHandler(this.topRelacijeToolStripMenuItem1_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // programiToolStripMenuItem
            // 
            this.programiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loyalityProgramToolStripMenuItem});
            this.programiToolStripMenuItem.Name = "programiToolStripMenuItem";
            this.programiToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.programiToolStripMenuItem.Text = "Programi";
            // 
            // loyalityProgramToolStripMenuItem
            // 
            this.loyalityProgramToolStripMenuItem.Name = "loyalityProgramToolStripMenuItem";
            this.loyalityProgramToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loyalityProgramToolStripMenuItem.Text = "Loyality Program";
            this.loyalityProgramToolStripMenuItem.Click += new System.EventHandler(this.loyalityProgramToolStripMenuItem_Click);
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmIndex";
            this.Text = "frmIndex";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviKorisnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem putovanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem novoPutovanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajAkcijuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topRelacijeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem programiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loyalityProgramToolStripMenuItem;
    }
}



