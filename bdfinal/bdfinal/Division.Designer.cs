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
            this.SuspendLayout();
            // 
            // Tb_Nom
            // 
            this.Tb_Nom.Location = new System.Drawing.Point(122, 49);
            this.Tb_Nom.Name = "Tb_Nom";
            this.Tb_Nom.Size = new System.Drawing.Size(135, 20);
            this.Tb_Nom.TabIndex = 0;
            // 
            // Dtp_Date
            // 
            this.Dtp_Date.Location = new System.Drawing.Point(122, 119);
            this.Dtp_Date.Name = "Dtp_Date";
            this.Dtp_Date.Size = new System.Drawing.Size(161, 20);
            this.Dtp_Date.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom de la Division";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "date introduction";
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(235, 277);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 4;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // Btn_Enregister
            // 
            this.Btn_Enregister.Location = new System.Drawing.Point(16, 277);
            this.Btn_Enregister.Name = "Btn_Enregister";
            this.Btn_Enregister.Size = new System.Drawing.Size(75, 23);
            this.Btn_Enregister.TabIndex = 5;
            this.Btn_Enregister.Text = "Enregistrer";
            this.Btn_Enregister.UseVisualStyleBackColor = true;
            this.Btn_Enregister.Click += new System.EventHandler(this.Btn_Enregister_Click);
            // 
            // Btn_Modifier
            // 
            this.Btn_Modifier.Location = new System.Drawing.Point(122, 277);
            this.Btn_Modifier.Name = "Btn_Modifier";
            this.Btn_Modifier.Size = new System.Drawing.Size(75, 23);
            this.Btn_Modifier.TabIndex = 6;
            this.Btn_Modifier.Text = " Modifier";
            this.Btn_Modifier.UseVisualStyleBackColor = true;
            // 
            // btn_Nouveau
            // 
            this.btn_Nouveau.Location = new System.Drawing.Point(16, 228);
            this.btn_Nouveau.Name = "btn_Nouveau";
            this.btn_Nouveau.Size = new System.Drawing.Size(75, 23);
            this.btn_Nouveau.TabIndex = 7;
            this.btn_Nouveau.Text = "Nouveau";
            this.btn_Nouveau.UseVisualStyleBackColor = true;
            this.btn_Nouveau.Click += new System.EventHandler(this.btn_Nouveau_Click);
            // 
            // Btn_Precedent
            // 
            this.Btn_Precedent.Location = new System.Drawing.Point(112, 199);
            this.Btn_Precedent.Name = "Btn_Precedent";
            this.Btn_Precedent.Size = new System.Drawing.Size(75, 23);
            this.Btn_Precedent.TabIndex = 8;
            this.Btn_Precedent.Text = "Precedent";
            this.Btn_Precedent.UseVisualStyleBackColor = true;
            this.Btn_Precedent.Click += new System.EventHandler(this.Btn_Precedent_Click);
            // 
            // Btn_Suivant
            // 
            this.Btn_Suivant.Location = new System.Drawing.Point(207, 199);
            this.Btn_Suivant.Name = "Btn_Suivant";
            this.Btn_Suivant.Size = new System.Drawing.Size(75, 23);
            this.Btn_Suivant.TabIndex = 9;
            this.Btn_Suivant.Text = "Suivant";
            this.Btn_Suivant.UseVisualStyleBackColor = true;
            this.Btn_Suivant.Click += new System.EventHandler(this.Btn_Suivant_Click);
            // 
            // Division
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 312);
            this.Controls.Add(this.Btn_Suivant);
            this.Controls.Add(this.Btn_Precedent);
            this.Controls.Add(this.btn_Nouveau);
            this.Controls.Add(this.Btn_Modifier);
            this.Controls.Add(this.Btn_Enregister);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dtp_Date);
            this.Controls.Add(this.Tb_Nom);
            this.Name = "Division";
            this.Text = "Division";
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
    }
}