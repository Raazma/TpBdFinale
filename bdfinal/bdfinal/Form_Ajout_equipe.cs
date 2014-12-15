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

        string filename;
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
            try
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
                Cb_Division.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Cb_Division.SelectedItem != null)
            {
                try
                {

                    FileStream Streamp = new FileStream(filename, FileMode.Open, FileAccess.Read);
                    byte[] buffer1 = new byte[Streamp.Length];
                    Streamp.Read(buffer1, 0, System.Convert.ToInt32(Streamp.Length));
                    Streamp.Close();
                    string commande = "insert into  equipe(  NumDivision   ,  DateIntroduction, Logo, Ville , NomEquipe) Values((select   NumDivision   from division where nom = :Numero ), :laDate ,:thelogo, :theVille , :thenom)";
                    OracleCommand orcom = new OracleCommand(commande, orac);

                    OracleParameter Numdiv = new OracleParameter(":Numero", OracleDbType.Varchar2, 40);
                    OracleParameter logo = new OracleParameter(":thelogo", OracleDbType.Blob);
                    OracleParameter Date = new OracleParameter(":laDate", OracleDbType.Date);
                    OracleParameter Ville = new OracleParameter(":theVille", OracleDbType.Varchar2, 30);
                    OracleParameter Nom = new OracleParameter(":thenom", OracleDbType.Varchar2, 20);


                    Numdiv.Value = Cb_Division.SelectedItem.ToString();
                    Date.Value = DTP_Intro.Value;
                    Ville.Value = Tb_Ville.Text;
                    logo.Value = buffer1;
                    Nom.Value = Tb_Nom.Text;
                    orcom.Parameters.Add(Numdiv);
                    orcom.Parameters.Add(Date);
                    orcom.Parameters.Add(logo);
                    orcom.Parameters.Add(Ville);
                    orcom.Parameters.Add(Nom);

                    int laligne = orcom.ExecuteNonQuery();

                    MessageBox.Show(laligne.ToString());

                    Tb_Nom.Clear();
                    Tb_Nom.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());

                }
              
            }
        }

        private void Form_Ajout_equipe_Load(object sender, EventArgs e)
        {

        }

        private void Btn_ChoisirLogo_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog form = new OpenFileDialog();

            if(form.ShowDialog() == DialogResult.OK)
            {
                 filename = form.FileName;
                 pictureBox1.ImageLocation = filename;
                 pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
           
            }


        }

        private void BT_Annule_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

      
    }
}
