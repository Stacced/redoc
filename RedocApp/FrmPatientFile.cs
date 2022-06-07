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
    public partial class FrmPatientFile : Form
    {
        private int noPatient;
        public FrmPatientFile(int noPatient)
        {
            InitializeComponent();
            this.noPatient = noPatient;
        }

        private void dgvAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                DataGridViewRow selectedRow = dgvAppointments.Rows[e.RowIndex];
                if (selectedRow.Cells[0] != null)
                {
                    FrmCreateEditInvoice frm = new FrmCreateEditInvoice(false, int.Parse(selectedRow.Cells[0].Value.ToString()));
                    frm.ShowDialog();
                }
            }
        }

        private void LoadData()
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSetRedoc.VW_RENDEZVOUS'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vW_RENDEZVOUSTableAdapter.FillByPatNo(this.dataSetRedoc.VW_RENDEZVOUS, noPatient);
            this.vW_PATIENTTableAdapter.FillByPatientNo(this.dataSetRedoc.VW_PATIENT, noPatient);
        }

        private void FrmPatientFile_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void llbEditPatient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAddEditPatient frm = new FrmAddEditPatient(true, noPatient);
            frm.ShowDialog();
            LoadData();
        }
    }
}
