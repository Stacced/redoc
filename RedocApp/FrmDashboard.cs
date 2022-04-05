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
        public static FrmLogin.UserType userType;

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

        private void frmDashboardAdmin_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            FrmLogin frmLogin = new FrmLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                this.Enabled = true;
                userType = FrmLogin.userType;
            }
            else
            {
                this.Close();
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

        private void tsmiTileHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tsmiTileVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
