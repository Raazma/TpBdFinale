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
            this.DGV_Match = new System.Windows.Forms.DataGridView();
            this.DGV_Joueurs = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PN_Head = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Dtp_Match = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Match)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Joueurs)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.PN_Head.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cb_NumMatch
            // 
            this.Cb_NumMatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cb_NumMatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_NumMatch.FormattingEnabled = true;
            this.Cb_NumMatch.Location = new System.Drawing.Point(60, 47);
            this.Cb_NumMatch.Margin = new System.Windows.Forms.Padding(4);
            this.Cb_NumMatch.Name = "Cb_NumMatch";
            this.Cb_NumMatch.Size = new System.Drawing.Size(167, 24);
            this.Cb_NumMatch.TabIndex = 0;
            this.Cb_NumMatch.SelectedIndexChanged += new System.EventHandler(this.Cb_NumMatch_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de Match";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 43);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // DGV_Match
            // 
            this.DGV_Match.AllowUserToAddRows = false;
            this.DGV_Match.AllowUserToDeleteRows = false;
            this.DGV_Match.AllowUserToResizeRows = false;
            this.DGV_Match.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Match.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.DGV_Match, 5);
            this.DGV_Match.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Match.Location = new System.Drawing.Point(4, 94);
            this.DGV_Match.Margin = new System.Windows.Forms.Padding(4);
            this.DGV_Match.MultiSelect = false;
            this.DGV_Match.Name = "DGV_Match";
            this.DGV_Match.RowHeadersVisible = false;
            this.DGV_Match.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Match.ShowCellErrors = false;
            this.DGV_Match.ShowCellToolTips = false;
            this.DGV_Match.ShowEditingIcon = false;
            this.DGV_Match.ShowRowErrors = false;
            this.DGV_Match.Size = new System.Drawing.Size(501, 199);
            this.DGV_Match.TabIndex = 4;
            // 
            // DGV_Joueurs
            // 
            this.DGV_Joueurs.AllowUserToAddRows = false;
            this.DGV_Joueurs.AllowUserToDeleteRows = false;
            this.DGV_Joueurs.AllowUserToResizeRows = false;
            this.DGV_Joueurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Joueurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.DGV_Joueurs, 5);
            this.DGV_Joueurs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Joueurs.Location = new System.Drawing.Point(4, 323);
            this.DGV_Joueurs.Margin = new System.Windows.Forms.Padding(4);
            this.DGV_Joueurs.MultiSelect = false;
            this.DGV_Joueurs.Name = "DGV_Joueurs";
            this.DGV_Joueurs.RowHeadersVisible = false;
            this.DGV_Joueurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Joueurs.ShowCellErrors = false;
            this.DGV_Joueurs.ShowCellToolTips = false;
            this.DGV_Joueurs.ShowEditingIcon = false;
            this.DGV_Joueurs.ShowRowErrors = false;
            this.DGV_Joueurs.Size = new System.Drawing.Size(501, 199);
            this.DGV_Joueurs.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.tableLayoutPanel1.Controls.Add(this.PN_Head, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DGV_Match, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.DGV_Joueurs, 0, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.42036F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.42036F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.477833F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.42036F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.42036F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.42036F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.42036F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(509, 551);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // PN_Head
            // 
            this.PN_Head.BackColor = System.Drawing.Color.PowderBlue;
            this.tableLayoutPanel1.SetColumnSpan(this.PN_Head, 5);
            this.PN_Head.Controls.Add(this.tableLayoutPanel2);
            this.PN_Head.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PN_Head.Location = new System.Drawing.Point(3, 2);
            this.PN_Head.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PN_Head.Name = "PN_Head";
            this.tableLayoutPanel1.SetRowSpan(this.PN_Head, 5);
            this.PN_Head.Size = new System.Drawing.Size(503, 86);
            this.PN_Head.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.Cb_NumMatch, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Dtp_Match, 3, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(503, 86);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Dtp_Match
            // 
            this.Dtp_Match.Location = new System.Drawing.Point(302, 47);
            this.Dtp_Match.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_Match.Name = "Dtp_Match";
            this.Dtp_Match.Size = new System.Drawing.Size(139, 22);
            this.Dtp_Match.TabIndex = 3;
            this.Dtp_Match.ValueChanged += new System.EventHandler(this.Dtp_Match_ValueChanged);
            // 
            // Form_Match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 551);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(525, 582);
            this.Name = "Form_Match";
            this.Text = "Affichage des Parties";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Match_FormClosing);
            this.Load += new System.EventHandler(this.Form_Match_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Match)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Joueurs)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.PN_Head.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Cb_NumMatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGV_Match;
        private System.Windows.Forms.DataGridView DGV_Joueurs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel PN_Head;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DateTimePicker Dtp_Match;
    }
}