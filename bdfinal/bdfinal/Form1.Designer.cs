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
            this.ajoutMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.flashButton8 = new FlashButton.FlashButton();
            this.flashButton7 = new FlashButton.FlashButton();
            this.flashButton6 = new FlashButton.FlashButton();
            this.flashButton5 = new FlashButton.FlashButton();
            this.flashButton4 = new FlashButton.FlashButton();
            this.flashButton2 = new FlashButton.FlashButton();
            this.flashButton3 = new FlashButton.FlashButton();
            this.flashButton1 = new FlashButton.FlashButton();
            this.FB_EditPlayer = new FlashButton.FlashButton();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(582, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(70, 24);
            this.toolStripMenuItem2.Text = "Joueurs";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.ajouterToolStripMenuItem.Text = "Ajouter...";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterJoueurToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.modifierToolStripMenuItem.Text = "Modifier...";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierJoueurToolStripMenuItem_Click);
            // 
            // équipeToolStripMenuItem
            // 
            this.équipeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem1,
            this.modifierToolStripMenuItem1});
            this.équipeToolStripMenuItem.Name = "équipeToolStripMenuItem";
            this.équipeToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.équipeToolStripMenuItem.Text = "Équipes";
            // 
            // ajouterToolStripMenuItem1
            // 
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(144, 24);
            this.ajouterToolStripMenuItem1.Text = "Ajouter...";
            this.ajouterToolStripMenuItem1.Click += new System.EventHandler(this.ajoutEquipeToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem1
            // 
            this.modifierToolStripMenuItem1.Name = "modifierToolStripMenuItem1";
            this.modifierToolStripMenuItem1.Size = new System.Drawing.Size(144, 24);
            this.modifierToolStripMenuItem1.Text = "Modifier...";
            this.modifierToolStripMenuItem1.Click += new System.EventHandler(this.modifEquipeToolStripMenuItem_Click);
            // 
            // divisionToolStripMenuItem
            // 
            this.divisionToolStripMenuItem.Name = "divisionToolStripMenuItem";
            this.divisionToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.divisionToolStripMenuItem.Text = "Divisions...";
            this.divisionToolStripMenuItem.Click += new System.EventHandler(this.ajoutDivisionToolStripMenuItem_Click);
            // 
            // partiesToolStripMenuItem
            // 
            this.partiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutFicheDeJoueurToolStripMenuItem,
            this.voirPartieToolStripMenuItem,
            this.ajoutMatchToolStripMenuItem});
            this.partiesToolStripMenuItem.Name = "partiesToolStripMenuItem";
            this.partiesToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.partiesToolStripMenuItem.Text = "Parties";
            // 
            // ajoutFicheDeJoueurToolStripMenuItem
            // 
            this.ajoutFicheDeJoueurToolStripMenuItem.Name = "ajoutFicheDeJoueurToolStripMenuItem";
            this.ajoutFicheDeJoueurToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.ajoutFicheDeJoueurToolStripMenuItem.Text = "Ajout Fiche de Joueur...";
            this.ajoutFicheDeJoueurToolStripMenuItem.Click += new System.EventHandler(this.ajoutFicheDeJoueurToolStripMenuItem_Click);
            // 
            // voirPartieToolStripMenuItem
            // 
            this.voirPartieToolStripMenuItem.Name = "voirPartieToolStripMenuItem";
            this.voirPartieToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.voirPartieToolStripMenuItem.Text = "Voir Partie...";
            this.voirPartieToolStripMenuItem.Click += new System.EventHandler(this.matchToolStripMenuItem_Click);
            // 
            // ajoutMatchToolStripMenuItem
            // 
            this.ajoutMatchToolStripMenuItem.Name = "ajoutMatchToolStripMenuItem";
            this.ajoutMatchToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.ajoutMatchToolStripMenuItem.Text = "Ajout match...";
            this.ajoutMatchToolStripMenuItem.Click += new System.EventHandler(this.ajoutMatchToolStripMenuItem_Click);
            // 
            // classementsToolStripMenuItem
            // 
            this.classementsToolStripMenuItem.Name = "classementsToolStripMenuItem";
            this.classementsToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.classementsToolStripMenuItem.Text = "Classements...";
            this.classementsToolStripMenuItem.Click += new System.EventHandler(this.classementToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flashButton1);
            this.groupBox1.Controls.Add(this.FB_EditPlayer);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 101);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Joueurs";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flashButton2);
            this.groupBox2.Controls.Add(this.flashButton3);
            this.groupBox2.Location = new System.Drawing.Point(184, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Équipes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flashButton4);
            this.groupBox3.Location = new System.Drawing.Point(390, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(134, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Classements";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.flashButton5);
            this.groupBox4.Location = new System.Drawing.Point(12, 138);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(115, 100);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Divisions";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.flashButton8);
            this.groupBox5.Controls.Add(this.flashButton7);
            this.groupBox5.Controls.Add(this.flashButton6);
            this.groupBox5.Location = new System.Drawing.Point(133, 138);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(266, 100);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Parties";
            // 
            // flashButton8
            // 
            this.flashButton8.BackgroundImage = global::bdfinal.Properties.Resources.View;
            this.flashButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flashButton8.ImageClick = global::bdfinal.Properties.Resources.View_ClickDisabled;
            this.flashButton8.ImageDisable = global::bdfinal.Properties.Resources.View_ClickDisabled;
            this.flashButton8.ImageNeutral = global::bdfinal.Properties.Resources.View;
            this.flashButton8.ImageOver = global::bdfinal.Properties.Resources.View_Hover;
            this.flashButton8.Location = new System.Drawing.Point(173, 22);
            this.flashButton8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flashButton8.Name = "flashButton8";
            this.flashButton8.Size = new System.Drawing.Size(75, 70);
            this.flashButton8.TabIndex = 6;
            // 
            // flashButton7
            // 
            this.flashButton7.BackgroundImage = global::bdfinal.Properties.Resources.Ajouter;
            this.flashButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flashButton7.ImageClick = global::bdfinal.Properties.Resources.Ajouter_ClickDisabled;
            this.flashButton7.ImageDisable = global::bdfinal.Properties.Resources.Ajouter_ClickDisabled;
            this.flashButton7.ImageNeutral = global::bdfinal.Properties.Resources.Ajouter;
            this.flashButton7.ImageOver = global::bdfinal.Properties.Resources.Ajouter_Hover;
            this.flashButton7.Location = new System.Drawing.Point(90, 22);
            this.flashButton7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flashButton7.Name = "flashButton7";
            this.flashButton7.Size = new System.Drawing.Size(75, 70);
            this.flashButton7.TabIndex = 5;
            // 
            // flashButton6
            // 
            this.flashButton6.BackgroundImage = global::bdfinal.Properties.Resources.Edit_Player_ProfileAdd_icon;
            this.flashButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flashButton6.ImageClick = global::bdfinal.Properties.Resources.Edit_Player_ProfileAdd_ClickDisabled_icon;
            this.flashButton6.ImageDisable = global::bdfinal.Properties.Resources.Edit_Player_ProfileAdd_ClickDisabled_icon;
            this.flashButton6.ImageNeutral = global::bdfinal.Properties.Resources.Edit_Player_ProfileAdd_icon;
            this.flashButton6.ImageOver = global::bdfinal.Properties.Resources.Edit_Player_ProfileAdd_Hover_icon;
            this.flashButton6.Location = new System.Drawing.Point(7, 22);
            this.flashButton6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flashButton6.Name = "flashButton6";
            this.flashButton6.Size = new System.Drawing.Size(75, 70);
            this.flashButton6.TabIndex = 3;
            // 
            // flashButton5
            // 
            this.flashButton5.BackgroundImage = global::bdfinal.Properties.Resources.Edit;
            this.flashButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flashButton5.ImageClick = global::bdfinal.Properties.Resources.Edit_ClickDisabled;
            this.flashButton5.ImageDisable = global::bdfinal.Properties.Resources.Edit_ClickDisabled;
            this.flashButton5.ImageNeutral = global::bdfinal.Properties.Resources.Edit;
            this.flashButton5.ImageOver = global::bdfinal.Properties.Resources.Edit_Hover;
            this.flashButton5.Location = new System.Drawing.Point(20, 22);
            this.flashButton5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flashButton5.Name = "flashButton5";
            this.flashButton5.Size = new System.Drawing.Size(75, 70);
            this.flashButton5.TabIndex = 6;
            // 
            // flashButton4
            // 
            this.flashButton4.BackgroundImage = global::bdfinal.Properties.Resources.Stat;
            this.flashButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flashButton4.ImageClick = global::bdfinal.Properties.Resources.Stat_ClickDisabled;
            this.flashButton4.ImageDisable = global::bdfinal.Properties.Resources.Stat_ClickDisabled;
            this.flashButton4.ImageNeutral = global::bdfinal.Properties.Resources.Stat;
            this.flashButton4.ImageOver = global::bdfinal.Properties.Resources.Stat_Hover;
            this.flashButton4.Location = new System.Drawing.Point(29, 21);
            this.flashButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flashButton4.Name = "flashButton4";
            this.flashButton4.Size = new System.Drawing.Size(75, 70);
            this.flashButton4.TabIndex = 5;
            // 
            // flashButton2
            // 
            this.flashButton2.BackgroundImage = global::bdfinal.Properties.Resources.Ajouter;
            this.flashButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flashButton2.ImageClick = global::bdfinal.Properties.Resources.Ajouter_ClickDisabled;
            this.flashButton2.ImageDisable = global::bdfinal.Properties.Resources.Ajouter_ClickDisabled;
            this.flashButton2.ImageNeutral = global::bdfinal.Properties.Resources.Ajouter;
            this.flashButton2.ImageOver = global::bdfinal.Properties.Resources.Ajouter_Hover;
            this.flashButton2.Location = new System.Drawing.Point(104, 21);
            this.flashButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flashButton2.Name = "flashButton2";
            this.flashButton2.Size = new System.Drawing.Size(75, 70);
            this.flashButton2.TabIndex = 4;
            // 
            // flashButton3
            // 
            this.flashButton3.BackgroundImage = global::bdfinal.Properties.Resources.Modifier;
            this.flashButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flashButton3.ImageClick = global::bdfinal.Properties.Resources.Modifier_ClickDisabled;
            this.flashButton3.ImageDisable = global::bdfinal.Properties.Resources.Modifier_ClickDisabled;
            this.flashButton3.ImageNeutral = global::bdfinal.Properties.Resources.Modifier;
            this.flashButton3.ImageOver = global::bdfinal.Properties.Resources.Modifier_Hover;
            this.flashButton3.Location = new System.Drawing.Point(21, 21);
            this.flashButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flashButton3.Name = "flashButton3";
            this.flashButton3.Size = new System.Drawing.Size(75, 70);
            this.flashButton3.TabIndex = 3;
            // 
            // flashButton1
            // 
            this.flashButton1.BackgroundImage = global::bdfinal.Properties.Resources.Edit_Player_ProfileAdd_icon;
            this.flashButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flashButton1.ImageClick = global::bdfinal.Properties.Resources.Edit_Player_ProfileAdd_ClickDisabled_icon;
            this.flashButton1.ImageDisable = global::bdfinal.Properties.Resources.Edit_Player_ProfileAdd_ClickDisabled_icon;
            this.flashButton1.ImageNeutral = global::bdfinal.Properties.Resources.Edit_Player_ProfileAdd_icon;
            this.flashButton1.ImageOver = global::bdfinal.Properties.Resources.Edit_Player_ProfileAdd_Hover_icon;
            this.flashButton1.Location = new System.Drawing.Point(90, 22);
            this.flashButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flashButton1.Name = "flashButton1";
            this.flashButton1.Size = new System.Drawing.Size(75, 70);
            this.flashButton1.TabIndex = 2;
            // 
            // FB_EditPlayer
            // 
            this.FB_EditPlayer.BackgroundImage = global::bdfinal.Properties.Resources.Edit_Player_Profile_icon;
            this.FB_EditPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_EditPlayer.ImageClick = global::bdfinal.Properties.Resources.Edit_Player_Profile_clickDisabled_icon;
            this.FB_EditPlayer.ImageDisable = global::bdfinal.Properties.Resources.Edit_Player_Profile_clickDisabled_icon;
            this.FB_EditPlayer.ImageNeutral = global::bdfinal.Properties.Resources.Edit_Player_Profile_icon;
            this.FB_EditPlayer.ImageOver = global::bdfinal.Properties.Resources.Edit_Player_Profile_Hover_icon;
            this.FB_EditPlayer.Location = new System.Drawing.Point(7, 22);
            this.FB_EditPlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FB_EditPlayer.Name = "FB_EditPlayer";
            this.FB_EditPlayer.Size = new System.Drawing.Size(75, 70);
            this.FB_EditPlayer.TabIndex = 1;
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = global::bdfinal.Properties.Resources.Option_Icon;
            this.toolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(28, 24);
            this.toolStripMenuItem3.Text = " ";
            this.toolStripMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = global::bdfinal.Properties.Resources.Info_Icon;
            this.toolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(25, 24);
            this.toolStripMenuItem4.Text = " ";
            this.toolStripMenuItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(582, 316);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
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
        private FlashButton.FlashButton FB_EditPlayer;
        private System.Windows.Forms.GroupBox groupBox1;
        private FlashButton.FlashButton flashButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem ajoutMatchToolStripMenuItem;
        private FlashButton.FlashButton flashButton2;
        private FlashButton.FlashButton flashButton3;
        private System.Windows.Forms.GroupBox groupBox3;
        private FlashButton.FlashButton flashButton4;
        private System.Windows.Forms.GroupBox groupBox4;
        private FlashButton.FlashButton flashButton5;
        private System.Windows.Forms.GroupBox groupBox5;
        private FlashButton.FlashButton flashButton7;
        private FlashButton.FlashButton flashButton6;
        private FlashButton.FlashButton flashButton8;
    }
}

