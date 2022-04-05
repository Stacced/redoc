
namespace RedocApp
{
    partial class FrmScheduler
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
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.cbxOldAppointments = new System.Windows.Forms.CheckBox();
            this.DateHeure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Docteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Annulé = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Facturation = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateHeure,
            this.Docteur,
            this.Patient,
            this.Annulé,
            this.Facturation});
            this.dgvAppointments.Location = new System.Drawing.Point(12, 91);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersWidth = 51;
            this.dgvAppointments.RowTemplate.Height = 24;
            this.dgvAppointments.Size = new System.Drawing.Size(758, 382);
            this.dgvAppointments.TabIndex = 4;
            this.dgvAppointments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointments_CellContentClick);
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAppointment.Location = new System.Drawing.Point(604, 18);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(166, 55);
            this.btnAddAppointment.TabIndex = 3;
            this.btnAddAppointment.Text = "Ajouter un RDV";
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(7, 18);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(115, 25);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Recherche";
            // 
            // txbSearch
            // 
            this.txbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSearch.Location = new System.Drawing.Point(138, 21);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(271, 22);
            this.txbSearch.TabIndex = 1;
            // 
            // cbxOldAppointments
            // 
            this.cbxOldAppointments.AutoSize = true;
            this.cbxOldAppointments.Location = new System.Drawing.Point(12, 58);
            this.cbxOldAppointments.Name = "cbxOldAppointments";
            this.cbxOldAppointments.Size = new System.Drawing.Size(207, 21);
            this.cbxOldAppointments.TabIndex = 2;
            this.cbxOldAppointments.Text = "Afficher rendez-vous passés";
            this.cbxOldAppointments.UseVisualStyleBackColor = true;
            // 
            // DateHeure
            // 
            this.DateHeure.HeaderText = "Date & heure";
            this.DateHeure.MinimumWidth = 6;
            this.DateHeure.Name = "DateHeure";
            this.DateHeure.ReadOnly = true;
            this.DateHeure.Width = 124;
            // 
            // Docteur
            // 
            this.Docteur.HeaderText = "Docteur";
            this.Docteur.MinimumWidth = 6;
            this.Docteur.Name = "Docteur";
            this.Docteur.ReadOnly = true;
            this.Docteur.Width = 124;
            // 
            // Patient
            // 
            this.Patient.HeaderText = "Patient";
            this.Patient.MinimumWidth = 6;
            this.Patient.Name = "Patient";
            this.Patient.ReadOnly = true;
            this.Patient.Width = 124;
            // 
            // Annulé
            // 
            this.Annulé.HeaderText = "Annulé";
            this.Annulé.MinimumWidth = 6;
            this.Annulé.Name = "Annulé";
            this.Annulé.ReadOnly = true;
            this.Annulé.Width = 124;
            // 
            // Facturation
            // 
            this.Facturation.HeaderText = "Facturation";
            this.Facturation.MinimumWidth = 6;
            this.Facturation.Name = "Facturation";
            this.Facturation.ReadOnly = true;
            this.Facturation.Text = "Facturation";
            this.Facturation.Width = 124;
            // 
            // FrmScheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 485);
            this.Controls.Add(this.cbxOldAppointments);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.dgvAppointments);
            this.Name = "FrmScheduler";
            this.Text = "REDOC - Calendrier des rendez-vous";
            this.Load += new System.EventHandler(this.FrmScheduler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.CheckBox cbxOldAppointments;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateHeure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Docteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patient;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Annulé;
        private System.Windows.Forms.DataGridViewButtonColumn Facturation;
    }
}