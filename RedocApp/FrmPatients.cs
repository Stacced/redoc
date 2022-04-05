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
        public FrmPatients()
        {
            InitializeComponent();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // TODO
            // Execute search on database
        }

        private void FrmPatients_Load(object sender, EventArgs e)
        {
            dgvPatients.Rows.Add("", "", "", "");
        }
    }
}
