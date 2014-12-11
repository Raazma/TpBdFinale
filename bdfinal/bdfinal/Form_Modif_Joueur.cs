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

            string commande = "select * from joueurs";
            OracleDataAdapter adp = new OracleDataAdapter(commande, orac);
            adp.Fill(source, "ResJoueurs");

            Lb_Num.DataBindings.Add("text", source, "ResJoueurs.numjoueur");
            Tb_nom.DataBindings.Add("text", source, "ResJoueurs.nom");
            Tb_Prenom.DataBindings.Add("text", source, "ResJoueurs.prenom");
            Tb_NumChandail.DataBindings.Add("text", source, "ResJoueurs.NumeroMaillot");
            Tb_Position.DataBindings.Add("text", source, "ResJoueurs.Position");
           
        }
        private void FilComboBox()
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

     
    }
}
