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
    public partial class Form_Settings : Form
    {
        private DataSet DS_Demo= new DataSet();
        private OracleConnection oraconn ;
        public Form_Settings(OracleConnection conn)
        {
            InitializeComponent();
            oraconn = conn;
        }
        
        private void Form_Settings_Load(object sender, EventArgs e)
        {
            this.Location = Properties.Settings.Default.Settings_Pos;
            this.Size = Properties.Settings.Default.Setting_Size;

            PN_Head.BackColor = Properties.Settings.Default.Header_Color;
            DGV_Demo.AlternatingRowsDefaultCellStyle.BackColor = Properties.Settings.Default.DGV_Alt_Color;
            DGV_Demo.DefaultCellStyle.BackColor = Properties.Settings.Default.DGV_Def_Color;
            try
            {
                string com = "select * from ClassementJoueur where rownum <= 15";
                OracleDataAdapter ODA = new OracleDataAdapter(com, oraconn);

                ODA.Fill(DS_Demo, "Classement");
                BindingSource Source = new BindingSource(DS_Demo, "Classement");
                DGV_Demo.DataSource = Source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }

        }

        private void Form_Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Settings_Pos = this.Location;
            Properties.Settings.Default.Setting_Size = this.Size;
            Properties.Settings.Default.Save();
        }

        private void FB_Apply_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DGV_Alt_Color = DGV_Demo.AlternatingRowsDefaultCellStyle.BackColor;
            Properties.Settings.Default.DGV_Def_Color = DGV_Demo.DefaultCellStyle.BackColor;
            Properties.Settings.Default.Header_Color = PN_Head.BackColor;
            Properties.Settings.Default.Save();

        }

        private void BT_Header_Color_Click(object sender, EventArgs e)
        {

        }
    }
}
