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
    public partial class FrmInvoices : Form
    {
        public FrmInvoices()
        {
            InitializeComponent();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // TODO
            // Execute search on database
        }

        private void FrmInvoices_Load(object sender, EventArgs e)
        {
            dgvInvoices.Rows.Add("1", "Impayée", "DUPONT Jean", "202201", "250.60", "Voir détails");
            dgvInvoices.Rows.Add("2", "Payée", "TERIEUR Alain", "202202", "153.30", "Voir détails");
            dgvInvoices.Rows.Add("3", "En retard", "TERIEUR Alex", "202203", "77.70", "Voir détails");
        }

        private void dgvPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                /*
                FrmPatientFile frm = new FrmPatientFile();
                frm.ShowDialog();
                */
            }
        }
    }
}
