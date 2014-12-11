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
using System.IO;

namespace bdfinal
{
    public partial class Form_Ajout_equipe : Form
    {
        OracleConnection orac = new OracleConnection();
        public Form_Ajout_equipe()
        {
            InitializeComponent();
        }
        public Form_Ajout_equipe(  OracleConnection oracc)
        {
            InitializeComponent();
            orac = oracc;
            FilledComboBox();
           
        }

        private void FilledComboBox()
        {
            string commande = "SELECT NOM FROM division";
            OracleCommand oraclecomm = new OracleCommand(commande, orac);
            oraclecomm.CommandType = CommandType.Text;
            OracleDataReader oraread = oraclecomm.ExecuteReader();
            while (oraread.Read())
            {
                string ligne = oraread.GetString(0);
                Cb_Division.Items.Add(ligne);
            }
            oraread.Close();             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Cb_Division.SelectedItem != null)
            {

                string commande = "insert into  equipe( NumDivision ,DateIntroduction,Ville,NomEquipe) Values((select numdivision from equipe where nom equipe = :NumDiv ), :Date , :Ville , :nom)";
                OracleCommand orcom = new OracleCommand(commande, orac);

                OracleParameter Numdiv = new OracleParameter(":NumDiv", OracleDbType.Int32);
                OracleParameter Date = new OracleParameter(":Date", OracleDbType.Date);
                OracleParameter Ville = new OracleParameter(":Ville", OracleDbType.Varchar2, 30);
                OracleParameter Nom = new OracleParameter(":nom", OracleDbType.Varchar2, 20);


                Numdiv.Value = Cb_Division.SelectedItem.ToString();
                Date.Value = DTP_Intro.Value;
                Ville.Value = Tb_Ville.Text;
                Nom.Value = Tb_Nom.Text;
                orcom.Parameters.Add(Numdiv);
                orcom.Parameters.Add(Ville);
                orcom.Parameters.Add(Nom);

                int laligne = orcom.ExecuteNonQuery();

                MessageBox.Show(laligne.ToString());
              
            }

        }
        private void Form_Ajout_equipe_Load(object sender, EventArgs e)
        {

        }
    }
}
