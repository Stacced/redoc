using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedocApp
{
    public partial class FrmPatients : Form
    {
        private static FrmPatients _instance = null;
        private FrmPatients()
        {
            InitializeComponent();
        }

        public static FrmPatients GetInstance()
        {
            if (_instance == null)
            {
                _instance = new FrmPatients();
            }

            return _instance;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // TODO
            // Execute search on database
        }
    }
}
