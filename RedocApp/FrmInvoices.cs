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
            dgvInvoices.Rows.Add("Voir dossier", "DUPONT", "Jean", "756.0000.0000.00", "14.02.2001", "Chemin des Vergers 12", "test@test.ch", "0787990909");
            dgvInvoices.Rows.Add("Voir dossier", "TERIEUR", "Alain", "756.0000.0000.00", "02.03.1999", "Chemin des Zigloutirages 1", "test@test.ch", "0787990909");
            dgvInvoices.Rows.Add("Voir dossier", "TERIEUR", "Alex", "756.0000.0000.00", "01.07.1998", "Allée des Chimpanzé 10", "test@test.ch", "0787990909");
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            FrmAddEditPatient frm = new FrmAddEditPatient(false);
            frm.ShowDialog();
        }

        private void dgvPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                FrmPatientFile frm = new FrmPatientFile();
                frm.ShowDialog();
            }
        }
    }
}
