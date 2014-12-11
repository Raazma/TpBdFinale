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

    public partial class Form_Classement : Form
    {
        private OracleConnection oraconn;//=new OracleConnection();
        private DataSet DS_Classement = new DataSet();
        public Form_Classement(OracleConnection Connection)
        {
            InitializeComponent();
            oraconn = Connection;
        }

        private void Form_Classement_Load(object sender, EventArgs e)
        {
           

            string com = "select nom from DIVISION";
            OracleCommand oraclecomm = new OracleCommand(com, oraconn);
            
            OracleDataReader oraread = oraclecomm.ExecuteReader();
            while (oraread.Read())
            {
                string ligne = oraread.GetString(0);
                CB_Division.Items.Add(ligne);
            }
            oraread.Close();
            CB_Division.SelectedIndex = 0;
            CB_Classement.SelectedIndex = 0;
        }

        private void CB_Classement_SelectedIndexChanged(object sender, EventArgs e)
        {

            ClearFckingDGV();
            switch (CB_Classement.SelectedIndex)
            {
                    //Classement Joueurs
                case 1:
                    CB_Division.Visible = false;
                    Fill_DGV_Classement_Joueurs();
                    break;
                    //Classement Top 3 Joueurs
                case 2:
                    CB_Division.Visible = false;
                    Fill_DGV_Classement_Joueurs_Top3();
                    break;
                    //Par défaut Classement Équipe avec division 1
                default:
                    CB_Division.Visible = true;
                    //Fill_DGV_Classement_Equipe();
                    break;
            }

        }

        private void Fill_DGV_Classement_Equipe()
        {
           
            string com = "select * from ClassementEquipe where NUMDIVISION = (select numdivision from division where nom = '"+ CB_Division.SelectedItem.ToString() +"')";
            OracleDataAdapter ODA=new OracleDataAdapter(com,oraconn);

            ODA.Fill(DS_Classement, "Classement");
            BindingSource Source = new BindingSource(DS_Classement, "Classement");
            DGV_Classement.DataSource=Source;
            
            
            
        }
        private void Fill_DGV_Classement_Joueurs()
        {

            string com = "select * from ClassementJoueur";
            OracleDataAdapter ODA = new OracleDataAdapter(com, oraconn);

            ODA.Fill(DS_Classement, "Classement");
            BindingSource Source = new BindingSource(DS_Classement, "Classement");
            DGV_Classement.DataSource = Source;
        }
        private void Fill_DGV_Classement_Joueurs_Top3()
        {
            string com = "select * from Top3Joueur";
            OracleDataAdapter ODA = new OracleDataAdapter(com, oraconn);

            ODA.Fill(DS_Classement, "Classement");
            BindingSource Source = new BindingSource(DS_Classement, "Classement");
            DGV_Classement.DataSource = Source;
        }

        private void CB_Division_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearFckingDGV();
            Fill_DGV_Classement_Equipe();
        }
        private void ClearFckingDGV()
        {
            DGV_Classement.DataSource = null;
            DS_Classement.Tables.Clear();
            DGV_Classement.Columns.Clear();
        }
        
    }
}