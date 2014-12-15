using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace bdfinal
{
    public partial class Form_Modif_Joueur : Form
    {  
     OracleConnection orac = new OracleConnection();
    DataSet source = new DataSet();
        public Form_Modif_Joueur()
        {
            InitializeComponent();
        }
        public Form_Modif_Joueur(OracleConnection or)
        {
            InitializeComponent();
            orac = or;
            FilledBoxes();
            FilComboBox();
        }

        private void FilledBoxes()
        {
            try
            {
                string commande = "select * from joueurs";
                OracleDataAdapter adp = new OracleDataAdapter(commande, orac);
                adp.Fill(source, "ResJoueurs");
                Lb_Num.DataBindings.Add("text", source, "ResJoueurs.numjoueur");
                Tb_nom.DataBindings.Add("text", source, "ResJoueurs.nom");
                Tb_Prenom.DataBindings.Add("text", source, "ResJoueurs.prenom");
                Tb_NumChandail.DataBindings.Add("text", source, "ResJoueurs.NumeroMaillot");
                Tb_Position.DataBindings.Add("text", source, "ResJoueurs.Position");
                Dtp_Naissance.DataBindings.Add("Value", source, "ResJoueurs.DateNaissance");
                tb_Lien.DataBindings.Add("text", source, "ResJoueurs.photo");
                Pb_Logo.ImageLocation = tb_Lien.Text;
                this.Pb_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
           

        }
        private void FilComboBox()
        {
            try
            {
                string commande = "SELECT nomequipe from equipe";
                OracleCommand oraclecomm = new OracleCommand(commande, orac);
                oraclecomm.CommandType = CommandType.Text;
                OracleDataReader oraread = oraclecomm.ExecuteReader();
                while (oraread.Read())
                {
                    string ligne = oraread.GetString(0);
                    Cb_Equipe.Items.Add(ligne);
                }
                oraread.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void Btn_Suivant_Click(object sender, EventArgs e)
        {
            try
            {
                this.BindingContext[source, "ResJoueurs"].Position += 1;
                Pb_Logo.ImageLocation = tb_Lien.Text;
                this.Pb_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void Btn_Precedent_Click(object sender, EventArgs e)
        {
            try
            {
                this.BindingContext[source, "ResJoueurs"].Position -= 1;
                Pb_Logo.ImageLocation = tb_Lien.Text;
                this.Pb_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void Btn_Modifier_Click(object sender, EventArgs e)
        {
            try
            {
                string commande = "Update Joueurs SET nom = '" + Tb_nom.Text + "'" + ", prenom = '" + Tb_Prenom.Text + "'" + ", DateNaissance = :LaDate " + ",numeromaillot = '" +
                                 Tb_NumChandail.Text + "'" + " ,photo = '" + tb_Lien.Text + "',Position = '" + Tb_Position.Text + "'" + "where numjoueur = " + Lb_Num.Text;

                OracleCommand com = new OracleCommand(commande, orac);
                OracleParameter ladate = new OracleParameter(":LaDate", OracleDbType.Date);
                ladate.Value = Dtp_Naissance.Value;
                com.CommandType = CommandType.Text;
                com.Parameters.Add(ladate);
                int i = com.ExecuteNonQuery();
                MessageBox.Show(i.ToString() + " Ligne Modifier");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void Btn_Effacer_Click(object sender, EventArgs e)
        {

            try
            {
                string commande = "delete from joueurs where numjoueur = " + Lb_Num.Text;

                OracleCommand com = new OracleCommand(commande, orac);
                com.CommandType = CommandType.Text;
                int i = com.ExecuteNonQuery();
                MessageBox.Show(i.ToString() + " Ligne effacer");
            }

           
           
        }

        
       

        private void tb_Lien_TextChanged(object sender, EventArgs e)
        {
            Pb_Logo.ImageLocation = tb_Lien.Text;
            this.Pb_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
        } 
    }
}
