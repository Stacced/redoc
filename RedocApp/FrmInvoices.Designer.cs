
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
            this.components = new System.ComponentModel.Container();
            this.adgvInvoices = new Zuby.ADGV.AdvancedDataGridView();
            this.adgvSearch = new Zuby.ADGV.AdvancedDataGridViewSearchToolBar();
            this.vWFACTUREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRedoc = new RedocApp.DataSetRedoc();
            this.vW_FACTURETableAdapter = new RedocApp.DataSetRedocTableAdapters.VW_FACTURETableAdapter();
            this.fACNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATNOMCOMPLETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fACDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fACPAYEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fACTOTALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.adgvInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWFACTUREBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRedoc)).BeginInit();
            this.SuspendLayout();
            // 
            // adgvInvoices
            // 
            this.adgvInvoices.AllowUserToAddRows = false;
            this.adgvInvoices.AllowUserToDeleteRows = false;
            this.adgvInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adgvInvoices.AutoGenerateColumns = false;
            this.adgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgvInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fACNODataGridViewTextBoxColumn,
            this.pATNOMCOMPLETDataGridViewTextBoxColumn,
            this.fACDATEDataGridViewTextBoxColumn,
            this.fACPAYEDataGridViewTextBoxColumn,
            this.fACTOTALDataGridViewTextBoxColumn});
            this.adgvInvoices.DataSource = this.vWFACTUREBindingSource;
            this.adgvInvoices.FilterAndSortEnabled = true;
            this.adgvInvoices.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.adgvInvoices.Location = new System.Drawing.Point(0, 56);
            this.adgvInvoices.Name = "adgvInvoices";
            this.adgvInvoices.ReadOnly = true;
            this.adgvInvoices.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adgvInvoices.RowHeadersWidth = 51;
            this.adgvInvoices.RowTemplate.Height = 24;
            this.adgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adgvInvoices.Size = new System.Drawing.Size(1035, 458);
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
            this.adgvSearch.Search += new Zuby.ADGV.AdvancedDataGridViewSearchToolBarSearchEventHandler(this.adgvSearch_Search);
            // 
            // vWFACTUREBindingSource
            // 
            this.vWFACTUREBindingSource.DataMember = "VW_FACTURE";
            this.vWFACTUREBindingSource.DataSource = this.dataSetRedoc;
            // 
            // dataSetRedoc
            // 
            this.dataSetRedoc.DataSetName = "DataSetRedoc";
            this.dataSetRedoc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vW_FACTURETableAdapter
            // 
            this.vW_FACTURETableAdapter.ClearBeforeFill = true;
            // 
            // fACNODataGridViewTextBoxColumn
            // 
            this.fACNODataGridViewTextBoxColumn.DataPropertyName = "FAC_NO";
            this.fACNODataGridViewTextBoxColumn.HeaderText = "FAC_NO";
            this.fACNODataGridViewTextBoxColumn.MinimumWidth = 22;
            this.fACNODataGridViewTextBoxColumn.Name = "fACNODataGridViewTextBoxColumn";
            this.fACNODataGridViewTextBoxColumn.ReadOnly = true;
            this.fACNODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.fACNODataGridViewTextBoxColumn.Width = 124;
            // 
            // pATNOMCOMPLETDataGridViewTextBoxColumn
            // 
            this.pATNOMCOMPLETDataGridViewTextBoxColumn.DataPropertyName = "PAT_NOM_COMPLET";
            this.pATNOMCOMPLETDataGridViewTextBoxColumn.HeaderText = "PAT_NOM_COMPLET";
            this.pATNOMCOMPLETDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pATNOMCOMPLETDataGridViewTextBoxColumn.Name = "pATNOMCOMPLETDataGridViewTextBoxColumn";
            this.pATNOMCOMPLETDataGridViewTextBoxColumn.ReadOnly = true;
            this.pATNOMCOMPLETDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.pATNOMCOMPLETDataGridViewTextBoxColumn.Width = 124;
            // 
            // fACDATEDataGridViewTextBoxColumn
            // 
            this.fACDATEDataGridViewTextBoxColumn.DataPropertyName = "FAC_DATE";
            this.fACDATEDataGridViewTextBoxColumn.HeaderText = "FAC_DATE";
            this.fACDATEDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.fACDATEDataGridViewTextBoxColumn.Name = "fACDATEDataGridViewTextBoxColumn";
            this.fACDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.fACDATEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fACDATEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.fACDATEDataGridViewTextBoxColumn.Width = 124;
            // 
            // fACPAYEDataGridViewTextBoxColumn
            // 
            this.fACPAYEDataGridViewTextBoxColumn.DataPropertyName = "FAC_PAYE";
            this.fACPAYEDataGridViewTextBoxColumn.HeaderText = "FAC_PAYE";
            this.fACPAYEDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.fACPAYEDataGridViewTextBoxColumn.Name = "fACPAYEDataGridViewTextBoxColumn";
            this.fACPAYEDataGridViewTextBoxColumn.ReadOnly = true;
            this.fACPAYEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fACPAYEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.fACPAYEDataGridViewTextBoxColumn.Width = 124;
            // 
            // fACTOTALDataGridViewTextBoxColumn
            // 
            this.fACTOTALDataGridViewTextBoxColumn.DataPropertyName = "FAC_TOTAL";
            this.fACTOTALDataGridViewTextBoxColumn.HeaderText = "FAC_TOTAL";
            this.fACTOTALDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.fACTOTALDataGridViewTextBoxColumn.Name = "fACTOTALDataGridViewTextBoxColumn";
            this.fACTOTALDataGridViewTextBoxColumn.ReadOnly = true;
            this.fACTOTALDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.fACTOTALDataGridViewTextBoxColumn.Width = 124;
            // 
            // FrmInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 514);
            this.Controls.Add(this.adgvSearch);
            this.Controls.Add(this.adgvInvoices);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(725, 552);
            this.Name = "FrmInvoices";
            this.Text = "REDOC - Facturation";
            this.Load += new System.EventHandler(this.FrmInvoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adgvInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWFACTUREBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRedoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Zuby.ADGV.AdvancedDataGridView adgvInvoices;
        private Zuby.ADGV.AdvancedDataGridViewSearchToolBar adgvSearch;
        private DataSetRedoc dataSetRedoc;
        private System.Windows.Forms.BindingSource vWFACTUREBindingSource;
        private DataSetRedocTableAdapters.VW_FACTURETableAdapter vW_FACTURETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fACNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATNOMCOMPLETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fACDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fACPAYEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fACTOTALDataGridViewTextBoxColumn;
    }
}