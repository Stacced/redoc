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
    public partial class FrmPatientFile : Form
    {
        private int noPatient;
        public FrmPatientFile(int noPatient)
        {
            InitializeComponent();
            this.noPatient = noPatient;
        }

        private void dgvAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                FrmCreateEditInvoice frm = new FrmCreateEditInvoice(false);
                frm.ShowDialog();
            }
        }
    }
}
