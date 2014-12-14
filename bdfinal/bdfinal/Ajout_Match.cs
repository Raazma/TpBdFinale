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
    public partial class Ajout_Match : Form
    {
        public OracleConnection oracon = new OracleConnection();
        public Ajout_Match(OracleConnection oraconn)
        {
            InitializeComponent();
            oracon = oraconn;
            Fillbox();
        }

        private void Fillbox()
        { 
        string commande = "SELECT NOMEQUIPE FROM EQUIPE";
            
            OracleCommand oraclecomm = new OracleCommand(commande, oracon);
            oraclecomm.CommandType = CommandType.Text;
            OracleDataReader oraread = oraclecomm.ExecuteReader();
            while (oraread.Read())
            {
                string ligne = oraread.GetString(0);
                
                 Cb_equipeR.Items.Add(ligne);
                
                   Cb_EquipeV.Items.Add(ligne);
            }
            oraread.Close();
        }
        
        }
       
    }
}
