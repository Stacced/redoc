
namespace RedocApp
{
    partial class FrmAddEditPatient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAddEditPatient = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txbSurname = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txbPhoneNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbNoAVS = new System.Windows.Forms.MaskedTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddEditPatient
            // 
            this.lblAddEditPatient.AutoSize = true;
            this.lblAddEditPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.91597F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEditPatient.Location = new System.Drawing.Point(12, 9);
            this.lblAddEditPatient.Name = "lblAddEditPatient";
            this.lblAddEditPatient.Size = new System.Drawing.Size(359, 29);
            this.lblAddEditPatient.TabIndex = 0;
            this.lblAddEditPatient.Text = "Ajout / modification de patient";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(14, 90);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(36, 16);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "&Nom";
            // 
            // txbSurname
            // 
            this.txbSurname.Location = new System.Drawing.Point(158, 87);
            this.txbSurname.Name = "txbSurname";
            this.txbSurname.Size = new System.Drawing.Size(213, 22);
            this.txbSurname.TabIndex = 4;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(158, 130);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(213, 22);
            this.txbName.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 133);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 16);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "&Prénom";
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthdate.Location = new System.Drawing.Point(158, 173);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(213, 22);
            this.dtpBirthdate.TabIndex = 8;
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Location = new System.Drawing.Point(14, 176);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(120, 16);
            this.lblBirthdate.TabIndex = 7;
            this.lblBirthdate.Text = "&Date de naissance";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(14, 216);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 16);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "A&dresse";
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(158, 216);
            this.txbAddress.Multiline = true;
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(213, 81);
            this.txbAddress.TabIndex = 10;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(158, 318);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(213, 22);
            this.txbEmail.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(14, 321);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(94, 16);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Adresse &email";
            // 
            // txbPhoneNumber
            // 
            this.txbPhoneNumber.Location = new System.Drawing.Point(158, 361);
            this.txbPhoneNumber.Name = "txbPhoneNumber";
            this.txbPhoneNumber.Size = new System.Drawing.Size(213, 22);
            this.txbPhoneNumber.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "&Téléphone (format int.)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "&No AVS";
            // 
            // mtbNoAVS
            // 
            this.mtbNoAVS.Location = new System.Drawing.Point(158, 44);
            this.mtbNoAVS.Mask = "756.0000.0000.00";
            this.mtbNoAVS.Name = "mtbNoAVS";
            this.mtbNoAVS.Size = new System.Drawing.Size(213, 22);
            this.mtbNoAVS.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(17, 406);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 51);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "&Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(234, 406);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(137, 51);
            this.btnConfirm.TabIndex = 15;
            this.btnConfirm.Text = "&Valider";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // FrmAddEditPatient
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(392, 469);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.mtbNoAVS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbPhoneNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.dtpBirthdate);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txbSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblAddEditPatient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAddEditPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REDOC - AJOUT/EDIT PATIENT";
            this.Load += new System.EventHandler(this.FrmAddEditPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddEditPatient;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txbSurname;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txbPhoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbNoAVS;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
    }
}