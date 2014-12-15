namespace bdfinal
{
    partial class Form_Ajout_Fiche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ajout_Fiche));
            this.Cb_Numatch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Nbut = new System.Windows.Forms.TextBox();
            this.Tb_nbpasse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Cb_Numjoueur = new System.Windows.Forms.ComboBox();
            this.Btn_cancel = new System.Windows.Forms.Button();
            this.Btn_Ajouter = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cb_Numatch
            // 
            this.Cb_Numatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Numatch.FormattingEnabled = true;
            this.Cb_Numatch.Location = new System.Drawing.Point(132, 35);
            this.Cb_Numatch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cb_Numatch.Name = "Cb_Numatch";
            this.Cb_Numatch.Size = new System.Drawing.Size(160, 24);
            this.Cb_Numatch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numéro Partie :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_Nbut
            // 
            this.tb_Nbut.Location = new System.Drawing.Point(132, 161);
            this.tb_Nbut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Nbut.Name = "tb_Nbut";
            this.tb_Nbut.Size = new System.Drawing.Size(80, 22);
            this.tb_Nbut.TabIndex = 4;
            // 
            // Tb_nbpasse
            // 
            this.Tb_nbpasse.Location = new System.Drawing.Point(439, 161);
            this.Tb_nbpasse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tb_nbpasse.Name = "Tb_nbpasse";
            this.Tb_nbpasse.Size = new System.Drawing.Size(104, 22);
            this.Tb_nbpasse.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(7, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numéro joueur :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(303, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre de passe :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(7, 157);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nombre de buts :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Cb_Numjoueur
            // 
            this.Cb_Numjoueur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Numjoueur.FormattingEnabled = true;
            this.Cb_Numjoueur.Location = new System.Drawing.Point(132, 98);
            this.Cb_Numjoueur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cb_Numjoueur.Name = "Cb_Numjoueur";
            this.Cb_Numjoueur.Size = new System.Drawing.Size(160, 24);
            this.Cb_Numjoueur.TabIndex = 12;
            // 
            // Btn_cancel
            // 
            this.Btn_cancel.Location = new System.Drawing.Point(303, 222);
            this.Btn_cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_cancel.Name = "Btn_cancel";
            this.Btn_cancel.Size = new System.Drawing.Size(100, 32);
            this.Btn_cancel.TabIndex = 13;
            this.Btn_cancel.Text = "Annuler";
            this.Btn_cancel.UseVisualStyleBackColor = true;
            // 
            // Btn_Ajouter
            // 
            this.Btn_Ajouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Ajouter.Location = new System.Drawing.Point(192, 222);
            this.Btn_Ajouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Ajouter.Name = "Btn_Ajouter";
            this.Btn_Ajouter.Size = new System.Drawing.Size(100, 28);
            this.Btn_Ajouter.TabIndex = 14;
            this.Btn_Ajouter.Text = "Ajouter";
            this.Btn_Ajouter.UseVisualStyleBackColor = true;
            this.Btn_Ajouter.Click += new System.EventHandler(this.Btn_Ajouter_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Btn_cancel, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Ajouter, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.Cb_Numatch, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Tb_nbpasse, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.Cb_Numjoueur, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_Nbut, 2, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(551, 293);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // Form_Ajout_Fiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 293);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(569, 338);
            this.Name = "Form_Ajout_Fiche";
            this.Text = "Form_Ajout_Fiche";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Cb_Numatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Nbut;
        private System.Windows.Forms.TextBox Tb_nbpasse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Cb_Numjoueur;
        private System.Windows.Forms.Button Btn_cancel;
        private System.Windows.Forms.Button Btn_Ajouter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    }
}