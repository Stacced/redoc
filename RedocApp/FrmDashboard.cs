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

        private FrmExams InitializeExamsForm()
        {
            FrmExams frm = new FrmExams();
            frm.MdiParent = this;
            return frm;
        }

        private void frmDashboardAdmin_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            FrmLogin frmLogin = new FrmLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Connexion réussie", "REDOC - Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Enabled = true;
            }
            else
            {
                this.Close();
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûr de vouloir quitter ?", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void tsbtnRdv_Click(object sender, EventArgs e)
        {
            InitializeSchedulerForm().Show();
        }

        private void tsbtnPatients_Click(object sender, EventArgs e)
        {
            InitializePatientsForm().Show();
        }

        private void tsbtnExams_Click(object sender, EventArgs e)
        {
            InitializeExamsForm().Show();
        }
    }
}
