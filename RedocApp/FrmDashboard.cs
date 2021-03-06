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
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private FrmScheduler InitializeSchedulerForm()
        {
            FrmScheduler frm = new FrmScheduler();
            frm.MdiParent = this;
            return frm;
        }

        private FrmPatients InitializePatientsForm()
        {
            FrmPatients frm = new FrmPatients();
            frm.MdiParent = this;
            return frm;
        }

        private FrmInvoices InitializeInvoicesForm()
        {
            FrmInvoices frm = new FrmInvoices();
            frm.MdiParent = this;
            return frm;
        }

        private FrmDoctorSchedule InitializeDoctorScheduleForm()
        {
            FrmDoctorSchedule frm = new FrmDoctorSchedule();
            frm.MdiParent = this;
            return frm;
        }

        private void frmDashboardAdmin_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            FrmLogin frmLogin = new FrmLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                this.Enabled = true;
                tsbtnManageDocSchedule.Visible = FrmLogin.userType == FrmLogin.UserType.DOCTOR;
            }
            else
            {
                this.Close();
            }
        }

        private void Logout()
        {
            if (MessageBox.Show("Êtes-vous sûr de vouloir vous déconnecter ?", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                // Close all forms
                foreach (Form frm in this.MdiChildren)
                {
                    frm.Close();
                }
                
                // Login logic
                this.Enabled = false;
                FrmLogin frmLogin = new FrmLogin();
                if (frmLogin.ShowDialog() == DialogResult.OK)
                {
                    this.Enabled = true;
                    tsbtnManageDocSchedule.Visible = FrmLogin.userType == FrmLogin.UserType.DOCTOR;
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void tsmiFileQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûr de vouloir quitter ?", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void tsbtnAppointments_Click(object sender, EventArgs e)
        {
            InitializeSchedulerForm().Show();
        }

        private void tsbtnPatients_Click(object sender, EventArgs e)
        {
            InitializePatientsForm().Show();
        }

        private void tsbtnInvoicing_Click(object sender, EventArgs e)
        {
            InitializeInvoicesForm().Show();
        }

        private void tsbtnSchedules_Click(object sender, EventArgs e)
        {
            InitializeDoctorScheduleForm().Show();
        }

        private void tsmiTileHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tsmiTileVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void tsmiLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }
    }
}
