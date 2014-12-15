namespace bdfinal
{
    partial class Form_Ajout_Fiche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ajout_Fiche));
            this.Cb_Numatch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Nbut = new System.Windows.Forms.TextBox();
            this.Tb_nbpasse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Cb_Numjoueur = new System.Windows.Forms.ComboBox();
            this.Btn_cancel = new System.Windows.Forms.Button();
            this.Btn_Ajouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cb_Numatch
            // 
            this.Cb_Numatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Numatch.FormattingEnabled = true;
            this.Cb_Numatch.Location = new System.Drawing.Point(111, 45);
            this.Cb_Numatch.Name = "Cb_Numatch";
            this.Cb_Numatch.Size = new System.Drawing.Size(121, 21);
            this.Cb_Numatch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Num Match";
            // 
            // tb_Nbut
            // 
            this.tb_Nbut.Location = new System.Drawing.Point(140, 134);
            this.tb_Nbut.Name = "tb_Nbut";
            this.tb_Nbut.Size = new System.Drawing.Size(61, 20);
            this.tb_Nbut.TabIndex = 4;
            // 
            // Tb_nbpasse
            // 
            this.Tb_nbpasse.Location = new System.Drawing.Point(291, 134);
            this.Tb_nbpasse.Name = "Tb_nbpasse";
            this.Tb_nbpasse.Size = new System.Drawing.Size(79, 20);
            this.Tb_nbpasse.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Num joueur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nbpasse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nbbut";
            // 
            // Cb_Numjoueur
            // 
            this.Cb_Numjoueur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Numjoueur.FormattingEnabled = true;
            this.Cb_Numjoueur.Location = new System.Drawing.Point(123, 89);
            this.Cb_Numjoueur.Name = "Cb_Numjoueur";
            this.Cb_Numjoueur.Size = new System.Drawing.Size(121, 21);
            this.Cb_Numjoueur.TabIndex = 12;
            // 
            // Btn_cancel
            // 
            this.Btn_cancel.Location = new System.Drawing.Point(271, 178);
            this.Btn_cancel.Name = "Btn_cancel";
            this.Btn_cancel.Size = new System.Drawing.Size(75, 26);
            this.Btn_cancel.TabIndex = 13;
            this.Btn_cancel.Text = "Annuler";
            this.Btn_cancel.UseVisualStyleBackColor = true;
            // 
            // Btn_Ajouter
            // 
            this.Btn_Ajouter.Location = new System.Drawing.Point(157, 181);
            this.Btn_Ajouter.Name = "Btn_Ajouter";
            this.Btn_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ajouter.TabIndex = 14;
            this.Btn_Ajouter.Text = "Ajouter";
            this.Btn_Ajouter.UseVisualStyleBackColor = true;
            this.Btn_Ajouter.Click += new System.EventHandler(this.Btn_Ajouter_Click);
            // 
            // Form_Ajout_Fiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 238);
            this.Controls.Add(this.Btn_Ajouter);
            this.Controls.Add(this.Btn_cancel);
            this.Controls.Add(this.Cb_Numjoueur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tb_nbpasse);
            this.Controls.Add(this.tb_Nbut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cb_Numatch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Ajout_Fiche";
            this.Text = "Form_Ajout_Fiche";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cb_Numatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Nbut;
        private System.Windows.Forms.TextBox Tb_nbpasse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Cb_Numjoueur;
        private System.Windows.Forms.Button Btn_cancel;
        private System.Windows.Forms.Button Btn_Ajouter;

    }
}