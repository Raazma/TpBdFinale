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
            this.flashButton1 = new FlashButton.FlashButton();
            this.Fb_Accept = new FlashButton.FlashButton();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_ChoisirLogo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flashButton1
            // 
            this.flashButton1.BackColor = System.Drawing.Color.Transparent;
            this.flashButton1.BackgroundImage = global::bdfinal.Properties.Resources.ICON_Annuler_Neutral;
            this.flashButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flashButton1.ImageClick = global::bdfinal.Properties.Resources.ICON_Annuler_Click;
            this.flashButton1.ImageDisable = global::bdfinal.Properties.Resources.ICON_Annuler_Disable;
            this.flashButton1.ImageNeutral = global::bdfinal.Properties.Resources.ICON_Annuler_Neutral;
            this.flashButton1.ImageOver = global::bdfinal.Properties.Resources.ICON_Annuler_Over;
            this.flashButton1.Location = new System.Drawing.Point(498, 299);
            this.flashButton1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.flashButton1.Name = "flashButton1";
            this.flashButton1.Size = new System.Drawing.Size(40, 33);
            this.flashButton1.TabIndex = 19;
            this.flashButton1.Click += new System.EventHandler(this.flashButton1_Click);
            // 
            // Fb_Accept
            // 
            this.Fb_Accept.BackColor = System.Drawing.Color.Transparent;
            this.Fb_Accept.BackgroundImage = global::bdfinal.Properties.Resources.ICON_Accepter_Neutral;
            this.Fb_Accept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Fb_Accept.ImageClick = global::bdfinal.Properties.Resources.ICON_Accepter_Click;
            this.Fb_Accept.ImageDisable = global::bdfinal.Properties.Resources.ICON_Accepter_Disable;
            this.Fb_Accept.ImageNeutral = global::bdfinal.Properties.Resources.ICON_Accepter_Neutral;
            this.Fb_Accept.ImageOver = global::bdfinal.Properties.Resources.ICON_Accepter_Over;
            this.Fb_Accept.Location = new System.Drawing.Point(394, 299);
            this.Fb_Accept.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Fb_Accept.Name = "Fb_Accept";
            this.Fb_Accept.Size = new System.Drawing.Size(47, 33);
            this.Fb_Accept.TabIndex = 18;
            this.Fb_Accept.Click += new System.EventHandler(this.Fb_Accept_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 261);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Date de Naissance :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Prenom :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 125);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Equipe :";
            // 
            // Cb_Equipe
            // 
            this.Cb_Equipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Equipe.FormattingEnabled = true;
            this.Cb_Equipe.Location = new System.Drawing.Point(99, 122);
            this.Cb_Equipe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cb_Equipe.Name = "Cb_Equipe";
            this.Cb_Equipe.Size = new System.Drawing.Size(116, 24);
            this.Cb_Equipe.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 167);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "# Chandail :";
            // 
            // Position
            // 
            this.Position.AutoSize = true;
            this.Position.Location = new System.Drawing.Point(25, 206);
            this.Position.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(66, 17);
            this.Position.TabIndex = 17;
            this.Position.Text = "Position :";
            // 
            // Cb_Position
            // 
            this.Cb_Position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Position.FormattingEnabled = true;
            this.Cb_Position.Items.AddRange(new object[] {
            "Attaquant",
            "Defenseur",
            "Gardien"});
            this.Cb_Position.Location = new System.Drawing.Point(99, 203);
            this.Cb_Position.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cb_Position.Name = "Cb_Position";
            this.Cb_Position.Size = new System.Drawing.Size(135, 24);
            this.Cb_Position.TabIndex = 3;
            // 
            // Tb_Prenom
            // 
            this.Tb_Prenom.Location = new System.Drawing.Point(99, 77);
            this.Tb_Prenom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tb_Prenom.Name = "Tb_Prenom";
            this.Tb_Prenom.Size = new System.Drawing.Size(132, 22);
            this.Tb_Prenom.TabIndex = 1;
            // 
            // Tb_Nom
            // 
            this.Tb_Nom.Location = new System.Drawing.Point(99, 34);
            this.Tb_Nom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tb_Nom.Name = "Tb_Nom";
            this.Tb_Nom.Size = new System.Drawing.Size(132, 22);
            this.Tb_Nom.TabIndex = 0;
            // 
            // Dt_Fete
            // 
            this.Dt_Fete.Location = new System.Drawing.Point(152, 261);
            this.Dt_Fete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dt_Fete.Name = "Dt_Fete";
            this.Dt_Fete.Size = new System.Drawing.Size(149, 22);
            this.Dt_Fete.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nom :";
            // 
            // Tb_Num
            // 
            this.Tb_Num.Location = new System.Drawing.Point(99, 164);
            this.Tb_Num.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tb_Num.Name = "Tb_Num";
            this.Tb_Num.Size = new System.Drawing.Size(55, 22);
            this.Tb_Num.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Tb_Num);
            this.groupBox1.Controls.Add(this.Cb_Equipe);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Dt_Fete);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Tb_Nom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Position);
            this.groupBox1.Controls.Add(this.Tb_Prenom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Cb_Position);
            this.groupBox1.ForeColor = System.Drawing.Color.Turquoise;
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(349, 336);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info Joueur";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.Btn_ChoisirLogo);
            this.groupBox2.Location = new System.Drawing.Point(372, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 235);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Logo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(10, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 166);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_ChoisirLogo
            // 
            this.Btn_ChoisirLogo.Location = new System.Drawing.Point(7, 196);
            this.Btn_ChoisirLogo.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_ChoisirLogo.Name = "Btn_ChoisirLogo";
            this.Btn_ChoisirLogo.Size = new System.Drawing.Size(175, 28);
            this.Btn_ChoisirLogo.TabIndex = 15;
            this.Btn_ChoisirLogo.Text = "Choisir Logo...";
            this.Btn_ChoisirLogo.UseVisualStyleBackColor = true;
            // 
            // Form_Ajout_joueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bdfinal.Properties.Resources.patFond;
            this.ClientSize = new System.Drawing.Size(569, 360);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flashButton1);
            this.Controls.Add(this.Fb_Accept);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Ajout_joueur";
            this.Text = "Form_Ajout_joueur";
            this.Load += new System.EventHandler(this.Form_Ajout_joueur_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button Btn_ChoisirLogo;
    }
}