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
            string surname = this.txbSurname.Text;
            string name = this.txbName.Text;
            DateTime birthDate = this.dtpBirthdate.Value;
            string address = this.txbAddress.Text;
            string email = this.txbEmail.Text;
            string phoneNumber = this.txbPhoneNumber.Text;
            string noAvs = this.mtbNoAVS.Text;

            if (!string.IsNullOrWhiteSpace(surname) && !string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(address) && !string.IsNullOrWhiteSpace(phoneNumber) && !string.IsNullOrWhiteSpace(noAvs))
            {
                this.DialogResult = DialogResult.OK;
                DataSetRedocTableAdapters.QueriesTableAdapter request = new DataSetRedocTableAdapters.QueriesTableAdapter();
                if (isEdit)
                {
                    //request.PKG_REDOC_EDITPATIENT(0, 0, surname, name, birthDate, address, email, phoneNumber, noAvs);
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
            } else
            {
                this.Text = "REDOC - Ajout patient";
                this.lblAddEditPatient.Text = "Ajout patient";
            }
        }
    }
}
