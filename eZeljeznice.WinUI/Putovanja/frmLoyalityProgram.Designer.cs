﻿using System.Windows.Forms;

namespace eZeljeznice.WinUI.Putovanja
{
    partial class frmLoyalityProgram
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
            this.dgvLoyality = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoyality)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoyality
            // 
            this.dgvLoyality.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoyality.Location = new System.Drawing.Point(23, 58);
            this.dgvLoyality.Name = "dgvLoyality";
            this.dgvLoyality.Size = new System.Drawing.Size(636, 177);
            this.dgvLoyality.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(23, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(636, 10);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pokreni job za generisanje novih loyalty korisnika?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Pokreni job i prikazi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmLoyalityProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 422);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLoyality);
            this.Name = "frmLoyalityProgram";
            this.Text = "frmLoyalityProgram";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoyality)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoyality;
        private System.Windows.Forms.Label label1;
        private Label label2;
        private Button button1;
    }
}