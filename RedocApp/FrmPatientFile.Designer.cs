
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
            this.components = new System.ComponentModel.Container();
            this.lblPatientFile = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.vWPATIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRedoc = new RedocApp.DataSetRedoc();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.dtpMain = new System.Windows.Forms.DateTimePicker();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.rENNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rENDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCNOMCOMPLETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rENANNULEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rENCOMMENTAIREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vWRENDEZVOUSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblAppointments = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtNoAvs = new System.Windows.Forms.TextBox();
            this.lblNoAvs = new System.Windows.Forms.Label();
            this.vW_PATIENTTableAdapter = new RedocApp.DataSetRedocTableAdapters.VW_PATIENTTableAdapter();
            this.vW_RENDEZVOUSTableAdapter = new RedocApp.DataSetRedocTableAdapters.VW_RENDEZVOUSTableAdapter();
            this.llbEditPatient = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.vWPATIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRedoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWRENDEZVOUSBindingSource)).BeginInit();
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
            this.lblSurname.Location = new System.Drawing.Point(13, 49);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(149, 17);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Nom ...........................";
            // 
            // txtSurname
            // 
            this.txtSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vWPATIENTBindingSource, "PAT_NOM", true));
            this.txtSurname.Enabled = false;
            this.txtSurname.Location = new System.Drawing.Point(163, 44);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(159, 22);
            this.txtSurname.TabIndex = 2;
            this.txtSurname.Text = "DUPONT";
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
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(163, 87);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(159, 22);
            this.txtName.TabIndex = 4;
            this.txtName.Text = "Jean";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 92);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(149, 17);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Prénom ......................";
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Location = new System.Drawing.Point(13, 135);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(194, 17);
            this.lblBirthdate.TabIndex = 5;
            this.lblBirthdate.Text = "Date de naissance ................";
            // 
            // dtpMain
            // 
            this.dtpMain.CustomFormat = "";
            this.dtpMain.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vWPATIENTBindingSource, "PAT_DATE_NAISSANCE", true));
            this.dtpMain.Enabled = false;
            this.dtpMain.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMain.Location = new System.Drawing.Point(209, 130);
            this.dtpMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpMain.Name = "dtpMain";
            this.dtpMain.Size = new System.Drawing.Size(112, 22);
            this.dtpMain.TabIndex = 6;
            this.dtpMain.Value = new System.DateTime(1999, 12, 22, 0, 0, 0, 0);
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAppointments.AutoGenerateColumns = false;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rENNODataGridViewTextBoxColumn,
            this.rENDATEDataGridViewTextBoxColumn,
            this.dOCNOMCOMPLETDataGridViewTextBoxColumn,
            this.rENANNULEDataGridViewTextBoxColumn,
            this.rENCOMMENTAIREDataGridViewTextBoxColumn});
            this.dgvAppointments.DataSource = this.vWRENDEZVOUSBindingSource;
            this.dgvAppointments.Location = new System.Drawing.Point(12, 278);
            this.dgvAppointments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersWidth = 51;
            this.dgvAppointments.RowTemplate.Height = 24;
            this.dgvAppointments.Size = new System.Drawing.Size(700, 196);
            this.dgvAppointments.TabIndex = 14;
            this.dgvAppointments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointments_CellContentClick);
            // 
            // rENNODataGridViewTextBoxColumn
            // 
            this.rENNODataGridViewTextBoxColumn.DataPropertyName = "REN_NO";
            this.rENNODataGridViewTextBoxColumn.HeaderText = "REN_NO";
            this.rENNODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rENNODataGridViewTextBoxColumn.Name = "rENNODataGridViewTextBoxColumn";
            this.rENNODataGridViewTextBoxColumn.ReadOnly = true;
            this.rENNODataGridViewTextBoxColumn.Width = 124;
            // 
            // rENDATEDataGridViewTextBoxColumn
            // 
            this.rENDATEDataGridViewTextBoxColumn.DataPropertyName = "REN_DATE";
            this.rENDATEDataGridViewTextBoxColumn.HeaderText = "REN_DATE";
            this.rENDATEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rENDATEDataGridViewTextBoxColumn.Name = "rENDATEDataGridViewTextBoxColumn";
            this.rENDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.rENDATEDataGridViewTextBoxColumn.Width = 124;
            // 
            // dOCNOMCOMPLETDataGridViewTextBoxColumn
            // 
            this.dOCNOMCOMPLETDataGridViewTextBoxColumn.DataPropertyName = "DOC_NOM_COMPLET";
            this.dOCNOMCOMPLETDataGridViewTextBoxColumn.HeaderText = "DOC_NOM_COMPLET";
            this.dOCNOMCOMPLETDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOCNOMCOMPLETDataGridViewTextBoxColumn.Name = "dOCNOMCOMPLETDataGridViewTextBoxColumn";
            this.dOCNOMCOMPLETDataGridViewTextBoxColumn.ReadOnly = true;
            this.dOCNOMCOMPLETDataGridViewTextBoxColumn.Width = 124;
            // 
            // rENANNULEDataGridViewTextBoxColumn
            // 
            this.rENANNULEDataGridViewTextBoxColumn.DataPropertyName = "REN_ANNULE";
            this.rENANNULEDataGridViewTextBoxColumn.HeaderText = "REN_ANNULE";
            this.rENANNULEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rENANNULEDataGridViewTextBoxColumn.Name = "rENANNULEDataGridViewTextBoxColumn";
            this.rENANNULEDataGridViewTextBoxColumn.ReadOnly = true;
            this.rENANNULEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rENANNULEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.rENANNULEDataGridViewTextBoxColumn.Width = 124;
            // 
            // rENCOMMENTAIREDataGridViewTextBoxColumn
            // 
            this.rENCOMMENTAIREDataGridViewTextBoxColumn.DataPropertyName = "REN_COMMENTAIRE";
            this.rENCOMMENTAIREDataGridViewTextBoxColumn.HeaderText = "REN_COMMENTAIRE";
            this.rENCOMMENTAIREDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rENCOMMENTAIREDataGridViewTextBoxColumn.Name = "rENCOMMENTAIREDataGridViewTextBoxColumn";
            this.rENCOMMENTAIREDataGridViewTextBoxColumn.ReadOnly = true;
            this.rENCOMMENTAIREDataGridViewTextBoxColumn.Width = 124;
            // 
            // vWRENDEZVOUSBindingSource
            // 
            this.vWRENDEZVOUSBindingSource.DataMember = "VW_RENDEZVOUS";
            this.vWRENDEZVOUSBindingSource.DataSource = this.dataSetRedoc;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vWPATIENTBindingSource, "PAT_ADRESSE", true));
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(508, 46);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtAddress.Size = new System.Drawing.Size(203, 67);
            this.txtAddress.TabIndex = 10;
            this.txtAddress.Text = "Chemin des Chênes 12\r\n1202 - Genève\r\nSuisse";
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(420, 49);
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
            this.lblAppointments.TabIndex = 13;
            this.lblAppointments.Text = "Liste des rendez-vous";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(420, 135);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(82, 17);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email .........";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vWPATIENTBindingSource, "PAT_EMAIL", true));
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(508, 130);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(203, 22);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.Text = "jean@dupont.ch";
            // 
            // txtPhone
            // 
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vWPATIENTBindingSource, "PAT_TELEPHONE", true));
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(163, 174);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(159, 22);
            this.txtPhone.TabIndex = 8;
            this.txtPhone.Text = "+41 79 799 79 79";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(13, 178);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(148, 17);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "Téléphone .................";
            // 
            // txtNoAvs
            // 
            this.txtNoAvs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoAvs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vWPATIENTBindingSource, "PAT_NO_AVS", true));
            this.txtNoAvs.Enabled = false;
            this.txtNoAvs.Location = new System.Drawing.Point(508, 174);
            this.txtNoAvs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNoAvs.Name = "txtNoAvs";
            this.txtNoAvs.Size = new System.Drawing.Size(203, 22);
            this.txtNoAvs.TabIndex = 17;
            this.txtNoAvs.Text = "756.1234.5678.1";
            // 
            // lblNoAvs
            // 
            this.lblNoAvs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoAvs.AutoSize = true;
            this.lblNoAvs.Location = new System.Drawing.Point(420, 179);
            this.lblNoAvs.Name = "lblNoAvs";
            this.lblNoAvs.Size = new System.Drawing.Size(79, 17);
            this.lblNoAvs.TabIndex = 16;
            this.lblNoAvs.Text = "N° AVS .....";
            // 
            // vW_PATIENTTableAdapter
            // 
            this.vW_PATIENTTableAdapter.ClearBeforeFill = true;
            // 
            // vW_RENDEZVOUSTableAdapter
            // 
            this.vW_RENDEZVOUSTableAdapter.ClearBeforeFill = true;
            // 
            // llbEditPatient
            // 
            this.llbEditPatient.AutoSize = true;
            this.llbEditPatient.Location = new System.Drawing.Point(642, 16);
            this.llbEditPatient.Name = "llbEditPatient";
            this.llbEditPatient.Size = new System.Drawing.Size(70, 17);
            this.llbEditPatient.TabIndex = 18;
            this.llbEditPatient.TabStop = true;
            this.llbEditPatient.Text = "Modifier...";
            this.llbEditPatient.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbEditPatient_LinkClicked);
            // 
            // FrmPatientFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 486);
            this.Controls.Add(this.llbEditPatient);
            this.Controls.Add(this.txtNoAvs);
            this.Controls.Add(this.lblNoAvs);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAppointments);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.dtpMain);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblPatientFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmPatientFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REDOC - Dossier patient";
            this.Load += new System.EventHandler(this.FrmPatientFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vWPATIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRedoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWRENDEZVOUSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPatientFile;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.DateTimePicker dtpMain;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblAppointments;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private DataSetRedocTableAdapters.VW_PATIENTTableAdapter vW_PATIENTTableAdapter;
        private DataSetRedoc dataSetRedoc;
        private System.Windows.Forms.BindingSource vWPATIENTBindingSource;
        private System.Windows.Forms.TextBox txtNoAvs;
        private System.Windows.Forms.Label lblNoAvs;
        private System.Windows.Forms.BindingSource vWRENDEZVOUSBindingSource;
        private DataSetRedocTableAdapters.VW_RENDEZVOUSTableAdapter vW_RENDEZVOUSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rENNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rENDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCNOMCOMPLETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rENANNULEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rENCOMMENTAIREDataGridViewTextBoxColumn;
        private System.Windows.Forms.LinkLabel llbEditPatient;
    }
}