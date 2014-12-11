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
    public partial class Form1 : Form
    {  public OracleConnection oraconn = new OracleConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Connect();        
        }

        private void Connect()
        {

            string Dsource = "(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
              "(HOST=205.237.244.251)(PORT=1521)))" + "(CONNECT_DATA=(SERVICE_NAME=ORCL.clg.qc.ca)))";

            string chainedeconnexion = "DATA SOURCE =" + Dsource + ";USER ID =  PAQUETTE;PASSWORD = ORACLE1";
            try
            {
                oraconn.ConnectionString = chainedeconnexion;
                oraconn.Open();
                MessageBox.Show(oraconn.State.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }      
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            oraconn.Close();
            MessageBox.Show(oraconn.State.ToString());
        }

        private void ajouterJoueurToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Form_Ajout_joueur form = new Form_Ajout_joueur(oraconn);
            //form.Show();
        }

        private void joueursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Ajout_joueur form = new Form_Ajout_joueur(oraconn);
            form.Show();
            //Form_AffJoueur form = new Form_AffJoueur(oraconn);
            //form.Show();
        }

        private void matchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Match form = new Form_Match(oraconn);
            form.Show();
        }

        private void modifierJoueurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Modif_Joueur form = new Form_Modif_Joueur(oraconn);
            form.Show();
        }

        private void ajoutEquipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Ajout_equipe form = new Form_Ajout_equipe(oraconn);
            form.Show();
        }

        private void modifEquipeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form_Modifier_Equipe form = new Form_Modifier_Equipe(oraconn);
            form.Show();
        }

        private void classementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Classement Classement=new Form_Classement();
            if(Classement.ShowDialog()==DialogResult.OK)
            {
                
            }
        }
    }
}
