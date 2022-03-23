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
        public frmDashboardAdmin()
        {
            InitializeComponent();
        }

        private void frmDashboardAdmin_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            FrmLogin frmLogin = new FrmLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Connexion réussie");
                this.Enabled = true;
            } else
            {
                MessageBox.Show("Connexion échouée");
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûr de vouloir quitter ?", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
