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
    public partial class Form_Url : Form
    {
        OracleConnection orac = new OracleConnection();
        public Form_Url(OracleConnection oraco)
        {
            InitializeComponent();
            orac = oraco;
        }
    }
}
