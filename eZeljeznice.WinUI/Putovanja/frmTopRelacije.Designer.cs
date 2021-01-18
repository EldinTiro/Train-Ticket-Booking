namespace eZeljeznice.WinUI.Putovanja
{
    partial class frmTopRelacije
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
            this.dgvTopRelacije = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrikaziTop3Relacije = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopRelacije)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTopRelacije
            // 
            this.dgvTopRelacije.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTopRelacije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopRelacije.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvTopRelacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopRelacije.Location = new System.Drawing.Point(25, 85);
            this.dgvTopRelacije.Name = "dgvTopRelacije";
            this.dgvTopRelacije.Size = new System.Drawing.Size(572, 133);
            this.dgvTopRelacije.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Top 5 najtraženijih relacija";
            // 
            // btnPrikaziTop3Relacije
            // 
            this.btnPrikaziTop3Relacije.Location = new System.Drawing.Point(496, 310);
            this.btnPrikaziTop3Relacije.Name = "btnPrikaziTop3Relacije";
            this.btnPrikaziTop3Relacije.Size = new System.Drawing.Size(75, 23);
            this.btnPrikaziTop3Relacije.TabIndex = 2;
            this.btnPrikaziTop3Relacije.Text = "Prikazi";
            this.btnPrikaziTop3Relacije.UseVisualStyleBackColor = true;
            this.btnPrikaziTop3Relacije.Click += new System.EventHandler(this.btnPrikaziTop3Relacije_Click);
            // 
            // frmTopRelacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 384);
            this.Controls.Add(this.btnPrikaziTop3Relacije);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTopRelacije);
            this.Name = "frmTopRelacije";
            this.Text = "frmTopRelacije";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopRelacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTopRelacije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrikaziTop3Relacije;
    }
}