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
        private int invoiceNo;

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

        public FrmCreateEditInvoice(bool isEdit, int apptNo, int invoiceNo)
        {
            InitializeComponent();
            this.isEdit = isEdit;
            this.apptNo = apptNo;
            this.invoiceNo = invoiceNo;
        }

        private void FrmCreateEditInvoice_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSetRedoc.VW_RENDEZVOUS'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vW_RENDEZVOUSTableAdapter.FillByApptNo(this.dataSetRedoc.VW_RENDEZVOUS, apptNo);
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
            this.lsbExams.Items.Add(this.cmbExams.SelectedValue);
            this.lblTotalAmount.Text = ComputeTotal().ToString();
        }

        private void btnRemoveExam_Click(object sender, EventArgs e)
        {
            this.lsbExams.Items.Remove(this.lsbExams.SelectedItem);
            this.lblTotalAmount.Text = ComputeTotal().ToString();
        }

        private decimal ComputeTotal()
        {
            DataSetRedocTableAdapters.QueriesTableAdapter request = new DataSetRedocTableAdapters.QueriesTableAdapter();
            decimal invoiceTotal = 0;

            foreach (short examNo in lsbExams.Items)
            {
                decimal? examPrice = request.PKG_REDOC_GETEXAMPRICE(examNo);
                if (examPrice != null)
                {
                    invoiceTotal += (decimal)examPrice;
                }
            }

            return invoiceTotal;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DataSetRedocTableAdapters.QueriesTableAdapter request = new DataSetRedocTableAdapters.QueriesTableAdapter();
            DateTime invoiceDate = this.dtpMain.Value.Date;
            decimal invoiceTotal = ComputeTotal();

            if (isEdit)
            {
                request.PKG_REDOC_EDITINVOICE(invoiceNo, invoiceDate);
            } else
            {
                int invoiceNo = (int)request.PKG_REDOC_ADDINVOICE(apptNo, invoiceDate, invoiceTotal);

                foreach (short examNo in this.lsbExams.Items)
                {
                    request.PKG_REDOC_ADDINVOICEEXAM(invoiceNo, examNo);
                }
            }

            this.btnConfirm.DialogResult = DialogResult.OK;
        }
    }
}
