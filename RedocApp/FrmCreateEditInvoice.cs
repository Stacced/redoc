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
        private int apptNo;

        public FrmCreateEditInvoice(bool isEdit)
        {
            InitializeComponent();
            this.isEdit = isEdit;
        }

        public FrmCreateEditInvoice(bool isEdit, int apptNo)
        {
            InitializeComponent();
            this.isEdit = isEdit;
            this.apptNo = apptNo;
        }

        private void FrmCreateEditInvoice_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSetRedoc.VW_EXAMEN'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vW_EXAMENTableAdapter.Fill(this.dataSetRedoc.VW_EXAMEN);
            if (isEdit)
            {
                this.Text = "REDOC - Modification facture";
                this.lblInvoice.Text = "Modification facture";

                // TODO: cette ligne de code charge les données dans la table 'dataSetRedoc.VW_FACTURE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
                this.vW_FACTURETableAdapter.Fill(this.dataSetRedoc.VW_FACTURE);
            } else
            {
                this.Text = "REDOC - Création facture";
                this.lblInvoice.Text = "Création facture";
            }
        }

        private void btnAddExam_Click(object sender, EventArgs e)
        {
            lsbExams.Items.Add(cmbExams.SelectedText);
        }

        private void ComputeNewTotal()
        {
            
        }
    }
}
