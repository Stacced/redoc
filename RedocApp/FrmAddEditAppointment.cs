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
    public partial class FrmAddEditAppointment : Form
    {
        bool isEdit = false;
        int appointmentNo;

        public FrmAddEditAppointment(bool isEdit)
        {
            InitializeComponent();
            this.isEdit = isEdit;
        }

        public FrmAddEditAppointment(bool isEdit, int apptNo)
        {
            InitializeComponent();
            this.isEdit = isEdit;
            this.appointmentNo = apptNo;
        }

        private void FrmAddEditAppointment_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSetRedoc.VW_PATIENT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vW_PATIENTTableAdapter.Fill(this.dataSetRedoc.VW_PATIENT);
            // TODO: cette ligne de code charge les données dans la table 'dataSetRedoc.VW_DOCTEUR'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vW_DOCTEURTableAdapter.Fill(this.dataSetRedoc.VW_DOCTEUR);

            if (isEdit)
            {
                lblAddEditAppointment.Text = "Modification rendez-vous";
                this.Text = "REDOC - Modification rendez-vous";

                // TODO: cette ligne de code charge les données dans la table 'dataSetRedoc.VW_RENDEZVOUS'. Vous pouvez la déplacer ou la supprimer selon les besoins.
                this.vW_RENDEZVOUSTableAdapter.FillByApptNo(this.dataSetRedoc.VW_RENDEZVOUS, appointmentNo);
            } else
            {
                lblAddEditAppointment.Text = "Ajout rendez-vous";
                this.Text = "REDOC - Ajout d'un rendez-vous";
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DateTime apptDate = this.dtpMain.Value;
            int docNo = int.Parse(this.cmbDoctor.SelectedValue.ToString());
            int patNo = int.Parse(this.cmbPatient.SelectedValue.ToString());
            string apptNotes = this.txbNotes.Text;
            DataSetRedocTableAdapters.QueriesTableAdapter request = new DataSetRedocTableAdapters.QueriesTableAdapter();

            if (isEdit)
            {
                request.PKG_REDOC_EDITAPPOINTMENT(appointmentNo, apptDate, docNo, patNo, apptNotes);
                this.DialogResult = DialogResult.OK;
            } else
            {
                request.PKG_REDOC_ADDAPPOINTMENT(apptDate, docNo, patNo, apptNotes);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
