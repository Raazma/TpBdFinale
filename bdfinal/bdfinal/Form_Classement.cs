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

    public partial class Form_Classement : Form
    {
        public Form_Classement()
        {
            InitializeComponent();
        }

        private void Form_Classement_Load(object sender, EventArgs e)
        {
            CB_Classement.SelectedIndex = 0;
        }

        private void CB_Classement_SelectedIndexChanged(object sender, EventArgs e)
        {
            //switch(CB_Classement.SelectedIndex)
            //{
            //    case 1:
                   
            //}
        }

        private void Fill_DGV_Classement_Equipe()
        {
            
        }
    }
}
