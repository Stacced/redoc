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
    public partial class frmDashboardAdmin : Form
    {
        FrmScheduler frmScheduler;
        FrmPatients frmPatients;
        FrmExams frmExams;

        public frmDashboardAdmin()
        {
            InitializeComponent();
            InitializeMDIChildren();
        }

        private void InitializeMDIChildren()
        {
            frmScheduler = FrmScheduler.GetInstance();
            frmScheduler.MdiParent = this;

            frmPatients = FrmPatients.GetInstance();
            frmPatients.MdiParent = this;

            frmExams = FrmExams.GetInstance();
            frmExams.MdiParent = this;
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
            frmScheduler.Show();
        }

        private void tsbtnPatients_Click(object sender, EventArgs e)
        {
            frmPatients.Show();
        }

        private void tsbtnExams_Click(object sender, EventArgs e)
        {
            frmExams.Show();
        }
    }
}
