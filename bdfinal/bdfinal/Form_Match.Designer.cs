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
            this.Cb_NumMatch.Location = new System.Drawing.Point(47, 89);
            this.Cb_NumMatch.Name = "Cb_NumMatch";
            this.Cb_NumMatch.Size = new System.Drawing.Size(121, 21);
            this.Cb_NumMatch.TabIndex = 0;
            this.Cb_NumMatch.SelectedIndexChanged += new System.EventHandler(this.Cb_NumMatch_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de Match";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // Cb_Date
            // 
            this.Cb_Date.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Date.FormattingEnabled = true;
            this.Cb_Date.Location = new System.Drawing.Point(265, 89);
            this.Cb_Date.Name = "Cb_Date";
            this.Cb_Date.Size = new System.Drawing.Size(121, 21);
            this.Cb_Date.TabIndex = 3;
            this.Cb_Date.SelectedIndexChanged += new System.EventHandler(this.Cb_Date_SelectedIndexChanged);
            // 
            // DGV_Match
            // 
            this.DGV_Match.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Match.Location = new System.Drawing.Point(22, 140);
            this.DGV_Match.Name = "DGV_Match";
            this.DGV_Match.Size = new System.Drawing.Size(413, 62);
            this.DGV_Match.TabIndex = 4;
            // 
            // DGV_Joueurs
            // 
            this.DGV_Joueurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Joueurs.Location = new System.Drawing.Point(22, 273);
            this.DGV_Joueurs.Name = "DGV_Joueurs";
            this.DGV_Joueurs.Size = new System.Drawing.Size(425, 150);
            this.DGV_Joueurs.TabIndex = 5;
            // 
            // Form_Match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 435);
            this.Controls.Add(this.DGV_Joueurs);
            this.Controls.Add(this.DGV_Match);
            this.Controls.Add(this.Cb_Date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cb_NumMatch);
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