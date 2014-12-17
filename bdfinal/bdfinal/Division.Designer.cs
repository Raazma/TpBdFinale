namespace bdfinal
{
    partial class Division
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Division));
            this.Tb_Nom = new System.Windows.Forms.TextBox();
            this.Dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_Enregister = new System.Windows.Forms.Button();
            this.Btn_Modifier = new System.Windows.Forms.Button();
            this.btn_Nouveau = new System.Windows.Forms.Button();
            this.Btn_Precedent = new System.Windows.Forms.Button();
            this.Btn_Suivant = new System.Windows.Forms.Button();
            this.Lb_num = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BT_Supprimer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tb_Nom
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Tb_Nom, 2);
            this.Tb_Nom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tb_Nom.Location = new System.Drawing.Point(192, 34);
            this.Tb_Nom.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Nom.Name = "Tb_Nom";
            this.Tb_Nom.Size = new System.Drawing.Size(141, 22);
            this.Tb_Nom.TabIndex = 1;
            // 
            // Dtp_Date
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Dtp_Date, 2);
            this.Dtp_Date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dtp_Date.Location = new System.Drawing.Point(192, 94);
            this.Dtp_Date.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_Date.Name = "Dtp_Date";
            this.Dtp_Date.Size = new System.Drawing.Size(141, 22);
            this.Dtp_Date.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(44, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de la Division :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(44, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date introduction :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(341, 220);
            this.Btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(100, 28);
            this.Btn_Cancel.TabIndex = 9;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_Enregister
            // 
            this.Btn_Enregister.Location = new System.Drawing.Point(44, 220);
            this.Btn_Enregister.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Enregister.Name = "Btn_Enregister";
            this.Btn_Enregister.Size = new System.Drawing.Size(100, 28);
            this.Btn_Enregister.TabIndex = 7;
            this.Btn_Enregister.Text = "Enregistrer";
            this.Btn_Enregister.UseVisualStyleBackColor = true;
            this.Btn_Enregister.Click += new System.EventHandler(this.Btn_Enregister_Click);
            // 
            // Btn_Modifier
            // 
            this.Btn_Modifier.Location = new System.Drawing.Point(192, 220);
            this.Btn_Modifier.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Modifier.Name = "Btn_Modifier";
            this.Btn_Modifier.Size = new System.Drawing.Size(100, 28);
            this.Btn_Modifier.TabIndex = 8;
            this.Btn_Modifier.Text = " Modifier";
            this.Btn_Modifier.UseVisualStyleBackColor = true;
            this.Btn_Modifier.Click += new System.EventHandler(this.Btn_Modifier_Click);
            // 
            // btn_Nouveau
            // 
            this.btn_Nouveau.Location = new System.Drawing.Point(44, 154);
            this.btn_Nouveau.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Nouveau.Name = "btn_Nouveau";
            this.btn_Nouveau.Size = new System.Drawing.Size(100, 28);
            this.btn_Nouveau.TabIndex = 4;
            this.btn_Nouveau.Text = "Nouveau";
            this.btn_Nouveau.UseVisualStyleBackColor = true;
            this.btn_Nouveau.Click += new System.EventHandler(this.btn_Nouveau_Click);
            // 
            // Btn_Precedent
            // 
            this.Btn_Precedent.Location = new System.Drawing.Point(192, 154);
            this.Btn_Precedent.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Precedent.Name = "Btn_Precedent";
            this.Btn_Precedent.Size = new System.Drawing.Size(100, 28);
            this.Btn_Precedent.TabIndex = 5;
            this.Btn_Precedent.Text = "Precedent";
            this.Btn_Precedent.UseVisualStyleBackColor = true;
            this.Btn_Precedent.Click += new System.EventHandler(this.Btn_Precedent_Click);
            // 
            // Btn_Suivant
            // 
            this.Btn_Suivant.Location = new System.Drawing.Point(341, 154);
            this.Btn_Suivant.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Suivant.Name = "Btn_Suivant";
            this.Btn_Suivant.Size = new System.Drawing.Size(100, 28);
            this.Btn_Suivant.TabIndex = 6;
            this.Btn_Suivant.Text = "Suivant";
            this.Btn_Suivant.UseVisualStyleBackColor = true;
            this.Btn_Suivant.Click += new System.EventHandler(this.Btn_Suivant_Click);
            // 
            // Lb_num
            // 
            this.Lb_num.AutoSize = true;
            this.Lb_num.Enabled = false;
            this.Lb_num.Location = new System.Drawing.Point(36, 245);
            this.Lb_num.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_num.Name = "Lb_num";
            this.Lb_num.Size = new System.Drawing.Size(0, 17);
            this.Lb_num.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Cancel, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Modifier, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Suivant, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Enregister, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Precedent, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.btn_Nouveau, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.Tb_Nom, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Dtp_Date, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.BT_Supprimer, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.label3, 6, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(488, 350);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BT_Supprimer
            // 
            this.BT_Supprimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BT_Supprimer.Location = new System.Drawing.Point(191, 284);
            this.BT_Supprimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_Supprimer.Name = "BT_Supprimer";
            this.BT_Supprimer.Size = new System.Drawing.Size(103, 28);
            this.BT_Supprimer.TabIndex = 10;
            this.BT_Supprimer.Text = "Supprimer";
            this.BT_Supprimer.UseVisualStyleBackColor = true;
            this.BT_Supprimer.Click += new System.EventHandler(this.BT_Supprimer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 11;
            // 
            // Division
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 350);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Lb_num);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(503, 386);
            this.Name = "Division";
            this.Text = "Édition de Division";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Division_FormClosing);
            this.Load += new System.EventHandler(this.Division_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tb_Nom;
        private System.Windows.Forms.DateTimePicker Dtp_Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_Enregister;
        private System.Windows.Forms.Button Btn_Modifier;
        private System.Windows.Forms.Button btn_Nouveau;
        private System.Windows.Forms.Button Btn_Precedent;
        private System.Windows.Forms.Button Btn_Suivant;
        private System.Windows.Forms.Label Lb_num;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BT_Supprimer;
        private System.Windows.Forms.Label label3;
    }
}