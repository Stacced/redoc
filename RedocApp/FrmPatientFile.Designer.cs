
namespace RedocApp
{
    partial class FrmPatientFile
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
            this.lblPatientFile = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txbSurname = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.dtpMain = new System.Windows.Forms.DateTimePicker();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.colDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCancelled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblAppointments = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPatientFile
            // 
            this.lblPatientFile.AutoSize = true;
            this.lblPatientFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientFile.Location = new System.Drawing.Point(12, 9);
            this.lblPatientFile.Name = "lblPatientFile";
            this.lblPatientFile.Size = new System.Drawing.Size(156, 25);
            this.lblPatientFile.TabIndex = 0;
            this.lblPatientFile.Text = "Dossier patient";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(14, 49);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(149, 17);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Nom ...........................";
            // 
            // txbSurname
            // 
            this.txbSurname.Enabled = false;
            this.txbSurname.Location = new System.Drawing.Point(163, 44);
            this.txbSurname.Name = "txbSurname";
            this.txbSurname.Size = new System.Drawing.Size(158, 22);
            this.txbSurname.TabIndex = 2;
            this.txbSurname.Text = "DUPONT";
            // 
            // txbName
            // 
            this.txbName.Enabled = false;
            this.txbName.Location = new System.Drawing.Point(163, 87);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(158, 22);
            this.txbName.TabIndex = 4;
            this.txbName.Text = "Jean";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 92);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(149, 17);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Prénom ......................";
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Location = new System.Drawing.Point(14, 135);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(194, 17);
            this.lblBirthdate.TabIndex = 5;
            this.lblBirthdate.Text = "Date de naissance ................";
            // 
            // dtpMain
            // 
            this.dtpMain.CustomFormat = "";
            this.dtpMain.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMain.Location = new System.Drawing.Point(209, 130);
            this.dtpMain.Name = "dtpMain";
            this.dtpMain.Size = new System.Drawing.Size(112, 22);
            this.dtpMain.TabIndex = 6;
            this.dtpMain.Value = new System.DateTime(1999, 12, 22, 0, 0, 0, 0);
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDateTime,
            this.colDoctor,
            this.colCancelled,
            this.colPayment});
            this.dgvAppointments.Location = new System.Drawing.Point(12, 278);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersWidth = 51;
            this.dgvAppointments.RowTemplate.Height = 24;
            this.dgvAppointments.Size = new System.Drawing.Size(588, 172);
            this.dgvAppointments.TabIndex = 8;
            // 
            // colDateTime
            // 
            this.colDateTime.HeaderText = "Date et heure";
            this.colDateTime.MinimumWidth = 6;
            this.colDateTime.Name = "colDateTime";
            this.colDateTime.ReadOnly = true;
            this.colDateTime.Width = 124;
            // 
            // colDoctor
            // 
            this.colDoctor.HeaderText = "Docteur";
            this.colDoctor.MinimumWidth = 6;
            this.colDoctor.Name = "colDoctor";
            this.colDoctor.ReadOnly = true;
            this.colDoctor.Width = 124;
            // 
            // colCancelled
            // 
            this.colCancelled.HeaderText = "Annulé";
            this.colCancelled.MinimumWidth = 6;
            this.colCancelled.Name = "colCancelled";
            this.colCancelled.ReadOnly = true;
            this.colCancelled.Width = 124;
            // 
            // colPayment
            // 
            this.colPayment.HeaderText = "Facturation";
            this.colPayment.MinimumWidth = 6;
            this.colPayment.Name = "colPayment";
            this.colPayment.ReadOnly = true;
            this.colPayment.Width = 124;
            // 
            // txbAddress
            // 
            this.txbAddress.Enabled = false;
            this.txbAddress.Location = new System.Drawing.Point(417, 44);
            this.txbAddress.Multiline = true;
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txbAddress.Size = new System.Drawing.Size(183, 67);
            this.txbAddress.TabIndex = 10;
            this.txbAddress.Text = "Chemin des Chênes 12\r\n1202 - Genève\r\nSuisse";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(335, 49);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(80, 17);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "Adresse ....";
            // 
            // lblAppointments
            // 
            this.lblAppointments.AutoSize = true;
            this.lblAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointments.Location = new System.Drawing.Point(8, 255);
            this.lblAppointments.Name = "lblAppointments";
            this.lblAppointments.Size = new System.Drawing.Size(196, 20);
            this.lblAppointments.TabIndex = 11;
            this.lblAppointments.Text = "Liste des rendez-vous";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(335, 135);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(82, 17);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email .........";
            // 
            // txbEmail
            // 
            this.txbEmail.Enabled = false;
            this.txbEmail.Location = new System.Drawing.Point(417, 130);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(183, 22);
            this.txbEmail.TabIndex = 13;
            this.txbEmail.Text = "jean@dupont.ch";
            // 
            // txbPhone
            // 
            this.txbPhone.Enabled = false;
            this.txbPhone.Location = new System.Drawing.Point(163, 173);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(158, 22);
            this.txbPhone.TabIndex = 15;
            this.txbPhone.Text = "+41 79 799 79 79";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(14, 178);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(148, 17);
            this.lblPhone.TabIndex = 14;
            this.lblPhone.Text = "Téléphone .................";
            // 
            // FrmPatientFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 462);
            this.Controls.Add(this.txbPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAppointments);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.dtpMain);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txbSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblPatientFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPatientFile";
            this.Text = "REDOC - Dossier patient";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPatientFile;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txbSurname;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.DateTimePicker dtpMain;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblAppointments;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoctor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCancelled;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayment;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.Label lblPhone;
    }
}