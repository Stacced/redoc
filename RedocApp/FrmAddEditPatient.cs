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
    public partial class FrmAddEditPatient : Form
    {
        private bool isEdit = false;
        public FrmAddEditPatient(bool isEdit)
        {
            InitializeComponent();
            this.isEdit = isEdit;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void FrmAddEditPatient_Load(object sender, EventArgs e)
        {
            if (isEdit)
            {
                this.Text = "REDOC - Modification patient";
                this.lblAddEditPatient.Text = "Modification patient";
            } else
            {
                this.Text = "REDOC - Ajout patient";
                this.lblAddEditPatient.Text = "Ajout patient";
            }
        }
    }
}
