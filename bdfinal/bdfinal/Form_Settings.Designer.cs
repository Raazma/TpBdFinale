namespace bdfinal
{
    partial class Option
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Option));
            this.DGV_Demo = new System.Windows.Forms.DataGridView();
            this.PN_Head = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.FB_Apply = new FlashButton.FlashButton();
            this.FB_Cancel = new FlashButton.FlashButton();
            this.BT_Header_Color = new System.Windows.Forms.Button();
            this.BT_Impaire = new System.Windows.Forms.Button();
            this.BT_Paire = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_Text_Color = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Demo)).BeginInit();
            this.PN_Head.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Demo
            // 
            this.DGV_Demo.AllowUserToAddRows = false;
            this.DGV_Demo.AllowUserToDeleteRows = false;
            this.DGV_Demo.AllowUserToResizeRows = false;
            this.DGV_Demo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Demo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Demo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Demo.Location = new System.Drawing.Point(3, 3);
            this.DGV_Demo.Name = "DGV_Demo";
            this.DGV_Demo.RowTemplate.Height = 24;
            this.DGV_Demo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Demo.ShowCellErrors = false;
            this.DGV_Demo.ShowCellToolTips = false;
            this.DGV_Demo.ShowEditingIcon = false;
            this.DGV_Demo.ShowRowErrors = false;
            this.DGV_Demo.Size = new System.Drawing.Size(557, 316);
            this.DGV_Demo.TabIndex = 0;
            // 
            // PN_Head
            // 
            this.PN_Head.Controls.Add(this.BT_Text_Color);
            this.PN_Head.Controls.Add(this.label1);
            this.PN_Head.Controls.Add(this.BT_Header_Color);
            this.PN_Head.Dock = System.Windows.Forms.DockStyle.Top;
            this.PN_Head.Location = new System.Drawing.Point(0, 0);
            this.PN_Head.Name = "PN_Head";
            this.PN_Head.Size = new System.Drawing.Size(704, 103);
            this.PN_Head.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DGV_Demo, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 103);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(704, 322);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.BT_Paire, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.FB_Apply, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.FB_Cancel, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.BT_Impaire, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(566, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(135, 316);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // FB_Apply
            // 
            this.FB_Apply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FB_Apply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FB_Apply.ImageClick = global::bdfinal.Properties.Resources.ICON_Accepter_Click;
            this.FB_Apply.ImageDisable = global::bdfinal.Properties.Resources.ICON_Accepter_Disable;
            this.FB_Apply.ImageNeutral = global::bdfinal.Properties.Resources.ICON_Accepter_Neutral;
            this.FB_Apply.ImageOver = global::bdfinal.Properties.Resources.ICON_Accepter_Over;
            this.FB_Apply.Location = new System.Drawing.Point(4, 256);
            this.FB_Apply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FB_Apply.Name = "FB_Apply";
            this.FB_Apply.Size = new System.Drawing.Size(59, 56);
            this.FB_Apply.TabIndex = 0;
            this.FB_Apply.Click += new System.EventHandler(this.FB_Apply_Click);
            // 
            // FB_Cancel
            // 
            this.FB_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FB_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FB_Cancel.ImageClick = global::bdfinal.Properties.Resources.ICON_Annuler_Click;
            this.FB_Cancel.ImageDisable = global::bdfinal.Properties.Resources.ICON_Annuler_Disable;
            this.FB_Cancel.ImageNeutral = global::bdfinal.Properties.Resources.ICON_Annuler_Neutral;
            this.FB_Cancel.ImageOver = global::bdfinal.Properties.Resources.ICON_Annuler_Over;
            this.FB_Cancel.Location = new System.Drawing.Point(71, 256);
            this.FB_Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FB_Cancel.Name = "FB_Cancel";
            this.FB_Cancel.Size = new System.Drawing.Size(60, 56);
            this.FB_Cancel.TabIndex = 1;
            this.FB_Cancel.Click += new System.EventHandler(this.FB_Cancel_Click);
            // 
            // BT_Header_Color
            // 
            this.BT_Header_Color.Location = new System.Drawing.Point(393, 26);
            this.BT_Header_Color.Name = "BT_Header_Color";
            this.BT_Header_Color.Size = new System.Drawing.Size(137, 37);
            this.BT_Header_Color.TabIndex = 0;
            this.BT_Header_Color.Text = "Couleur Entête";
            this.BT_Header_Color.UseVisualStyleBackColor = true;
            this.BT_Header_Color.Click += new System.EventHandler(this.BT_Header_Color_Click);
            // 
            // BT_Impaire
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.BT_Impaire, 2);
            this.BT_Impaire.Dock = System.Windows.Forms.DockStyle.Top;
            this.BT_Impaire.Location = new System.Drawing.Point(3, 3);
            this.BT_Impaire.Name = "BT_Impaire";
            this.BT_Impaire.Size = new System.Drawing.Size(129, 43);
            this.BT_Impaire.TabIndex = 2;
            this.BT_Impaire.Text = "Couleur Ranger Impaire";
            this.BT_Impaire.UseVisualStyleBackColor = true;
            this.BT_Impaire.Click += new System.EventHandler(this.BT_Impaire_Click);
            // 
            // BT_Paire
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.BT_Paire, 2);
            this.BT_Paire.Dock = System.Windows.Forms.DockStyle.Top;
            this.BT_Paire.Location = new System.Drawing.Point(3, 129);
            this.BT_Paire.Name = "BT_Paire";
            this.BT_Paire.Size = new System.Drawing.Size(129, 43);
            this.BT_Paire.TabIndex = 3;
            this.BT_Paire.Text = "Couleur Ranger Paire";
            this.BT_Paire.UseVisualStyleBackColor = true;
            this.BT_Paire.Click += new System.EventHandler(this.BT_Paire_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Option";
            // 
            // BT_Text_Color
            // 
            this.BT_Text_Color.Location = new System.Drawing.Point(545, 26);
            this.BT_Text_Color.Name = "BT_Text_Color";
            this.BT_Text_Color.Size = new System.Drawing.Size(137, 37);
            this.BT_Text_Color.TabIndex = 2;
            this.BT_Text_Color.Text = "Couleur Texte";
            this.BT_Text_Color.UseVisualStyleBackColor = true;
            this.BT_Text_Color.Click += new System.EventHandler(this.BT_Text_Color_Click);
            // 
            // Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 425);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.PN_Head);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(722, 470);
            this.Name = "Option";
            this.Text = "Option";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Settings_FormClosing);
            this.Load += new System.EventHandler(this.Form_Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Demo)).EndInit();
            this.PN_Head.ResumeLayout(false);
            this.PN_Head.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Demo;
        private System.Windows.Forms.Panel PN_Head;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private FlashButton.FlashButton FB_Apply;
        private FlashButton.FlashButton FB_Cancel;
        private System.Windows.Forms.Button BT_Header_Color;
        private System.Windows.Forms.Button BT_Paire;
        private System.Windows.Forms.Button BT_Impaire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_Text_Color;
    }
}