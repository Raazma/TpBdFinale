namespace bdfinal
{
    partial class Form_Ajout_equipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ajout_equipe));
            this.Tb_Ville = new System.Windows.Forms.TextBox();
            this.Tb_Nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ville = new System.Windows.Forms.Label();
            this.Cb_Division = new System.Windows.Forms.ComboBox();
            this.DTP_Intro = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_ChoisirLogo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tb_Ville
            // 
            this.Tb_Ville.Location = new System.Drawing.Point(289, 149);
            this.Tb_Ville.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tb_Ville.Name = "Tb_Ville";
            this.Tb_Ville.Size = new System.Drawing.Size(132, 22);
            this.Tb_Ville.TabIndex = 1;
            // 
            // Tb_Nom
            // 
            this.Tb_Nom.Location = new System.Drawing.Point(289, 213);
            this.Tb_Nom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tb_Nom.Name = "Tb_Nom";
            this.Tb_Nom.Size = new System.Drawing.Size(132, 22);
            this.Tb_Nom.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "NumDivision";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nom de L\'equipe";
            // 
            // Ville
            // 
            this.Ville.AutoSize = true;
            this.Ville.Location = new System.Drawing.Point(92, 158);
            this.Ville.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ville.Name = "Ville";
            this.Ville.Size = new System.Drawing.Size(34, 17);
            this.Ville.TabIndex = 7;
            this.Ville.Text = "Ville";
            // 
            // Cb_Division
            // 
            this.Cb_Division.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Division.FormattingEnabled = true;
            this.Cb_Division.Location = new System.Drawing.Point(277, 84);
            this.Cb_Division.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cb_Division.Name = "Cb_Division";
            this.Cb_Division.Size = new System.Drawing.Size(160, 24);
            this.Cb_Division.TabIndex = 11;
            // 
            // DTP_Intro
            // 
            this.DTP_Intro.Location = new System.Drawing.Point(220, 283);
            this.DTP_Intro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DTP_Intro.Name = "DTP_Intro";
            this.DTP_Intro.Size = new System.Drawing.Size(239, 22);
            this.DTP_Intro.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 290);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Date Introduction";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(575, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 166);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_ChoisirLogo
            // 
            this.Btn_ChoisirLogo.Location = new System.Drawing.Point(575, 247);
            this.Btn_ChoisirLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_ChoisirLogo.Name = "Btn_ChoisirLogo";
            this.Btn_ChoisirLogo.Size = new System.Drawing.Size(175, 28);
            this.Btn_ChoisirLogo.TabIndex = 15;
            this.Btn_ChoisirLogo.Text = "Choisir Logo";
            this.Btn_ChoisirLogo.UseVisualStyleBackColor = true;
            this.Btn_ChoisirLogo.Click += new System.EventHandler(this.Btn_ChoisirLogo_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 370);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 28);
            this.button2.TabIndex = 16;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_Ajout_equipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btn_ChoisirLogo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DTP_Intro);
            this.Controls.Add(this.Cb_Division);
            this.Controls.Add(this.Ville);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tb_Nom);
            this.Controls.Add(this.Tb_Ville);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Ajout_equipe";
            this.Text = "Form_Ajout_equipe";
            this.Load += new System.EventHandler(this.Form_Ajout_equipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tb_Ville;
        private System.Windows.Forms.TextBox Tb_Nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Ville;
        private System.Windows.Forms.ComboBox Cb_Division;
        private System.Windows.Forms.DateTimePicker DTP_Intro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_ChoisirLogo;
        private System.Windows.Forms.Button button2;
    }
}