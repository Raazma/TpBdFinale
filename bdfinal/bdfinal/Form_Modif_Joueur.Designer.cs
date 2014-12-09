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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Cb_Equipe = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tb_nom
            // 
            this.Tb_nom.Location = new System.Drawing.Point(118, 126);
            this.Tb_nom.Name = "Tb_nom";
            this.Tb_nom.Size = new System.Drawing.Size(100, 20);
            this.Tb_nom.TabIndex = 1;
            // 
            // Tb_Prenom
            // 
            this.Tb_Prenom.Location = new System.Drawing.Point(118, 180);
            this.Tb_Prenom.Name = "Tb_Prenom";
            this.Tb_Prenom.Size = new System.Drawing.Size(100, 20);
            this.Tb_Prenom.TabIndex = 2;
            // 
            // Tb_NumChandail
            // 
            this.Tb_NumChandail.Location = new System.Drawing.Point(118, 228);
            this.Tb_NumChandail.Name = "Tb_NumChandail";
            this.Tb_NumChandail.Size = new System.Drawing.Size(100, 20);
            this.Tb_NumChandail.TabIndex = 3;
            // 
            // Tb_Position
            // 
            this.Tb_Position.Location = new System.Drawing.Point(118, 281);
            this.Tb_Position.Name = "Tb_Position";
            this.Tb_Position.Size = new System.Drawing.Size(100, 20);
            this.Tb_Position.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Num Joueur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Num Chandail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Position";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nom equipe";
            // 
            // Lb_Num
            // 
            this.Lb_Num.AutoSize = true;
            this.Lb_Num.Location = new System.Drawing.Point(144, 50);
            this.Lb_Num.Name = "Lb_Num";
            this.Lb_Num.Size = new System.Drawing.Size(35, 13);
            this.Lb_Num.TabIndex = 12;
            this.Lb_Num.Text = "label7";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(381, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 113);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Cb_Equipe
            // 
            this.Cb_Equipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Equipe.FormattingEnabled = true;
            this.Cb_Equipe.Location = new System.Drawing.Point(111, 87);
            this.Cb_Equipe.Name = "Cb_Equipe";
            this.Cb_Equipe.Size = new System.Drawing.Size(107, 21);
            this.Cb_Equipe.TabIndex = 15;
            // 
            // Form_Modif_Joueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 403);
            this.Controls.Add(this.Cb_Equipe);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lb_Num);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tb_Position);
            this.Controls.Add(this.Tb_NumChandail);
            this.Controls.Add(this.Tb_Prenom);
            this.Controls.Add(this.Tb_nom);
            this.Name = "Form_Modif_Joueur";
            this.Text = "Form_Modif_Joueur";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox Cb_Equipe;
    }
}