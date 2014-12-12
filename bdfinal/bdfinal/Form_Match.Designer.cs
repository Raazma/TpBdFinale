namespace bdfinal
{
    partial class Form_Match
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Match));
            this.Cb_NumMatch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cb_Date = new System.Windows.Forms.ComboBox();
            this.DGV_Match = new System.Windows.Forms.DataGridView();
            this.DGV_Joueurs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Match)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Joueurs)).BeginInit();
            this.SuspendLayout();
            // 
            // Cb_NumMatch
            // 
            this.Cb_NumMatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_NumMatch.FormattingEnabled = true;
            this.Cb_NumMatch.Location = new System.Drawing.Point(63, 110);
            this.Cb_NumMatch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cb_NumMatch.Name = "Cb_NumMatch";
            this.Cb_NumMatch.Size = new System.Drawing.Size(160, 24);
            this.Cb_NumMatch.TabIndex = 0;
            this.Cb_NumMatch.SelectedIndexChanged += new System.EventHandler(this.Cb_NumMatch_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de Match";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // Cb_Date
            // 
            this.Cb_Date.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Date.FormattingEnabled = true;
            this.Cb_Date.Location = new System.Drawing.Point(353, 110);
            this.Cb_Date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cb_Date.Name = "Cb_Date";
            this.Cb_Date.Size = new System.Drawing.Size(160, 24);
            this.Cb_Date.TabIndex = 3;
            this.Cb_Date.SelectedIndexChanged += new System.EventHandler(this.Cb_Date_SelectedIndexChanged);
            // 
            // DGV_Match
            // 
            this.DGV_Match.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Match.Location = new System.Drawing.Point(29, 172);
            this.DGV_Match.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGV_Match.Name = "DGV_Match";
            this.DGV_Match.Size = new System.Drawing.Size(551, 76);
            this.DGV_Match.TabIndex = 4;
            // 
            // DGV_Joueurs
            // 
            this.DGV_Joueurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Joueurs.Location = new System.Drawing.Point(29, 336);
            this.DGV_Joueurs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGV_Joueurs.Name = "DGV_Joueurs";
            this.DGV_Joueurs.Size = new System.Drawing.Size(567, 185);
            this.DGV_Joueurs.TabIndex = 5;
            // 
            // Form_Match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 535);
            this.Controls.Add(this.DGV_Joueurs);
            this.Controls.Add(this.DGV_Match);
            this.Controls.Add(this.Cb_Date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cb_NumMatch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Match";
            this.Text = "Form_Match";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Match)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Joueurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cb_NumMatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cb_Date;
        private System.Windows.Forms.DataGridView DGV_Match;
        private System.Windows.Forms.DataGridView DGV_Joueurs;
    }
}