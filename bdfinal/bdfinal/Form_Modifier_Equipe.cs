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
    public partial class Form_Modifier_Equipe : Form
    {
        OracleConnection orac = new OracleConnection();
        DataSet theSet = new DataSet();
        public Form_Modifier_Equipe()
        {
            InitializeComponent();
        }
        public Form_Modifier_Equipe(OracleConnection ora)
        {
            InitializeComponent();
            orac = ora;
            FilleComboBox();
        }
        private void FilleComboBox()
        {
            string commande = "SELECT nom from division";
            OracleCommand oraclecomm = new OracleCommand(commande, orac);
            oraclecomm.CommandType = CommandType.Text;
            OracleDataReader oraread = oraclecomm.ExecuteReader();
            while (oraread.Read())
            {
                string ligne = oraread.GetString(0);
               Cb_Division.Items.Add(ligne);
            }
            oraread.Close();
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //fille les autre box et label
            commande = "select * from equipe";
            OracleDataAdapter adp = new OracleDataAdapter(commande, orac);
            adp.Fill(theSet, "ResEquipes");
            Lb_Num.DataBindings.Add("text",theSet, "ResEquipes.numequipe");
            Tb_Name.DataBindings.Add("text", theSet, "ResEquipes.nomequipe");
            Tb_ville.DataBindings.Add("text", theSet, "ResEquipes.ville");
            pb_Logo.DataBindings.Add("image", theSet, "ResEquipes.Logo", true);
           pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
           
            MessageBox.Show(orac.State.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BindingContext[theSet, "ResEquipes"].Position += 1;
        }

        private void Btn_Precedent_Click(object sender, EventArgs e)
        {
            this.BindingContext[theSet, "ResEquipes"].Position -= 1;
        }

        private void Btn_Modifier_Click(object sender, EventArgs e)
        {
            string commande = "Update equipe set nomequipe ='" + Tb_Name.Text + "'," + "ville = '" + Tb_ville.Text + "' where numequipe =" + Lb_Num.Text;
            OracleCommand com = new OracleCommand(commande, orac);
            com.CommandType = CommandType.Text;
            int i = com.ExecuteNonQuery();
            MessageBox.Show(i.ToString() + " Ligne Modifier");
        }   
    }
}
