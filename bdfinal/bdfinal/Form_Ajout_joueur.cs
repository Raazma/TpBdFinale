﻿using System;
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
    public partial class Form_Ajout_joueur : Form
    {
        public OracleConnection oracon = new OracleConnection();
        public Form_Ajout_joueur()
        {
            InitializeComponent();
        }

        public Form_Ajout_joueur(OracleConnection oraconn)
        {
            InitializeComponent();
            oracon = oraconn;
            FillComboBox();
        }
        private void Form_Ajout_joueur_Load(object sender, EventArgs e)
        {

        }

        private void FillComboBox()
        {
            string commande = "SELECT NOMEQUIPE FROM EQUIPE";

            OracleCommand oraclecomm = new OracleCommand(commande, oracon);
            oraclecomm.CommandType = CommandType.Text;
            OracleDataReader oraread = oraclecomm.ExecuteReader();
            while (oraread.Read())
            {
                string ligne = oraread.GetString(0);
                Cb_Equipe.Items.Add(ligne);
            }
            oraread.Close();
        }

        private void Fb_Accept_Click(object sender, EventArgs e)
        {
            try
            {
                string commande = "Insert into Joueurs(Nom,Prenom,Datenaissance,NumeroMaillot,Position,NumEquipe)" +
                " values(:nom,:prenom,:datenaissance,:numeroMaillot,:position,(SELECT NUMEQUIPE FROM EQUIPE WHERE NOMEQUIPE =:nomE))";
                OracleCommand oranIns = new OracleCommand(commande, oracon);


                OracleParameter Nomparam = new OracleParameter(":nom", OracleDbType.Varchar2, 30);
                OracleParameter Prenomparam = new OracleParameter(":prenom", OracleDbType.Varchar2, 30);
                OracleParameter Dateparam = new OracleParameter(":dateNaissance", OracleDbType.Date);
                OracleParameter Numparam = new OracleParameter(":numeromaillot", OracleDbType.Int32);
                OracleParameter Posparam = new OracleParameter(":position", OracleDbType.Varchar2, 10);
                OracleParameter NomEparam = new OracleParameter(":nomE", OracleDbType.Varchar2, 20);

                Nomparam.Value = Tb_Nom.Text;
                Prenomparam.Value = Tb_Prenom.Text;
                Dateparam.Value = Dt_Fete.Value;
                Numparam.Value = Tb_Num.Text;
                Posparam.Value = Cb_Position.SelectedItem.ToString();
                NomEparam.Value = Cb_Equipe.SelectedItem.ToString();


                oranIns.Parameters.Add(Nomparam);
                oranIns.Parameters.Add(Prenomparam);
                oranIns.Parameters.Add(Dateparam);
                oranIns.Parameters.Add(Numparam);
                oranIns.Parameters.Add(Posparam);
                oranIns.Parameters.Add(NomEparam);
              
                int laligne = oranIns.ExecuteNonQuery();
                MessageBox.Show(laligne.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void flashButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }     
    }
}

