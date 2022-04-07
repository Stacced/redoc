
namespace RedocApp
{
    partial class FrmAddEditAppointment
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
            this.lblAddEditAppointment = new System.Windows.Forms.Label();
            this.dtpMain = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblPatient = new System.Windows.Forms.Label();
            this.cmbPatient = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txbNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAddEditAppointment
            // 
            this.lblAddEditAppointment.AutoSize = true;
            this.lblAddEditAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.91597F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEditAppointment.Location = new System.Drawing.Point(12, 9);
            this.lblAddEditAppointment.Name = "lblAddEditAppointment";
            this.lblAddEditAppointment.Size = new System.Drawing.Size(423, 29);
            this.lblAddEditAppointment.TabIndex = 0;
            this.lblAddEditAppointment.Text = "Ajout / modification de rendez-vous";
            // 
            // dtpMain
            // 
            this.dtpMain.CustomFormat = "dddd dd MMMM yyyy HH:mm tt";
            this.dtpMain.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMain.Location = new System.Drawing.Point(158, 51);
            this.dtpMain.Name = "dtpMain";
            this.dtpMain.Size = new System.Drawing.Size(277, 22);
            this.dtpMain.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(14, 56);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(123, 16);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date et &heure ...........";
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(158, 93);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(277, 24);
            this.cmbDoctor.TabIndex = 4;
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Location = new System.Drawing.Point(14, 98);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(117, 16);
            this.lblDoctor.TabIndex = 3;
            this.lblDoctor.Text = "&Docteur ....................";
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(14, 140);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(114, 16);
            this.lblPatient.TabIndex = 5;
            this.lblPatient.Text = "&Patient .....................";
            // 
            // cmbPatient
            // 
            this.cmbPatient.FormattingEnabled = true;
            this.cmbPatient.Location = new System.Drawing.Point(158, 137);
            this.cmbPatient.Name = "cmbPatient";
            this.cmbPatient.Size = new System.Drawing.Size(277, 24);
            this.cmbPatient.TabIndex = 6;
            // 
            // btnConfirm
            // 
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirm.Location = new System.Drawing.Point(279, 345);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(156, 50);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "&Valider";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(17, 345);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(156, 50);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "&Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txbNotes
            // 
            this.txbNotes.Location = new System.Drawing.Point(17, 208);
            this.txbNotes.Multiline = true;
            this.txbNotes.Name = "txbNotes";
            this.txbNotes.Size = new System.Drawing.Size(418, 121);
            this.txbNotes.TabIndex = 8;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(14, 188);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(43, 16);
            this.lblNotes.TabIndex = 7;
            this.lblNotes.Text = "&Notes";
            // 
            // FrmAddEditAppointment
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(452, 407);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txbNotes);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.cmbPatient);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.cmbDoctor);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpMain);
            this.Controls.Add(this.lblAddEditAppointment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAddEditAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "REDOC - AJOUT/EDIT RDV";
            this.Load += new System.EventHandler(this.FrmAddEditAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddEditAppointment;
        private System.Windows.Forms.DateTimePicker dtpMain;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.ComboBox cmbPatient;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txbNotes;
        private System.Windows.Forms.Label lblNotes;
    }
}