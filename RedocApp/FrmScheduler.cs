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
    public partial class FrmScheduler : Form
    {
        public FrmScheduler()
        {
            InitializeComponent();
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            FrmAddEditAppointment frm = new FrmAddEditAppointment();
            frm.ShowDialog();
        }

        private void dgvAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                FrmAddEditAppointment frm = new FrmAddEditAppointment();
                frm.ShowDialog();
            }
        }

        private void FrmScheduler_Load(object sender, EventArgs e)
        {
            this.btnAddAppointment.Enabled = FrmDashboard.userType == FrmLogin.UserType.ASSISTANT;
        }
    }
}
