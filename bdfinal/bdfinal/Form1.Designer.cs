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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.équipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.divisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutFicheDeJoueurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirPartieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.équipeToolStripMenuItem,
            this.divisionToolStripMenuItem,
            this.partiesToolStripMenuItem,
            this.classementsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(59, 20);
            this.toolStripMenuItem2.Text = "Joueurs";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter...";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterJoueurToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.modifierToolStripMenuItem.Text = "Modifier...";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierJoueurToolStripMenuItem_Click);
            // 
            // équipeToolStripMenuItem
            // 
            this.équipeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem1,
            this.modifierToolStripMenuItem1});
            this.équipeToolStripMenuItem.Name = "équipeToolStripMenuItem";
            this.équipeToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.équipeToolStripMenuItem.Text = "Équipes";
            // 
            // ajouterToolStripMenuItem1
            // 
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.ajouterToolStripMenuItem1.Text = "Ajouter...";
            this.ajouterToolStripMenuItem1.Click += new System.EventHandler(this.ajoutEquipeToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem1
            // 
            this.modifierToolStripMenuItem1.Name = "modifierToolStripMenuItem1";
            this.modifierToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.modifierToolStripMenuItem1.Text = "Modifier...";
            this.modifierToolStripMenuItem1.Click += new System.EventHandler(this.modifEquipeToolStripMenuItem_Click);
            // 
            // divisionToolStripMenuItem
            // 
            this.divisionToolStripMenuItem.Name = "divisionToolStripMenuItem";
            this.divisionToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.divisionToolStripMenuItem.Text = "Divisions...";
            this.divisionToolStripMenuItem.Click += new System.EventHandler(this.ajoutDivisionToolStripMenuItem_Click);
            // 
            // partiesToolStripMenuItem
            // 
            this.partiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutFicheDeJoueurToolStripMenuItem,
            this.voirPartieToolStripMenuItem});
            this.partiesToolStripMenuItem.Name = "partiesToolStripMenuItem";
            this.partiesToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.partiesToolStripMenuItem.Text = "Parties";
            // 
            // ajoutFicheDeJoueurToolStripMenuItem
            // 
            this.ajoutFicheDeJoueurToolStripMenuItem.Name = "ajoutFicheDeJoueurToolStripMenuItem";
            this.ajoutFicheDeJoueurToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.ajoutFicheDeJoueurToolStripMenuItem.Text = "Ajout Fiche de Joueur...";
            this.ajoutFicheDeJoueurToolStripMenuItem.Click += new System.EventHandler(this.ajoutFicheDeJoueurToolStripMenuItem_Click);
            // 
            // voirPartieToolStripMenuItem
            // 
            this.voirPartieToolStripMenuItem.Name = "voirPartieToolStripMenuItem";
            this.voirPartieToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.voirPartieToolStripMenuItem.Text = "Voir Partie...";
            this.voirPartieToolStripMenuItem.Click += new System.EventHandler(this.matchToolStripMenuItem_Click);
            // 
            // classementsToolStripMenuItem
            // 
            this.classementsToolStripMenuItem.Name = "classementsToolStripMenuItem";
            this.classementsToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.classementsToolStripMenuItem.Text = "Classements...";
            this.classementsToolStripMenuItem.Click += new System.EventHandler(this.classementToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = global::bdfinal.Properties.Resources.Option_Icon;
            this.toolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(28, 20);
            this.toolStripMenuItem3.Text = " ";
            this.toolStripMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = global::bdfinal.Properties.Resources.Info_Icon;
            this.toolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem4.Text = " ";
            this.toolStripMenuItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(582, 316);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem ajoutJoueurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutDivisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem équipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem divisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutFicheDeJoueurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirPartieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
    }
}

