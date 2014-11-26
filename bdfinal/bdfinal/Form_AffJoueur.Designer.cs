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
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Joueurs)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Joueurs
            // 
            this.Dgv_Joueurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Joueurs.Location = new System.Drawing.Point(12, 12);
            this.Dgv_Joueurs.Name = "Dgv_Joueurs";
            this.Dgv_Joueurs.Size = new System.Drawing.Size(320, 185);
            this.Dgv_Joueurs.TabIndex = 0;
            // 
            // Form_AffJoueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 378);
            this.Controls.Add(this.Dgv_Joueurs);
            this.Name = "Form_AffJoueur";
            this.Text = "Form_AffJoueur";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Joueurs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Joueurs;
    }
}