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
    public partial class Form_Modifier_Equipe : Form
    {
        OracleConnection orac = new OracleConnection();
        DataSet theSet = new DataSet();
        string filename;
         
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
            try
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //fille les autre box et label
            try
            {
                string commande = "select * from equipe";
                OracleDataAdapter adp = new OracleDataAdapter(commande, orac);
                adp.Fill(theSet, "ResEquipes");
                Lb_Num.DataBindings.Add("text", theSet, "ResEquipes.numequipe");
                Tb_Name.DataBindings.Add("text", theSet, "ResEquipes.nomequipe");
                Tb_ville.DataBindings.Add("text", theSet, "ResEquipes.ville");
                pb_Logo.DataBindings.Add("image", theSet, "ResEquipes.Logo", true);
                Dtp_date.DataBindings.Add("Value", theSet, "ResEquipes.DateIntroduction");
                pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

                MessageBox.Show(orac.State.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
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
            if (filename != null)
            {
                try
                {
                    FileStream Streamp = new FileStream(filename, FileMode.Open, FileAccess.Read);
                    byte[] buffer1 = new byte[Streamp.Length];
                    Streamp.Read(buffer1, 0, System.Convert.ToInt32(Streamp.Length));
                    Streamp.Close();

                    string commande = "Update equipe set nomequipe ='" + Tb_Name.Text + "'," + "ville = '" + Tb_ville.Text + "' , logo = :TheLogo" + ", DateIntroduction = :Ladate" + " where numequipe =" + Lb_Num.Text;
                    OracleCommand com = new OracleCommand(commande, orac);
                    com.CommandType = CommandType.Text;
                    OracleParameter lelogo = new OracleParameter(":TheLogo", OracleDbType.Blob);
                    OracleParameter ladate = new OracleParameter(":Ladate", OracleDbType.Date);

                    lelogo.Value = buffer1;
                    com.Parameters.Add(lelogo);
                    ladate.Value = Dtp_date.Value;

                    com.Parameters.Add(ladate);

                    int i = com.ExecuteNonQuery();
                    MessageBox.Show(i.ToString() + " Ligne Modifier");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());

                }

            }
            else
            {
                try
                {
                    string commande = "Update equipe set nomequipe ='" + Tb_Name.Text + "'," + "ville = '" + Tb_ville.Text + "', DateIntroduction = :Ladate" + " where numequipe =" + Lb_Num.Text;
                    OracleCommand com = new OracleCommand(commande, orac);
                    com.CommandType = CommandType.Text;
                    OracleParameter ladate = new OracleParameter(":Ladate", OracleDbType.Date);
                    ladate.Value = Dtp_date.Value;
                    com.Parameters.Add(ladate);

                    int i = com.ExecuteNonQuery();
                    MessageBox.Show(i.ToString() + " Ligne Modifier");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());

                }
            }
        }

        private void Btn_mod_photo_Click(object sender, EventArgs e)
        {
            OpenFileDialog form = new OpenFileDialog();

            if(form.ShowDialog() == DialogResult.OK)
            {
                filename = form.FileName;
                         
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string commande = "Delete from equipe where numequipe =" + Lb_Num.Text;
                OracleCommand com = new OracleCommand(commande, orac);
                com.CommandType = CommandType.Text;


                int i = com.ExecuteNonQuery();
                MessageBox.Show(i.ToString() + " Ligne Effacer");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }

        }   
    }
}
