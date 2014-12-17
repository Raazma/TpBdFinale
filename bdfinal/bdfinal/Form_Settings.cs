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
    public partial class Option : Form
    {
        private DataSet DS_Demo= new DataSet();
        private OracleConnection oraconn ;
        public Option(OracleConnection conn)
        {
            InitializeComponent();
            oraconn = conn;
        }
        
        private void Form_Settings_Load(object sender, EventArgs e)
        {
            this.Location = Properties.Settings.Default.Settings_Pos;
            this.Size = Properties.Settings.Default.Setting_Size;

            this.ForeColor = Properties.Settings.Default.Text_Color;
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
            Properties.Settings.Default.Text_Color = this.ForeColor;
            Properties.Settings.Default.Save();
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void BT_Header_Color_Click(object sender, EventArgs e)
        {
            HLSColorPicker ColorPicker = new HLSColorPicker();
            ColorPicker.color = PN_Head.BackColor;
            if(ColorPicker.ShowDialog() == DialogResult.OK)
            {
                PN_Head.BackColor = ColorPicker.color;
            }
        }

        private void FB_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private void BT_Impaire_Click(object sender, EventArgs e)
        {
            HLSColorPicker ColorPicker = new HLSColorPicker();
            ColorPicker.color = DGV_Demo.DefaultCellStyle.BackColor;
            if (ColorPicker.ShowDialog() == DialogResult.OK)
            {
                DGV_Demo.DefaultCellStyle.BackColor = ColorPicker.color;
            }
        }

        private void BT_Paire_Click(object sender, EventArgs e)
        {
            HLSColorPicker ColorPicker = new HLSColorPicker();
            ColorPicker.color = DGV_Demo.AlternatingRowsDefaultCellStyle.BackColor;
            if (ColorPicker.ShowDialog() == DialogResult.OK)
            {
                DGV_Demo.AlternatingRowsDefaultCellStyle.BackColor = ColorPicker.color;
            }
        }

        private void BT_Text_Color_Click(object sender, EventArgs e)
        {
            HLSColorPicker ColorPicker = new HLSColorPicker();
            ColorPicker.color = this.ForeColor;
            if (ColorPicker.ShowDialog() == DialogResult.OK)
            {
                this.ForeColor = ColorPicker.color;
            }
        }
    }
}
