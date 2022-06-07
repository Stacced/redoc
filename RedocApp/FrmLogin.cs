using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace RedocApp
{
    public partial class FrmLogin : Form
    {
        public enum UserType
        {
            ASSISTANT = 1,
            DOCTOR = 2
        }

        public static UserType userType;
        public static int userNo;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                btnLogin.Enabled = true;
            } else
            {
                btnLogin.Enabled = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataSetRedocTableAdapters.QueriesTableAdapter request = new DataSetRedocTableAdapters.QueriesTableAdapter();

            // Generate SHA1 of password
            string hash = GetHash(SHA1.Create(), txtPassword.Text);

            // Ask DB if credentials are correct
            // Returned data is formatted as 'user_no;user_role'. If credentials are incorrect, DB will return '-1;DENIED'.
            string loginResult = request.PKG_REDOC_CHECKLOGINCREDENTIALS(txtEmail.Text, hash.ToLower());
            string[] loginParts = loginResult.Split(';');
            int returnedUserNo = int.Parse(loginParts[0]);

            if (returnedUserNo != -1 && loginParts[1] != "DENIED")
            {
                userType = loginParts[1] == "adm" ? UserType.ASSISTANT : UserType.DOCTOR;
                userNo = returnedUserNo;
                this.DialogResult = DialogResult.OK;
            }
            else {
                MessageBox.Show("Connexion échouée. Veuillez réessayer.", "REDOC - Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetHash(HashAlgorithm hashAlgorithm, string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            var sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}
