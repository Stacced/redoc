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
        private List<short> exams = new List<short>();

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

                // We suppose that the invoice will not need any exam list modifications in the future.
                this.btnAddExam.Enabled = false;
                this.btnRemoveExam.Enabled = false;
                this.cmbExams.Enabled = false;

                // TODO: cette ligne de code charge les données dans la table 'dataSetRedoc.VW_FACTURE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
                this.vW_FACTURETableAdapter.Fill(this.dataSetRedoc.VW_FACTURE);

                // TODO: cette ligne de code charge les données dans la table 'dataSetRedoc.VW_EXAMENS_FACTURE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
                this.vW_EXAMENS_FACTURETableAdapter.FillByFacNo(this.dataSetRedoc.VW_EXAMENS_FACTURE, invoiceNo);

                // Fill exams list with items in list box
                foreach (DataRowView examView in lsbExams.Items)
                {
                    DataSetRedoc.VW_EXAMENS_FACTURERow examRow = (DataSetRedoc.VW_EXAMENS_FACTURERow)examView.Row; 
                    exams.Add(examRow.EXA_NO);
                }

                this.lblTotalAmount.Text = ComputeTotal().ToString();
            } else
            {
                this.Text = "REDOC - Création facture";
                this.lblInvoice.Text = "Création facture";
                this.lsbExams.DataSource = null;
                this.lsbExams.DisplayMember = null;
                this.lsbExams.ValueMember = null;
                this.cbxPaid.Enabled = false;
            }
        }

        private void btnAddExam_Click(object sender, EventArgs e)
        {
            DataSetRedoc.VW_EXAMENRow row = (DataSetRedoc.VW_EXAMENRow)((DataRowView)this.cmbExams.SelectedItem).Row;
            
            this.exams.Add(Convert.ToInt16(this.cmbExams.SelectedValue));
            this.lsbExams.Items.Add(row.LIS_NOM);
            this.lblTotalAmount.Text = ComputeTotal().ToString();
        }

        private void btnRemoveExam_Click(object sender, EventArgs e)
        {
            this.exams.Remove(Convert.ToInt16(this.cmbExams.SelectedValue));
            this.lsbExams.Items.Remove(this.lsbExams.SelectedItem);
            this.lblTotalAmount.Text = ComputeTotal().ToString();
        }

        private decimal ComputeTotal()
        {
            DataSetRedocTableAdapters.QueriesTableAdapter request = new DataSetRedocTableAdapters.QueriesTableAdapter();
            decimal invoiceTotal = 0;

            foreach (short examNo in exams)
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
                int paid = cbxPaid.Checked ? 1 : 0;
                request.PKG_REDOC_EDITINVOICE(invoiceNo, invoiceDate, paid);
            } else
            {
                int invoiceNo = (int)request.PKG_REDOC_ADDINVOICE(apptNo, invoiceDate, invoiceTotal);

                foreach (short examNo in exams)
                {
                    request.PKG_REDOC_ADDINVOICEEXAM(invoiceNo, examNo);
                }
            }

            this.btnConfirm.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
