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
    public partial class FrmLogin : Form
    {
        public enum UserType
        {
            DOCTOR = 1,
            ASSISTANT = 2
        }

        public static UserType userType;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUsername.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                btnLogin.Enabled = true;
            } else
            {
                btnLogin.Enabled = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                userType = UserType.ASSISTANT;
                this.DialogResult = DialogResult.OK;
            } else if (txtUsername.Text == "doctor" && txtPassword.Text == "doctor") {
                userType = UserType.DOCTOR;
                this.DialogResult = DialogResult.OK;
            }
            else {
                MessageBox.Show("Connexion échouée. Veuillez réessayer.", "REDOC - Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
