namespace bdfinal
{
    partial class Form_Modif_Joueur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Modif_Joueur));
            this.Tb_nom = new System.Windows.Forms.TextBox();
            this.Tb_Prenom = new System.Windows.Forms.TextBox();
            this.Tb_NumChandail = new System.Windows.Forms.TextBox();
            this.Tb_Position = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Lb_Num = new System.Windows.Forms.Label();
            this.Cb_Equipe = new System.Windows.Forms.ComboBox();
            this.Btn_Precedent = new System.Windows.Forms.Button();
            this.Btn_Suivant = new System.Windows.Forms.Button();
            this.Btn_Effacer = new System.Windows.Forms.Button();
            this.Btn_Modifier = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Dtp_Naissance = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_Lien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Pb_Logo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Tb_nom
            // 
            this.Tb_nom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tb_nom.Location = new System.Drawing.Point(161, 182);
            this.Tb_nom.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_nom.Name = "Tb_nom";
            this.Tb_nom.Size = new System.Drawing.Size(157, 22);
            this.Tb_nom.TabIndex = 1;
            // 
            // Tb_Prenom
            // 
            this.Tb_Prenom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tb_Prenom.Location = new System.Drawing.Point(161, 255);
            this.Tb_Prenom.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Prenom.Name = "Tb_Prenom";
            this.Tb_Prenom.Size = new System.Drawing.Size(157, 22);
            this.Tb_Prenom.TabIndex = 2;
            // 
            // Tb_NumChandail
            // 
            this.Tb_NumChandail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tb_NumChandail.Location = new System.Drawing.Point(161, 328);
            this.Tb_NumChandail.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_NumChandail.Name = "Tb_NumChandail";
            this.Tb_NumChandail.Size = new System.Drawing.Size(157, 22);
            this.Tb_NumChandail.TabIndex = 3;
            // 
            // Tb_Position
            // 
            this.Tb_Position.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tb_Position.Location = new System.Drawing.Point(161, 401);
            this.Tb_Position.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Position.Name = "Tb_Position";
            this.Tb_Position.Size = new System.Drawing.Size(157, 22);
            this.Tb_Position.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(-2, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Num Joueur :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(-2, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nom :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(-2, 251);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prenom :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(-2, 324);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Num Chandail :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(-2, 397);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "Position :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(-2, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nom equipe :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lb_Num
            // 
            this.Lb_Num.AutoSize = true;
            this.Lb_Num.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_Num.Location = new System.Drawing.Point(161, 43);
            this.Lb_Num.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Num.Name = "Lb_Num";
            this.Lb_Num.Size = new System.Drawing.Size(157, 17);
            this.Lb_Num.TabIndex = 12;
            this.Lb_Num.Text = "label7";
            this.Lb_Num.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Cb_Equipe
            // 
            this.Cb_Equipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cb_Equipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Equipe.FormattingEnabled = true;
            this.Cb_Equipe.Location = new System.Drawing.Point(161, 107);
            this.Cb_Equipe.Margin = new System.Windows.Forms.Padding(4);
            this.Cb_Equipe.Name = "Cb_Equipe";
            this.Cb_Equipe.Size = new System.Drawing.Size(157, 24);
            this.Cb_Equipe.TabIndex = 15;
            // 
            // Btn_Precedent
            // 
            this.Btn_Precedent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Precedent.Location = new System.Drawing.Point(-2, 559);
            this.Btn_Precedent.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Precedent.Name = "Btn_Precedent";
            this.Btn_Precedent.Size = new System.Drawing.Size(155, 28);
            this.Btn_Precedent.TabIndex = 16;
            this.Btn_Precedent.Text = "Precedent";
            this.Btn_Precedent.UseVisualStyleBackColor = true;
            this.Btn_Precedent.Click += new System.EventHandler(this.Btn_Precedent_Click);
            // 
            // Btn_Suivant
            // 
            this.Btn_Suivant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Suivant.Location = new System.Drawing.Point(161, 559);
            this.Btn_Suivant.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Suivant.Name = "Btn_Suivant";
            this.Btn_Suivant.Size = new System.Drawing.Size(157, 28);
            this.Btn_Suivant.TabIndex = 17;
            this.Btn_Suivant.Text = "Suivant";
            this.Btn_Suivant.UseVisualStyleBackColor = true;
            this.Btn_Suivant.Click += new System.EventHandler(this.Btn_Suivant_Click);
            // 
            // Btn_Effacer
            // 
            this.Btn_Effacer.Location = new System.Drawing.Point(446, 401);
            this.Btn_Effacer.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Effacer.Name = "Btn_Effacer";
            this.Btn_Effacer.Size = new System.Drawing.Size(100, 28);
            this.Btn_Effacer.TabIndex = 18;
            this.Btn_Effacer.Text = "Effacer";
            this.Btn_Effacer.UseVisualStyleBackColor = true;
            this.Btn_Effacer.Click += new System.EventHandler(this.Btn_Effacer_Click);
            // 
            // Btn_Modifier
            // 
            this.Btn_Modifier.Location = new System.Drawing.Point(446, 480);
            this.Btn_Modifier.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Modifier.Name = "Btn_Modifier";
            this.Btn_Modifier.Size = new System.Drawing.Size(100, 28);
            this.Btn_Modifier.TabIndex = 19;
            this.Btn_Modifier.Text = "Modifier";
            this.Btn_Modifier.UseVisualStyleBackColor = true;
            this.Btn_Modifier.Click += new System.EventHandler(this.Btn_Modifier_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(446, 559);
            this.Btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(100, 28);
            this.Btn_Cancel.TabIndex = 20;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // Dtp_Naissance
            // 
            this.Dtp_Naissance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dtp_Naissance.Location = new System.Drawing.Point(161, 480);
            this.Dtp_Naissance.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_Naissance.Name = "Dtp_Naissance";
            this.Dtp_Naissance.Size = new System.Drawing.Size(157, 22);
            this.Dtp_Naissance.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(-2, 476);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 36);
            this.label7.TabIndex = 22;
            this.label7.Text = "Date Naissance :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_Lien
            // 
            this.tb_Lien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Lien.Location = new System.Drawing.Point(446, 255);
            this.tb_Lien.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Lien.Name = "tb_Lien";
            this.tb_Lien.Size = new System.Drawing.Size(219, 22);
            this.tb_Lien.TabIndex = 23;
            this.tb_Lien.TextChanged += new System.EventHandler(this.tb_Lien_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(320, 251);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 30);
            this.label8.TabIndex = 24;
            this.label8.Text = "Lien de la photo :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33444F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33445F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33111F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.Dtp_Naissance, 2, 13);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Suivant, 2, 15);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Precedent, 1, 15);
            this.tableLayoutPanel1.Controls.Add(this.Cb_Equipe, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Tb_Position, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.Lb_Num, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Tb_NumChandail, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.Tb_nom, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.Tb_Prenom, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.Pb_Logo, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.tb_Lien, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Effacer, 5, 11);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Modifier, 5, 13);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Cancel, 5, 15);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 17;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(661, 641);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // Pb_Logo
            // 
            this.Pb_Logo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pb_Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pb_Logo.Location = new System.Drawing.Point(446, 47);
            this.Pb_Logo.Margin = new System.Windows.Forms.Padding(4);
            this.Pb_Logo.Name = "Pb_Logo";
            this.tableLayoutPanel1.SetRowSpan(this.Pb_Logo, 6);
            this.Pb_Logo.Size = new System.Drawing.Size(219, 200);
            this.Pb_Logo.TabIndex = 13;
            this.Pb_Logo.TabStop = false;
            // 
            // Form_Modif_Joueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 641);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(677, 676);
            this.Name = "Form_Modif_Joueur";
            this.Text = "Modification de joueurs";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Tb_nom;
        private System.Windows.Forms.TextBox Tb_Prenom;
        private System.Windows.Forms.TextBox Tb_NumChandail;
        private System.Windows.Forms.TextBox Tb_Position;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Lb_Num;
        private System.Windows.Forms.PictureBox Pb_Logo;
        private System.Windows.Forms.ComboBox Cb_Equipe;
        private System.Windows.Forms.Button Btn_Precedent;
        private System.Windows.Forms.Button Btn_Suivant;
        private System.Windows.Forms.Button Btn_Effacer;
        private System.Windows.Forms.Button Btn_Modifier;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.DateTimePicker Dtp_Naissance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_Lien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}