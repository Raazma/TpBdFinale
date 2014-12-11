namespace bdfinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Main_menu = new System.Windows.Forms.MenuStrip();
            this.ajouterJoueurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joueursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierJoueurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutEquipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifEquipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.classementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_menu
            // 
            this.Main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterJoueurToolStripMenuItem});
            this.Main_menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.Main_menu.Location = new System.Drawing.Point(0, 0);
            this.Main_menu.Name = "Main_menu";
            this.Main_menu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.Main_menu.Size = new System.Drawing.Size(633, 28);
            this.Main_menu.TabIndex = 0;
            this.Main_menu.Text = "menuStrip1";
            // 
            // ajouterJoueurToolStripMenuItem
            // 
            this.ajouterJoueurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.affichageToolStripMenuItem});
            this.ajouterJoueurToolStripMenuItem.Name = "ajouterJoueurToolStripMenuItem";
            this.ajouterJoueurToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.ajouterJoueurToolStripMenuItem.Text = "AjouterJoueur";
            this.ajouterJoueurToolStripMenuItem.Click += new System.EventHandler(this.ajouterJoueurToolStripMenuItem_Click);
            // 
            // affichageToolStripMenuItem
            // 
            this.affichageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.joueursToolStripMenuItem,
            this.modifierJoueurToolStripMenuItem,
            this.matchToolStripMenuItem,
            this.ajoutEquipeToolStripMenuItem,
            this.modifEquipeToolStripMenuItem,
            this.classementToolStripMenuItem});
            this.affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            this.affichageToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.affichageToolStripMenuItem.Text = "Affichage";
            // 
            // joueursToolStripMenuItem
            // 
            this.joueursToolStripMenuItem.Name = "joueursToolStripMenuItem";
            this.joueursToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.joueursToolStripMenuItem.Text = "Joueurs...";
            this.joueursToolStripMenuItem.Click += new System.EventHandler(this.joueursToolStripMenuItem_Click);
            // 
            // modifierJoueurToolStripMenuItem
            // 
            this.modifierJoueurToolStripMenuItem.Name = "modifierJoueurToolStripMenuItem";
            this.modifierJoueurToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.modifierJoueurToolStripMenuItem.Text = "ModifierJoueur...";
            this.modifierJoueurToolStripMenuItem.Click += new System.EventHandler(this.modifierJoueurToolStripMenuItem_Click);
            // 
            // matchToolStripMenuItem
            // 
            this.matchToolStripMenuItem.Name = "matchToolStripMenuItem";
            this.matchToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.matchToolStripMenuItem.Text = "Match...";
            this.matchToolStripMenuItem.Click += new System.EventHandler(this.matchToolStripMenuItem_Click);
            // 
            // ajoutEquipeToolStripMenuItem
            // 
            this.ajoutEquipeToolStripMenuItem.Name = "ajoutEquipeToolStripMenuItem";
            this.ajoutEquipeToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.ajoutEquipeToolStripMenuItem.Text = "Ajout Equipe...";
            this.ajoutEquipeToolStripMenuItem.Click += new System.EventHandler(this.ajoutEquipeToolStripMenuItem_Click);
            // 
            // modifEquipeToolStripMenuItem
            // 
            this.modifEquipeToolStripMenuItem.Name = "modifEquipeToolStripMenuItem";
            this.modifEquipeToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.modifEquipeToolStripMenuItem.Text = "Modif Equipe...";
            this.modifEquipeToolStripMenuItem.Click += new System.EventHandler(this.modifEquipeToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "On doit trouver dequoi de beau a mettre ici une image on quelque chose debeau";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 251);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lien ver les autre form en panel ou quelque chose";
            // 
            // classementToolStripMenuItem
            // 
            this.classementToolStripMenuItem.Name = "classementToolStripMenuItem";
            this.classementToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.classementToolStripMenuItem.Text = "Classement...";
            this.classementToolStripMenuItem.Click += new System.EventHandler(this.classementToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 480);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Main_menu);
            this.MainMenuStrip = this.Main_menu;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Main_menu.ResumeLayout(false);
            this.Main_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Main_menu;
        private System.Windows.Forms.ToolStripMenuItem ajouterJoueurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem joueursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierJoueurToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem ajoutEquipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifEquipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classementToolStripMenuItem;
    }
}

