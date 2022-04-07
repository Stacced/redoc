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
    public partial class FrmCreateEditInvoice : Form
    {
        private bool isEdit = false;
        public FrmCreateEditInvoice(bool isEdit)
        {
            InitializeComponent();
            this.isEdit = isEdit;
        }

        private void FrmCreateEditInvoice_Load(object sender, EventArgs e)
        {
            if (isEdit)
            {
                this.Text = "REDOC - Modification facture";
                this.lblInvoice.Text = "Modification facture";
            } else
            {
                this.Text = "REDOC - Création facture";
                this.lblInvoice.Text = "Création facture";
            }
        }
    }
}
