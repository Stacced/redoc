
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
            this.components = new System.ComponentModel.Container();
            this.lblAddEditPatient = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.vWPATIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRedoc = new RedocApp.DataSetRedoc();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblNoAVS = new System.Windows.Forms.Label();
            this.mtxNoAVS = new System.Windows.Forms.MaskedTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.vW_PATIENTTableAdapter = new RedocApp.DataSetRedocTableAdapters.VW_PATIENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vWPATIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRedoc)).BeginInit();
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
            this.lblSurname.Size = new System.Drawing.Size(37, 17);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "&Nom";
            // 
            // txtSurname
            // 
            this.txtSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vWPATIENTBindingSource, "PAT_NOM", true));
            this.txtSurname.Location = new System.Drawing.Point(158, 87);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(213, 22);
            this.txtSurname.TabIndex = 4;
            // 
            // vWPATIENTBindingSource
            // 
            this.vWPATIENTBindingSource.DataMember = "VW_PATIENT";
            this.vWPATIENTBindingSource.DataSource = this.dataSetRedoc;
            // 
            // dataSetRedoc
            // 
            this.dataSetRedoc.DataSetName = "DataSetRedoc";
            this.dataSetRedoc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vWPATIENTBindingSource, "PAT_PRENOM", true));
            this.txtName.Location = new System.Drawing.Point(158, 130);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 22);
            this.txtName.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 133);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 17);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "&Prénom";
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vWPATIENTBindingSource, "PAT_DATE_NAISSANCE", true));
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
            this.lblBirthdate.Size = new System.Drawing.Size(126, 17);
            this.lblBirthdate.TabIndex = 7;
            this.lblBirthdate.Text = "&Date de naissance";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(14, 216);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(60, 17);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "A&dresse";
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vWPATIENTBindingSource, "PAT_ADRESSE", true));
            this.txtAddress.Location = new System.Drawing.Point(158, 216);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(213, 81);
            this.txtAddress.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vWPATIENTBindingSource, "PAT_EMAIL", true));
            this.txtEmail.Location = new System.Drawing.Point(158, 318);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(213, 22);
            this.txtEmail.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(14, 321);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(97, 17);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Adresse &email";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vWPATIENTBindingSource, "PAT_TELEPHONE", true));
            this.txtPhoneNumber.Location = new System.Drawing.Point(158, 361);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(213, 22);
            this.txtPhoneNumber.TabIndex = 14;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(14, 364);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(153, 17);
            this.lblPhoneNumber.TabIndex = 13;
            this.lblPhoneNumber.Text = "&Téléphone (format int.)";
            // 
            // lblNoAVS
            // 
            this.lblNoAVS.AutoSize = true;
            this.lblNoAVS.Location = new System.Drawing.Point(14, 47);
            this.lblNoAVS.Name = "lblNoAVS";
            this.lblNoAVS.Size = new System.Drawing.Size(57, 17);
            this.lblNoAVS.TabIndex = 1;
            this.lblNoAVS.Text = "&No AVS";
            // 
            // mtxNoAVS
            // 
            this.mtxNoAVS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vWPATIENTBindingSource, "PAT_NO_AVS", true));
            this.mtxNoAVS.Location = new System.Drawing.Point(158, 44);
            this.mtxNoAVS.Mask = "756.0000.0000.00";
            this.mtxNoAVS.Name = "mtxNoAVS";
            this.mtxNoAVS.Size = new System.Drawing.Size(213, 22);
            this.mtxNoAVS.TabIndex = 2;
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
            // vW_PATIENTTableAdapter
            // 
            this.vW_PATIENTTableAdapter.ClearBeforeFill = true;
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
            this.Controls.Add(this.mtxNoAVS);
            this.Controls.Add(this.lblNoAVS);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.dtpBirthdate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblAddEditPatient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAddEditPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REDOC - AJOUT/EDIT PATIENT";
            this.Load += new System.EventHandler(this.FrmAddEditPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vWPATIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRedoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddEditPatient;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblNoAVS;
        private System.Windows.Forms.MaskedTextBox mtxNoAVS;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private DataSetRedoc dataSetRedoc;
        private System.Windows.Forms.BindingSource vWPATIENTBindingSource;
        private DataSetRedocTableAdapters.VW_PATIENTTableAdapter vW_PATIENTTableAdapter;
    }
}