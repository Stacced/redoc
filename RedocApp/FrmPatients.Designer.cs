
namespace RedocApp
{
    partial class FrmPatients
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.colPatientFile = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoAVS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddPatient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(158, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(691, 22);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(12, 16);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(115, 25);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "&Recherche";
            // 
            // dgvPatients
            // 
            this.dgvPatients.AllowUserToAddRows = false;
            this.dgvPatients.AllowUserToDeleteRows = false;
            this.dgvPatients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPatientFile,
            this.colSurname,
            this.colName,
            this.colNoAVS,
            this.colBirthdate,
            this.colAddress,
            this.colEmail,
            this.colPhone});
            this.dgvPatients.Location = new System.Drawing.Point(17, 64);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.ReadOnly = true;
            this.dgvPatients.RowHeadersWidth = 51;
            this.dgvPatients.RowTemplate.Height = 24;
            this.dgvPatients.Size = new System.Drawing.Size(1058, 431);
            this.dgvPatients.TabIndex = 3;
            this.dgvPatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatients_CellContentClick);
            // 
            // colPatientFile
            // 
            this.colPatientFile.HeaderText = "Dossier";
            this.colPatientFile.MinimumWidth = 6;
            this.colPatientFile.Name = "colPatientFile";
            this.colPatientFile.ReadOnly = true;
            this.colPatientFile.Text = "Voir dossier";
            this.colPatientFile.Width = 124;
            // 
            // colSurname
            // 
            this.colSurname.HeaderText = "Nom";
            this.colSurname.MinimumWidth = 6;
            this.colSurname.Name = "colSurname";
            this.colSurname.ReadOnly = true;
            this.colSurname.Width = 124;
            // 
            // colName
            // 
            this.colName.HeaderText = "Prénom";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 124;
            // 
            // colNoAVS
            // 
            this.colNoAVS.HeaderText = "No AVS";
            this.colNoAVS.MinimumWidth = 6;
            this.colNoAVS.Name = "colNoAVS";
            this.colNoAVS.ReadOnly = true;
            this.colNoAVS.Width = 124;
            // 
            // colBirthdate
            // 
            this.colBirthdate.HeaderText = "Date de naissance";
            this.colBirthdate.MinimumWidth = 6;
            this.colBirthdate.Name = "colBirthdate";
            this.colBirthdate.ReadOnly = true;
            this.colBirthdate.Width = 124;
            // 
            // colAddress
            // 
            this.colAddress.HeaderText = "Adresse";
            this.colAddress.MinimumWidth = 6;
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            this.colAddress.Width = 124;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 124;
            // 
            // colPhone
            // 
            this.colPhone.HeaderText = "Téléphone";
            this.colPhone.MinimumWidth = 6;
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            this.colPhone.Width = 124;
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPatient.Location = new System.Drawing.Point(880, 15);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(194, 30);
            this.btnAddPatient.TabIndex = 2;
            this.btnAddPatient.Text = "&Ajouter un patient";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // FrmPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 507);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.dgvPatients);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.MinimumSize = new System.Drawing.Size(725, 553);
            this.Name = "FrmPatients";
            this.Text = "REDOC - Gestion des patients";
            this.Load += new System.EventHandler(this.FrmPatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.DataGridViewButtonColumn colPatientFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoAVS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBirthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
    }
}