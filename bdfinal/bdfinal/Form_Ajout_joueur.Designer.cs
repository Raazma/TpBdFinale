namespace bdfinal
{
    partial class Form_Ajout_joueur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ajout_joueur));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Cb_Equipe = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Position = new System.Windows.Forms.Label();
            this.Cb_Position = new System.Windows.Forms.ComboBox();
            this.Tb_Prenom = new System.Windows.Forms.TextBox();
            this.Tb_Nom = new System.Windows.Forms.TextBox();
            this.Dt_Fete = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_Num = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_Lien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Fb_Accept = new FlashButton.FlashButton();
            this.flashButton1 = new FlashButton.FlashButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Date de Naissance :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Prenom :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Equipe :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Cb_Equipe
            // 
            this.Cb_Equipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cb_Equipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Equipe.FormattingEnabled = true;
            this.Cb_Equipe.Location = new System.Drawing.Point(112, 105);
            this.Cb_Equipe.Name = "Cb_Equipe";
            this.Cb_Equipe.Size = new System.Drawing.Size(106, 21);
            this.Cb_Equipe.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "# Chandail :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Position
            // 
            this.Position.AutoSize = true;
            this.Position.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Position.Location = new System.Drawing.Point(3, 186);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(103, 24);
            this.Position.TabIndex = 17;
            this.Position.Text = "Position :";
            this.Position.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Cb_Position
            // 
            this.Cb_Position.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cb_Position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Position.FormattingEnabled = true;
            this.Cb_Position.Items.AddRange(new object[] {
            "Attaquant",
            "Defenseur",
            "Gardien"});
            this.Cb_Position.Location = new System.Drawing.Point(112, 189);
            this.Cb_Position.Name = "Cb_Position";
            this.Cb_Position.Size = new System.Drawing.Size(106, 21);
            this.Cb_Position.TabIndex = 3;
            // 
            // Tb_Prenom
            // 
            this.Tb_Prenom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tb_Prenom.Location = new System.Drawing.Point(112, 63);
            this.Tb_Prenom.Name = "Tb_Prenom";
            this.Tb_Prenom.Size = new System.Drawing.Size(106, 20);
            this.Tb_Prenom.TabIndex = 1;
            // 
            // Tb_Nom
            // 
            this.Tb_Nom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tb_Nom.Location = new System.Drawing.Point(112, 21);
            this.Tb_Nom.Name = "Tb_Nom";
            this.Tb_Nom.Size = new System.Drawing.Size(106, 20);
            this.Tb_Nom.TabIndex = 0;
            // 
            // Dt_Fete
            // 
            this.Dt_Fete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dt_Fete.Location = new System.Drawing.Point(112, 231);
            this.Dt_Fete.Name = "Dt_Fete";
            this.Dt_Fete.Size = new System.Drawing.Size(106, 20);
            this.Dt_Fete.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nom :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Tb_Num
            // 
            this.Tb_Num.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tb_Num.Location = new System.Drawing.Point(112, 147);
            this.Tb_Num.Name = "Tb_Num";
            this.Tb_Num.Size = new System.Drawing.Size(106, 20);
            this.Tb_Num.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tableLayoutPanel4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.Color.Turquoise;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 291);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info Joueur";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.960784F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.03922F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel4.Controls.Add(this.Dt_Fete, 2, 11);
            this.tableLayoutPanel4.Controls.Add(this.Tb_Num, 2, 7);
            this.tableLayoutPanel4.Controls.Add(this.Cb_Position, 2, 9);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.Cb_Equipe, 2, 5);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel4.Controls.Add(this.Tb_Prenom, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.Tb_Nom, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 11);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.Position, 0, 9);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 13;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(249, 272);
            this.tableLayoutPanel4.TabIndex = 24;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(2, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(252, 182);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Logo";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.tb_Lien, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 15);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.50495F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.990099F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.50495F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(248, 165);
            this.tableLayoutPanel3.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(61, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 128);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // tb_Lien
            // 
            this.tb_Lien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Lien.Location = new System.Drawing.Point(61, 138);
            this.tb_Lien.Name = "tb_Lien";
            this.tb_Lien.Size = new System.Drawing.Size(125, 20);
            this.tb_Lien.TabIndex = 24;
            this.tb_Lien.TextChanged += new System.EventHandler(this.tb_Lien_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 28);
            this.label4.TabIndex = 25;
            this.label4.Text = "Lien de la photo :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel2.Controls.Add(this.Fb_Accept, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.flashButton1, 3, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 188);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(252, 103);
            this.tableLayoutPanel2.TabIndex = 22;
            // 
            // Fb_Accept
            // 
            this.Fb_Accept.BackColor = System.Drawing.Color.Transparent;
            this.Fb_Accept.BackgroundImage = global::bdfinal.Properties.Resources.ICON_Accepter_Neutral;
            this.Fb_Accept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Fb_Accept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fb_Accept.ImageClick = global::bdfinal.Properties.Resources.ICON_Accepter_Click;
            this.Fb_Accept.ImageDisable = global::bdfinal.Properties.Resources.ICON_Accepter_Disable;
            this.Fb_Accept.ImageNeutral = global::bdfinal.Properties.Resources.ICON_Accepter_Neutral;
            this.Fb_Accept.ImageOver = global::bdfinal.Properties.Resources.ICON_Accepter_Over;
            this.Fb_Accept.Location = new System.Drawing.Point(162, 71);
            this.Fb_Accept.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Fb_Accept.Name = "Fb_Accept";
            this.Fb_Accept.Size = new System.Drawing.Size(30, 20);
            this.Fb_Accept.TabIndex = 18;
            this.Fb_Accept.Click += new System.EventHandler(this.Fb_Accept_Click);
            // 
            // flashButton1
            // 
            this.flashButton1.BackColor = System.Drawing.Color.Transparent;
            this.flashButton1.BackgroundImage = global::bdfinal.Properties.Resources.ICON_Annuler_Neutral;
            this.flashButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flashButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flashButton1.ImageClick = global::bdfinal.Properties.Resources.ICON_Annuler_Click;
            this.flashButton1.ImageDisable = global::bdfinal.Properties.Resources.ICON_Annuler_Disable;
            this.flashButton1.ImageNeutral = global::bdfinal.Properties.Resources.ICON_Annuler_Neutral;
            this.flashButton1.ImageOver = global::bdfinal.Properties.Resources.ICON_Annuler_Over;
            this.flashButton1.Location = new System.Drawing.Point(201, 71);
            this.flashButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flashButton1.Name = "flashButton1";
            this.flashButton1.Size = new System.Drawing.Size(30, 20);
            this.flashButton1.TabIndex = 19;
            this.flashButton1.Click += new System.EventHandler(this.flashButton1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(268, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(256, 293);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.75369F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9852216F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.26108F));
            this.tableLayoutPanel5.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel1, 4, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(526, 297);
            this.tableLayoutPanel5.TabIndex = 24;
            // 
            // Form_Ajout_joueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bdfinal.Properties.Resources.patFond;
            this.ClientSize = new System.Drawing.Size(526, 297);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(542, 335);
            this.Name = "Form_Ajout_joueur";
            this.Text = "Form_Ajout_joueur";
            this.Load += new System.EventHandler(this.Form_Ajout_joueur_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlashButton.FlashButton Fb_Accept;
        private FlashButton.FlashButton flashButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Cb_Equipe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Position;
        private System.Windows.Forms.ComboBox Cb_Position;
        private System.Windows.Forms.TextBox Tb_Prenom;
        private System.Windows.Forms.TextBox Tb_Nom;
        private System.Windows.Forms.DateTimePicker Dt_Fete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_Num;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox tb_Lien;
        private System.Windows.Forms.Label label4;
    }
}