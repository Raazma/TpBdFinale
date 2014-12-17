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
        try
        {
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
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message.ToString());
        
        }
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            string commande = "INSERT INTO MATCH (EQUIPERECEVEUSE , EQUIPEVISITEUSE , DATEHEURE , LIEU , SCOREFINALEV,SCOREFINALER,HEURE)" +
                    
                "  VALUES ((select numequipe from equipe where nomequipe =:ER),(select numequipe from equipe where nomequipe =:EV),:DT,:LIEU ,:SFR ,:SFV , :H) ";
            try
            {
                OracleCommand com = new OracleCommand(commande, oracon);
                OracleParameter er = new OracleParameter(":ER", OracleDbType.Varchar2);
                OracleParameter ev = new OracleParameter(":EV", OracleDbType.Varchar2);
                OracleParameter dt = new OracleParameter(":DT", OracleDbType.Date);
                OracleParameter lieu = new OracleParameter(":LIEU", OracleDbType.Varchar2, 30);
                OracleParameter sfr = new OracleParameter(":SFR", OracleDbType.Int32);
                OracleParameter sfv = new OracleParameter(":ER", OracleDbType.Int32);
                OracleParameter h = new OracleParameter(":H", OracleDbType.Varchar2, 5);

                er.Value = Cb_equipeR.SelectedItem.ToString();
                ev.Value = Cb_EquipeV.SelectedItem.ToString();
                dt.Value = Dtp_date.Value;
                lieu.Value = Tb_ville.Text;
                sfr.Value = Tb_ScoreR.Text;
                sfv.Value = Tb_ScoreV.Text;
                h.Value = Tb_Heure.Text;

                com.Parameters.Add(er);
                com.Parameters.Add(ev);
                com.Parameters.Add(dt);
                com.Parameters.Add(lieu);
                com.Parameters.Add(sfr);
                com.Parameters.Add(sfv);
                com.Parameters.Add(h);
                int i = com.ExecuteNonQuery();
                MessageBox.Show(i.ToString() + " Ligne inserer");
                Tb_Heure.Clear();
                Tb_ScoreR.Clear();
                Tb_ScoreV.Clear();
                Tb_ville.Clear();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
             
        }

        private void Ajout_Match_Load(object sender, EventArgs e)
        {
            this.Size = Properties.Settings.Default.A_Match_Size;
            this.Location = Properties.Settings.Default.A_Match_Pos;
        }

        private void Ajout_Match_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.A_Match_Size = this.Size;
            Properties.Settings.Default.A_Match_Pos = this.Location;
            Properties.Settings.Default.Save();
        }
        
        }
       
    }

