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
    public partial class Division : Form
    {
        public OracleConnection oracon = new OracleConnection();
        public DataSet Imsetting = new DataSet();
        public Division(OracleConnection oracc)
        {
            InitializeComponent();
            oracon = oracc;
            FilledInfo();
        }

        private void Btn_Enregister_Click(object sender, EventArgs e)
        {
            string commande = "  INSERT INTO DIVISION (NOM , DATEINSCRIPTION )VALUES(:LENOM , :LADATE)";
            OracleCommand orcom = new OracleCommand(commande, oracon);
            OracleParameter lenom = new OracleParameter(":LENOM", OracleDbType.Varchar2, 40);
            OracleParameter ladate = new OracleParameter(":LADATE", OracleDbType.Date);

            lenom.Value = Tb_Nom.Text;
            ladate.Value = Dtp_Date.Value;

            orcom.Parameters.Add(lenom);
            orcom.Parameters.Add(ladate);

          int updater =  orcom.ExecuteNonQuery();

          MessageBox.Show(updater.ToString() + " Ligne Inserer");
         FilledInfo();
            

        }

        private void btn_Nouveau_Click(object sender, EventArgs e)
        {
            ClearBinding();
           
        }

        private void FilledInfo()
        {
            try
            {
                ClearBinding();
                string commande = "select * from division";
                OracleDataAdapter adp = new OracleDataAdapter(commande, oracon);
                adp.Fill(Imsetting, "ResDiv");
                Tb_Nom.DataBindings.Add("text", Imsetting, "ResDiv.Nom");
                Dtp_Date.DataBindings.Add("Value", Imsetting, "ResDiv.DateInscription");
                Lb_num.DataBindings.Add("text", Imsetting, "ResDiv.NumDivision");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            
            }

        }

        private void Btn_Suivant_Click(object sender, EventArgs e)
        {
            this.BindingContext[Imsetting, "ResDiv"].Position += 1;
        }

        private void Btn_Precedent_Click(object sender, EventArgs e)
        {
            this.BindingContext[Imsetting, "ResDiv"].Position -= 1;
        }

        private void Btn_Modifier_Click(object sender, EventArgs e)
        {        
            string commande = "update division set nom ='" + Tb_Nom.Text +"', DateInscription = :LaDate where numdivision =" + Lb_num.Text;
            OracleParameter ladate = new OracleParameter(":LaDate", OracleDbType.Date);
            OracleCommand com = new OracleCommand(commande, oracon);
            ladate.Value = Dtp_Date.Value;
            com.Parameters.Add(ladate);
            int i = com.ExecuteNonQuery();

            MessageBox.Show(i.ToString() + " Ligne modifier");
            FilledInfo();
        }

        private void ClearBinding()
        {
            Tb_Nom.DataBindings.Clear();
            Dtp_Date.DataBindings.Clear();
            Lb_num.DataBindings.Clear();
            Imsetting.Clear();
            Tb_Nom.Clear();
                 
        }
        private void BT_Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                string commande = "delete from division where numdivision =" + Lb_num.Text;
                OracleCommand com = new OracleCommand(commande, oracon);
                int i = com.ExecuteNonQuery();
                MessageBox.Show(i.ToString() + " nombre ligne effacer");
                FilledInfo();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Division_Load(object sender, EventArgs e)
        {
            this.Location = Properties.Settings.Default.Division_Pos;
            this.Size = Properties.Settings.Default.Division_Size;
            this.ForeColor = Properties.Settings.Default.Text_Color;
        }

        private void Division_FormClosing(object sender, FormClosingEventArgs e)
        {
             Properties.Settings.Default.Division_Pos=this.Location ;
             Properties.Settings.Default.Division_Size=this.Size ;
             Properties.Settings.Default.Save();
        }

    }
}
