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
    public partial class Form_AffJoueur : Form
    {
        public OracleConnection oracon = new OracleConnection();
        public DataSet Info = new DataSet();
        public Form_AffJoueur()
        {
            InitializeComponent();
        }
        public Form_AffJoueur(OracleConnection oraconn)
        {
            InitializeComponent();
            oracon = oraconn;
            RemplirGridView();
        }
        public void RemplirGridView()
        { 
            string commande = "SELECT * FROM Joueurs";
            OracleDataAdapter adap = new OracleDataAdapter(commande, oracon);
            adap.Fill(Info, "ResJoueurs");
            BindingSource TheSOUSSE = new BindingSource(Info,"ResJoueurs");
            Dgv_Joueurs.DataSource = TheSOUSSE;            
        }
        private void fillcontrol()
        {
            string commande = "Select * from FichePersonnelle";
            OracleDataAdapter orDataAdaptr = new OracleDataAdapter(commande, oracon);
        }

        
    }
}
