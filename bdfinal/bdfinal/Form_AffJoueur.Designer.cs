namespace bdfinal
{
    partial class Form_AffJoueur
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
            this.Dgv_Joueurs = new System.Windows.Forms.DataGridView();
            this.Lb_Num = new System.Windows.Forms.Label();
            this.Lb_Nom = new System.Windows.Forms.Label();
            this.Lb_Prenom = new System.Windows.Forms.Label();
            this.Lb_Equipe = new System.Windows.Forms.Label();
            this.Lb_Stats = new System.Windows.Forms.Label();
            this.Lb_NbButs = new System.Windows.Forms.Label();
            this.Lb_Passes = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Joueurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Joueurs
            // 
            this.Dgv_Joueurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Joueurs.Location = new System.Drawing.Point(12, 12);
            this.Dgv_Joueurs.Name = "Dgv_Joueurs";
            this.Dgv_Joueurs.Size = new System.Drawing.Size(59, 41);
            this.Dgv_Joueurs.TabIndex = 0;
            // 
            // Lb_Num
            // 
            this.Lb_Num.AutoSize = true;
            this.Lb_Num.Location = new System.Drawing.Point(171, 154);
            this.Lb_Num.Name = "Lb_Num";
            this.Lb_Num.Size = new System.Drawing.Size(64, 13);
            this.Lb_Num.TabIndex = 1;
            this.Lb_Num.Text = "Num Joueur";
            // 
            // Lb_Nom
            // 
            this.Lb_Nom.AutoSize = true;
            this.Lb_Nom.Location = new System.Drawing.Point(195, 191);
            this.Lb_Nom.Name = "Lb_Nom";
            this.Lb_Nom.Size = new System.Drawing.Size(29, 13);
            this.Lb_Nom.TabIndex = 2;
            this.Lb_Nom.Text = "Nom";
            // 
            // Lb_Prenom
            // 
            this.Lb_Prenom.AutoSize = true;
            this.Lb_Prenom.Location = new System.Drawing.Point(192, 220);
            this.Lb_Prenom.Name = "Lb_Prenom";
            this.Lb_Prenom.Size = new System.Drawing.Size(43, 13);
            this.Lb_Prenom.TabIndex = 3;
            this.Lb_Prenom.Text = "Prenom";
            // 
            // Lb_Equipe
            // 
            this.Lb_Equipe.AutoSize = true;
            this.Lb_Equipe.Location = new System.Drawing.Point(195, 263);
            this.Lb_Equipe.Name = "Lb_Equipe";
            this.Lb_Equipe.Size = new System.Drawing.Size(40, 13);
            this.Lb_Equipe.TabIndex = 4;
            this.Lb_Equipe.Text = "Equipe";
            // 
            // Lb_Stats
            // 
            this.Lb_Stats.AutoSize = true;
            this.Lb_Stats.Location = new System.Drawing.Point(180, 300);
            this.Lb_Stats.Name = "Lb_Stats";
            this.Lb_Stats.Size = new System.Drawing.Size(44, 13);
            this.Lb_Stats.TabIndex = 5;
            this.Lb_Stats.Text = "Statistic";
            // 
            // Lb_NbButs
            // 
            this.Lb_NbButs.AutoSize = true;
            this.Lb_NbButs.Location = new System.Drawing.Point(119, 327);
            this.Lb_NbButs.Name = "Lb_NbButs";
            this.Lb_NbButs.Size = new System.Drawing.Size(73, 13);
            this.Lb_NbButs.TabIndex = 6;
            this.Lb_NbButs.Text = "Nombres Buts";
            // 
            // Lb_Passes
            // 
            this.Lb_Passes.AutoSize = true;
            this.Lb_Passes.Location = new System.Drawing.Point(220, 327);
            this.Lb_Passes.Name = "Lb_Passes";
            this.Lb_Passes.Size = new System.Drawing.Size(81, 13);
            this.Lb_Passes.TabIndex = 7;
            this.Lb_Passes.Text = "Nombre Passes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(291, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 111);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form_AffJoueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 378);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lb_Passes);
            this.Controls.Add(this.Lb_NbButs);
            this.Controls.Add(this.Lb_Stats);
            this.Controls.Add(this.Lb_Equipe);
            this.Controls.Add(this.Lb_Prenom);
            this.Controls.Add(this.Lb_Nom);
            this.Controls.Add(this.Lb_Num);
            this.Controls.Add(this.Dgv_Joueurs);
            this.Name = "Form_AffJoueur";
            this.Text = "Form_AffJoueur";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Joueurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Joueurs;
        private System.Windows.Forms.Label Lb_Num;
        private System.Windows.Forms.Label Lb_Nom;
        private System.Windows.Forms.Label Lb_Prenom;
        private System.Windows.Forms.Label Lb_Equipe;
        private System.Windows.Forms.Label Lb_Stats;
        private System.Windows.Forms.Label Lb_NbButs;
        private System.Windows.Forms.Label Lb_Passes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}