﻿namespace bdfinal
{
    partial class Form_Classement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGV_Classement = new System.Windows.Forms.DataGridView();
            this.CB_Classement = new System.Windows.Forms.ComboBox();
            this.CB_Division = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Classement)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CB_Division);
            this.panel1.Controls.Add(this.CB_Classement);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 100);
            this.panel1.TabIndex = 0;
            // 
            // DGV_Classement
            // 
            this.DGV_Classement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Classement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Classement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Classement.Location = new System.Drawing.Point(0, 100);
            this.DGV_Classement.Name = "DGV_Classement";
            this.DGV_Classement.RowTemplate.Height = 24;
            this.DGV_Classement.Size = new System.Drawing.Size(856, 398);
            this.DGV_Classement.TabIndex = 1;
            // 
            // CB_Classement
            // 
            this.CB_Classement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Classement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_Classement.FormattingEnabled = true;
            this.CB_Classement.Items.AddRange(new object[] {
            "Équipes",
            "Joueurs",
            "3 Meilleurs"});
            this.CB_Classement.Location = new System.Drawing.Point(85, 12);
            this.CB_Classement.Name = "CB_Classement";
            this.CB_Classement.Size = new System.Drawing.Size(182, 24);
            this.CB_Classement.TabIndex = 0;
            this.CB_Classement.SelectedIndexChanged += new System.EventHandler(this.CB_Classement_SelectedIndexChanged);
            // 
            // CB_Division
            // 
            this.CB_Division.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Division.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_Division.FormattingEnabled = true;
            this.CB_Division.Location = new System.Drawing.Point(292, 12);
            this.CB_Division.Name = "CB_Division";
            this.CB_Division.Size = new System.Drawing.Size(182, 24);
            this.CB_Division.TabIndex = 1;
            this.CB_Division.SelectedIndexChanged += new System.EventHandler(this.CB_Division_SelectedIndexChanged);
            // 
            // Form_Classement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 498);
            this.Controls.Add(this.DGV_Classement);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Classement";
            this.Text = "Classements";
            this.Load += new System.EventHandler(this.Form_Classement_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Classement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CB_Classement;
        private System.Windows.Forms.DataGridView DGV_Classement;
        private System.Windows.Forms.ComboBox CB_Division;
    }
}