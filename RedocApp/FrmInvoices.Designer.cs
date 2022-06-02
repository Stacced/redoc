
namespace RedocApp
{
    partial class FrmInvoices
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
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.colPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAppointmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.adgvInvoices = new Zuby.ADGV.AdvancedDataGridView();
            this.adgvSearch = new Zuby.ADGV.AdvancedDataGridViewSearchToolBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adgvInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AllowUserToAddRows = false;
            this.dgvInvoices.AllowUserToDeleteRows = false;
            this.dgvInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPatientName,
            this.colAppointmentId,
            this.colInvoiceDetails});
            this.dgvInvoices.Location = new System.Drawing.Point(17, 62);
            this.dgvInvoices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.ReadOnly = true;
            this.dgvInvoices.RowHeadersWidth = 51;
            this.dgvInvoices.RowTemplate.Height = 24;
            this.dgvInvoices.Size = new System.Drawing.Size(1003, 439);
            this.dgvInvoices.TabIndex = 2;
            this.dgvInvoices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatients_CellContentClick);
            // 
            // colPatientName
            // 
            this.colPatientName.HeaderText = "Patient";
            this.colPatientName.MinimumWidth = 6;
            this.colPatientName.Name = "colPatientName";
            this.colPatientName.ReadOnly = true;
            this.colPatientName.Width = 124;
            // 
            // colAppointmentId
            // 
            this.colAppointmentId.HeaderText = "ID RDV";
            this.colAppointmentId.MinimumWidth = 6;
            this.colAppointmentId.Name = "colAppointmentId";
            this.colAppointmentId.ReadOnly = true;
            this.colAppointmentId.Width = 124;
            // 
            // colInvoiceDetails
            // 
            this.colInvoiceDetails.HeaderText = "Voir détails";
            this.colInvoiceDetails.MinimumWidth = 6;
            this.colInvoiceDetails.Name = "colInvoiceDetails";
            this.colInvoiceDetails.ReadOnly = true;
            this.colInvoiceDetails.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colInvoiceDetails.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colInvoiceDetails.Text = "Voir détails";
            this.colInvoiceDetails.Width = 124;
            // 
            // adgvInvoices
            // 
            this.adgvInvoices.AllowUserToAddRows = false;
            this.adgvInvoices.AllowUserToDeleteRows = false;
            this.adgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgvInvoices.FilterAndSortEnabled = true;
            this.adgvInvoices.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.adgvInvoices.Location = new System.Drawing.Point(17, 92);
            this.adgvInvoices.Name = "adgvInvoices";
            this.adgvInvoices.ReadOnly = true;
            this.adgvInvoices.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adgvInvoices.RowHeadersWidth = 51;
            this.adgvInvoices.RowTemplate.Height = 24;
            this.adgvInvoices.Size = new System.Drawing.Size(1003, 409);
            this.adgvInvoices.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.adgvInvoices.TabIndex = 3;
            // 
            // adgvSearch
            // 
            this.adgvSearch.AllowMerge = false;
            this.adgvSearch.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.adgvSearch.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.adgvSearch.Location = new System.Drawing.Point(0, 0);
            this.adgvSearch.MaximumSize = new System.Drawing.Size(0, 27);
            this.adgvSearch.MinimumSize = new System.Drawing.Size(0, 27);
            this.adgvSearch.Name = "adgvSearch";
            this.adgvSearch.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.adgvSearch.Size = new System.Drawing.Size(1035, 27);
            this.adgvSearch.TabIndex = 4;
            this.adgvSearch.Text = "advancedDataGridViewSearchToolBar1";
            // 
            // FrmInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 514);
            this.Controls.Add(this.adgvSearch);
            this.Controls.Add(this.adgvInvoices);
            this.Controls.Add(this.dgvInvoices);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(725, 552);
            this.Name = "FrmInvoices";
            this.Text = "REDOC - Facturation";
            this.Load += new System.EventHandler(this.FrmInvoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adgvInvoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAppointmentId;
        private System.Windows.Forms.DataGridViewButtonColumn colInvoiceDetails;
        private Zuby.ADGV.AdvancedDataGridView adgvInvoices;
        private Zuby.ADGV.AdvancedDataGridViewSearchToolBar adgvSearch;
    }
}