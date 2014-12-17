namespace bdfinal
{
    partial class Form_Classement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Classement));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Division = new System.Windows.Forms.ComboBox();
            this.LB_Division = new System.Windows.Forms.Label();
            this.CB_Classement = new System.Windows.Forms.ComboBox();
            this.DGV_Classement = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Classement)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 100);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.39024F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.21952F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.39025F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CB_Division, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.LB_Division, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.CB_Classement, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.50495F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.990099F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.50495F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(856, 100);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(85, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Afficher :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CB_Division
            // 
            this.CB_Division.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CB_Division.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Division.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_Division.FormattingEnabled = true;
            this.CB_Division.Location = new System.Drawing.Point(587, 37);
            this.CB_Division.Name = "CB_Division";
            this.CB_Division.Size = new System.Drawing.Size(182, 24);
            this.CB_Division.TabIndex = 1;
            this.CB_Division.SelectedIndexChanged += new System.EventHandler(this.CB_Division_SelectedIndexChanged);
            // 
            // LB_Division
            // 
            this.LB_Division.AutoSize = true;
            this.LB_Division.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_Division.Location = new System.Drawing.Point(516, 34);
            this.LB_Division.Name = "LB_Division";
            this.LB_Division.Size = new System.Drawing.Size(65, 30);
            this.LB_Division.TabIndex = 3;
            this.LB_Division.Text = "Division :";
            this.LB_Division.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CB_Classement
            // 
            this.CB_Classement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CB_Classement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Classement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_Classement.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Classement.FormattingEnabled = true;
            this.CB_Classement.Items.AddRange(new object[] {
            "Équipes",
            "Joueurs",
            "3 Meilleurs"});
            this.CB_Classement.Location = new System.Drawing.Point(155, 37);
            this.CB_Classement.MaxDropDownItems = 2;
            this.CB_Classement.Name = "CB_Classement";
            this.CB_Classement.Size = new System.Drawing.Size(182, 24);
            this.CB_Classement.TabIndex = 0;
            this.CB_Classement.SelectedIndexChanged += new System.EventHandler(this.CB_Classement_SelectedIndexChanged);
            // 
            // DGV_Classement
            // 
            this.DGV_Classement.AllowUserToAddRows = false;
            this.DGV_Classement.AllowUserToDeleteRows = false;
            this.DGV_Classement.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.DGV_Classement.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Classement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Classement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Classement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Classement.Location = new System.Drawing.Point(0, 100);
            this.DGV_Classement.MultiSelect = false;
            this.DGV_Classement.Name = "DGV_Classement";
            this.DGV_Classement.ReadOnly = true;
            this.DGV_Classement.RowHeadersVisible = false;
            this.DGV_Classement.RowTemplate.Height = 24;
            this.DGV_Classement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Classement.ShowCellErrors = false;
            this.DGV_Classement.ShowCellToolTips = false;
            this.DGV_Classement.ShowEditingIcon = false;
            this.DGV_Classement.ShowRowErrors = false;
            this.DGV_Classement.Size = new System.Drawing.Size(856, 398);
            this.DGV_Classement.TabIndex = 1;
            // 
            // Form_Classement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 498);
            this.Controls.Add(this.DGV_Classement);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Classement";
            this.Text = "Classements";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Classement_FormClosing);
            this.Load += new System.EventHandler(this.Form_Classement_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Classement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CB_Classement;
        private System.Windows.Forms.DataGridView DGV_Classement;
        private System.Windows.Forms.ComboBox CB_Division;
        private System.Windows.Forms.Label LB_Division;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}