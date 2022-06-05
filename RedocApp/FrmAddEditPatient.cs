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
        private int noPatient;

        public FrmAddEditPatient(bool isEdit)
        {
            InitializeComponent();
            this.isEdit = isEdit;
        }

        public FrmAddEditPatient(bool isEdit, int noPatient)
        {
            InitializeComponent();
            this.isEdit = isEdit;
            this.noPatient = noPatient;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string surname = this.txtSurname.Text;
            string name = this.txtName.Text;
            DateTime birthDate = this.dtpBirthdate.Value.Date;
            string address = this.txtAddress.Text;
            string email = this.txtEmail.Text;
            string phoneNumber = this.txtPhoneNumber.Text;
            string noAvs = this.mtxNoAVS.Text.Replace(",", string.Empty);

            if (!string.IsNullOrWhiteSpace(surname) && !string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(address) && !string.IsNullOrWhiteSpace(phoneNumber) && !string.IsNullOrWhiteSpace(noAvs))
            {
                this.DialogResult = DialogResult.OK;
                DataSetRedocTableAdapters.QueriesTableAdapter request = new DataSetRedocTableAdapters.QueriesTableAdapter();
                if (isEdit)
                {
                    request.PKG_REDOC_EDITPATIENT(noPatient, surname, name, birthDate, address, email, phoneNumber, noAvs);
                }
                else
                {
                    request.PKG_REDOC_ADDPATIENT(surname, name, birthDate, address, email, phoneNumber, noAvs);
                }
            }
        }

        private void FrmAddEditPatient_Load(object sender, EventArgs e)
        {
            if (isEdit)
            {
                this.Text = "REDOC - Modification patient";
                this.lblAddEditPatient.Text = "Modification patient";

                // TODO: cette ligne de code charge les données dans la table 'dataSetRedoc.VW_PATIENT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
                this.vW_PATIENTTableAdapter.FillByPatientNo(this.dataSetRedoc.VW_PATIENT, noPatient);
            } else
            {
                this.Text = "REDOC - Ajout patient";
                this.lblAddEditPatient.Text = "Ajout patient";
            }
        }
    }
}
