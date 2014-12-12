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
    public partial class Form_Match : Form
    {
        OracleConnection orac = new OracleConnection();
        public Form_Match()
        {
            InitializeComponent();
        }
        public Form_Match(OracleConnection orc)
        {
            InitializeComponent();
            orac = orc;
            Combo_box();
        }

        private void Combo_box()
        {
            string commande = "select nummatch from match";
            OracleCommand oraclecomm = new OracleCommand(commande, orac);
            oraclecomm.CommandType = CommandType.Text;
            OracleDataReader oraread = oraclecomm.ExecuteReader();
            while (oraread.Read())
            {
               int ligne = oraread.GetInt32(0);
                Cb_NumMatch.Items.Add(ligne.ToString());
            }
            oraread.Close();

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            commande = "select DATEHEURE from match";
            try
            {
                OracleCommand oraclecom = new OracleCommand(commande, orac);
                oraclecom.CommandType = CommandType.Text;
                OracleDataReader orareadd = oraclecom.ExecuteReader();
                while (orareadd.Read())
                {
                    DateTime ligne = DateTime.Parse(orareadd.GetDateTime(0).ToShortDateString());
                    Cb_Date.Items.Add(ligne);
                }
                orareadd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }        
        }

        private void Cb_Date_SelectedIndexChanged(object sender, EventArgs e)
        {
            string commande = "select * from match where Dateheure = ' " + Convert.ToDateTime(Cb_Date.SelectedItem.ToString()).ToShortDateString() +"'"; // where DateHeure = '" + Cb_Date.SelectedItem.ToString() + "'";

           
            OracleDataAdapter adap = new OracleDataAdapter(commande, orac);
             
            DataSet Mels= new DataSet();
            adap.Fill(Mels, "ResMatch");
            BindingSource TheSOUSSE = new BindingSource(Mels, "Resmatch");
           DGV_Match.DataSource = TheSOUSSE;
        }


        private void Cb_NumMatch_SelectedIndexChanged(object sender, EventArgs e)
        {          
            string commande = "select *  from joueurs where numjoueur in (select numjoueur from FICHEMATCHJOUEUR where nummatch =" + Cb_NumMatch.SelectedItem.ToString() + ")";
            OracleDataAdapter adap = new OracleDataAdapter(commande, orac);
            DataSet Mels = new DataSet();
            adap.Fill(Mels, "ResMatch");
            BindingSource TheSOUSSE = new BindingSource(Mels, "ResMatch");
            DGV_Joueurs.DataSource = TheSOUSSE;
     
            commande = "select * from match where nummatch =" + Cb_NumMatch.SelectedItem.ToString();
            OracleDataAdapter adapp = new OracleDataAdapter(commande, orac);
            DataSet leset = new DataSet();
            adapp.Fill(leset, "resMatchs");
            BindingSource data = new BindingSource(leset, "resMatchs");
            DGV_Match.DataSource = data;
        }
    }
}
