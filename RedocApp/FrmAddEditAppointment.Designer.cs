
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
            this.components = new System.ComponentModel.Container();
            this.lblAddEditAppointment = new System.Windows.Forms.Label();
            this.dtpMain = new System.Windows.Forms.DateTimePicker();
            this.vWRENDEZVOUSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRedoc = new RedocApp.DataSetRedoc();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.vWDOCTEURBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblPatient = new System.Windows.Forms.Label();
            this.cmbPatient = new System.Windows.Forms.ComboBox();
            this.vWPATIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txbNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.vW_DOCTEURTableAdapter = new RedocApp.DataSetRedocTableAdapters.VW_DOCTEURTableAdapter();
            this.vW_PATIENTTableAdapter = new RedocApp.DataSetRedocTableAdapters.VW_PATIENTTableAdapter();
            this.vW_RENDEZVOUSTableAdapter = new RedocApp.DataSetRedocTableAdapters.VW_RENDEZVOUSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vWRENDEZVOUSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRedoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWDOCTEURBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWPATIENTBindingSource)).BeginInit();
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
            this.dtpMain.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vWRENDEZVOUSBindingSource, "REN_DATE", true));
            this.dtpMain.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMain.Location = new System.Drawing.Point(158, 51);
            this.dtpMain.Name = "dtpMain";
            this.dtpMain.Size = new System.Drawing.Size(277, 22);
            this.dtpMain.TabIndex = 2;
            // 
            // vWRENDEZVOUSBindingSource
            // 
            this.vWRENDEZVOUSBindingSource.DataMember = "VW_RENDEZVOUS";
            this.vWRENDEZVOUSBindingSource.DataSource = this.dataSetRedoc;
            // 
            // dataSetRedoc
            // 
            this.dataSetRedoc.DataSetName = "DataSetRedoc";
            this.dataSetRedoc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(14, 56);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(143, 17);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date et &heure ...........";
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vWRENDEZVOUSBindingSource, "DOC_NO", true));
            this.cmbDoctor.DataSource = this.vWDOCTEURBindingSource;
            this.cmbDoctor.DisplayMember = "DOC_NOM_COMPLET";
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(158, 93);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(277, 24);
            this.cmbDoctor.TabIndex = 4;
            this.cmbDoctor.ValueMember = "DOC_NO";
            // 
            // vWDOCTEURBindingSource
            // 
            this.vWDOCTEURBindingSource.DataMember = "VW_DOCTEUR";
            this.vWDOCTEURBindingSource.DataSource = this.dataSetRedoc;
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Location = new System.Drawing.Point(14, 98);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(142, 17);
            this.lblDoctor.TabIndex = 3;
            this.lblDoctor.Text = "&Docteur ....................";
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(14, 140);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(140, 17);
            this.lblPatient.TabIndex = 5;
            this.lblPatient.Text = "&Patient .....................";
            // 
            // cmbPatient
            // 
            this.cmbPatient.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vWRENDEZVOUSBindingSource, "PAT_NO", true));
            this.cmbPatient.DataSource = this.vWPATIENTBindingSource;
            this.cmbPatient.DisplayMember = "PAT_NOM_COMPLET";
            this.cmbPatient.FormattingEnabled = true;
            this.cmbPatient.Location = new System.Drawing.Point(158, 137);
            this.cmbPatient.Name = "cmbPatient";
            this.cmbPatient.Size = new System.Drawing.Size(277, 24);
            this.cmbPatient.TabIndex = 6;
            this.cmbPatient.ValueMember = "PAT_NO";
            // 
            // vWPATIENTBindingSource
            // 
            this.vWPATIENTBindingSource.DataMember = "VW_PATIENT";
            this.vWPATIENTBindingSource.DataSource = this.dataSetRedoc;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(279, 345);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(156, 50);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "&Valider";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
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
            this.txbNotes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vWRENDEZVOUSBindingSource, "REN_COMMENTAIRE", true));
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
            this.lblNotes.Size = new System.Drawing.Size(45, 17);
            this.lblNotes.TabIndex = 7;
            this.lblNotes.Text = "&Notes";
            // 
            // vW_DOCTEURTableAdapter
            // 
            this.vW_DOCTEURTableAdapter.ClearBeforeFill = true;
            // 
            // vW_PATIENTTableAdapter
            // 
            this.vW_PATIENTTableAdapter.ClearBeforeFill = true;
            // 
            // vW_RENDEZVOUSTableAdapter
            // 
            this.vW_RENDEZVOUSTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAddEditAppointment
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(455, 415);
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
            this.Text = "REDOC - Ajout / modification RDV";
            this.Load += new System.EventHandler(this.FrmAddEditAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vWRENDEZVOUSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRedoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWDOCTEURBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWPATIENTBindingSource)).EndInit();
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
        private DataSetRedoc dataSetRedoc;
        private System.Windows.Forms.BindingSource vWDOCTEURBindingSource;
        private DataSetRedocTableAdapters.VW_DOCTEURTableAdapter vW_DOCTEURTableAdapter;
        private System.Windows.Forms.BindingSource vWPATIENTBindingSource;
        private DataSetRedocTableAdapters.VW_PATIENTTableAdapter vW_PATIENTTableAdapter;
        private System.Windows.Forms.BindingSource vWRENDEZVOUSBindingSource;
        private DataSetRedocTableAdapters.VW_RENDEZVOUSTableAdapter vW_RENDEZVOUSTableAdapter;
    }
}