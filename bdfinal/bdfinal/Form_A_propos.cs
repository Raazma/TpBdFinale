using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bdfinal
{
    public partial class Form_A_propos : Form
    {
        public Form_A_propos()
        {
            InitializeComponent();
        }

        private void Form_A_propos_Load(object sender, EventArgs e)
        {
            this.Location = Properties.Settings.Default.A_Propos_Pos;
            this.Size = Properties.Settings.Default.A_Propos_Size;
        }

        private void Form_A_propos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.A_Propos_Pos=this.Location ;
            Properties.Settings.Default.A_Propos_Size =this.Size ;
            Properties.Settings.Default.Save();
        }
    }
}
