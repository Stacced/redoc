
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
            this.components = new System.ComponentModel.Container();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.adgvPatients = new Zuby.ADGV.AdvancedDataGridView();
            this.adgvSearch = new Zuby.ADGV.AdvancedDataGridViewSearchToolBar();
            this.dataSetRedoc = new RedocApp.DataSetRedoc();
            this.vWPATIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vW_PATIENTTableAdapter = new RedocApp.DataSetRedocTableAdapters.VW_PATIENTTableAdapter();
            this.pATNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATNOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATPRENOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATNOMCOMPLETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATDATENAISSANCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATADRESSEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATTELEPHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATNOAVSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.adgvPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRedoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWPATIENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPatient.Location = new System.Drawing.Point(772, 39);
            this.btnAddPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(195, 30);
            this.btnAddPatient.TabIndex = 2;
            this.btnAddPatient.Text = "&Ajouter un patient";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // adgvPatients
            // 
            this.adgvPatients.AllowUserToAddRows = false;
            this.adgvPatients.AllowUserToDeleteRows = false;
            this.adgvPatients.AutoGenerateColumns = false;
            this.adgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgvPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pATNODataGridViewTextBoxColumn,
            this.pATNOMDataGridViewTextBoxColumn,
            this.pATPRENOMDataGridViewTextBoxColumn,
            this.pATNOMCOMPLETDataGridViewTextBoxColumn,
            this.pATDATENAISSANCEDataGridViewTextBoxColumn,
            this.pATADRESSEDataGridViewTextBoxColumn,
            this.pATEMAILDataGridViewTextBoxColumn,
            this.pATTELEPHONEDataGridViewTextBoxColumn,
            this.pATNOAVSDataGridViewTextBoxColumn});
            this.adgvPatients.DataSource = this.vWPATIENTBindingSource;
            this.adgvPatients.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.adgvPatients.FilterAndSortEnabled = true;
            this.adgvPatients.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.adgvPatients.Location = new System.Drawing.Point(0, 83);
            this.adgvPatients.Name = "adgvPatients";
            this.adgvPatients.ReadOnly = true;
            this.adgvPatients.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adgvPatients.RowHeadersWidth = 51;
            this.adgvPatients.RowTemplate.Height = 24;
            this.adgvPatients.Size = new System.Drawing.Size(979, 354);
            this.adgvPatients.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.adgvPatients.TabIndex = 4;
            this.adgvPatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adgvPatients_CellContentClick);
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
            this.adgvSearch.Size = new System.Drawing.Size(979, 27);
            this.adgvSearch.TabIndex = 5;
            this.adgvSearch.Text = "advancedDataGridViewSearchToolBar1";
            this.adgvSearch.Search += new Zuby.ADGV.AdvancedDataGridViewSearchToolBarSearchEventHandler(this.adgvSearch_Search);
            // 
            // dataSetRedoc
            // 
            this.dataSetRedoc.DataSetName = "DataSetRedoc";
            this.dataSetRedoc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vWPATIENTBindingSource
            // 
            this.vWPATIENTBindingSource.DataMember = "VW_PATIENT";
            this.vWPATIENTBindingSource.DataSource = this.dataSetRedoc;
            // 
            // vW_PATIENTTableAdapter
            // 
            this.vW_PATIENTTableAdapter.ClearBeforeFill = true;
            // 
            // pATNODataGridViewTextBoxColumn
            // 
            this.pATNODataGridViewTextBoxColumn.DataPropertyName = "PAT_NO";
            this.pATNODataGridViewTextBoxColumn.HeaderText = "PAT_NO";
            this.pATNODataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pATNODataGridViewTextBoxColumn.Name = "pATNODataGridViewTextBoxColumn";
            this.pATNODataGridViewTextBoxColumn.ReadOnly = true;
            this.pATNODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.pATNODataGridViewTextBoxColumn.Width = 124;
            // 
            // pATNOMDataGridViewTextBoxColumn
            // 
            this.pATNOMDataGridViewTextBoxColumn.DataPropertyName = "PAT_NOM";
            this.pATNOMDataGridViewTextBoxColumn.HeaderText = "PAT_NOM";
            this.pATNOMDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pATNOMDataGridViewTextBoxColumn.Name = "pATNOMDataGridViewTextBoxColumn";
            this.pATNOMDataGridViewTextBoxColumn.ReadOnly = true;
            this.pATNOMDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.pATNOMDataGridViewTextBoxColumn.Width = 124;
            // 
            // pATPRENOMDataGridViewTextBoxColumn
            // 
            this.pATPRENOMDataGridViewTextBoxColumn.DataPropertyName = "PAT_PRENOM";
            this.pATPRENOMDataGridViewTextBoxColumn.HeaderText = "PAT_PRENOM";
            this.pATPRENOMDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pATPRENOMDataGridViewTextBoxColumn.Name = "pATPRENOMDataGridViewTextBoxColumn";
            this.pATPRENOMDataGridViewTextBoxColumn.ReadOnly = true;
            this.pATPRENOMDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.pATPRENOMDataGridViewTextBoxColumn.Width = 124;
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
            // pATDATENAISSANCEDataGridViewTextBoxColumn
            // 
            this.pATDATENAISSANCEDataGridViewTextBoxColumn.DataPropertyName = "PAT_DATE_NAISSANCE";
            this.pATDATENAISSANCEDataGridViewTextBoxColumn.HeaderText = "PAT_DATE_NAISSANCE";
            this.pATDATENAISSANCEDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pATDATENAISSANCEDataGridViewTextBoxColumn.Name = "pATDATENAISSANCEDataGridViewTextBoxColumn";
            this.pATDATENAISSANCEDataGridViewTextBoxColumn.ReadOnly = true;
            this.pATDATENAISSANCEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.pATDATENAISSANCEDataGridViewTextBoxColumn.Width = 124;
            // 
            // pATADRESSEDataGridViewTextBoxColumn
            // 
            this.pATADRESSEDataGridViewTextBoxColumn.DataPropertyName = "PAT_ADRESSE";
            this.pATADRESSEDataGridViewTextBoxColumn.HeaderText = "PAT_ADRESSE";
            this.pATADRESSEDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pATADRESSEDataGridViewTextBoxColumn.Name = "pATADRESSEDataGridViewTextBoxColumn";
            this.pATADRESSEDataGridViewTextBoxColumn.ReadOnly = true;
            this.pATADRESSEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.pATADRESSEDataGridViewTextBoxColumn.Width = 124;
            // 
            // pATEMAILDataGridViewTextBoxColumn
            // 
            this.pATEMAILDataGridViewTextBoxColumn.DataPropertyName = "PAT_EMAIL";
            this.pATEMAILDataGridViewTextBoxColumn.HeaderText = "PAT_EMAIL";
            this.pATEMAILDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pATEMAILDataGridViewTextBoxColumn.Name = "pATEMAILDataGridViewTextBoxColumn";
            this.pATEMAILDataGridViewTextBoxColumn.ReadOnly = true;
            this.pATEMAILDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.pATEMAILDataGridViewTextBoxColumn.Width = 124;
            // 
            // pATTELEPHONEDataGridViewTextBoxColumn
            // 
            this.pATTELEPHONEDataGridViewTextBoxColumn.DataPropertyName = "PAT_TELEPHONE";
            this.pATTELEPHONEDataGridViewTextBoxColumn.HeaderText = "PAT_TELEPHONE";
            this.pATTELEPHONEDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pATTELEPHONEDataGridViewTextBoxColumn.Name = "pATTELEPHONEDataGridViewTextBoxColumn";
            this.pATTELEPHONEDataGridViewTextBoxColumn.ReadOnly = true;
            this.pATTELEPHONEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.pATTELEPHONEDataGridViewTextBoxColumn.Width = 124;
            // 
            // pATNOAVSDataGridViewTextBoxColumn
            // 
            this.pATNOAVSDataGridViewTextBoxColumn.DataPropertyName = "PAT_NO_AVS";
            this.pATNOAVSDataGridViewTextBoxColumn.HeaderText = "PAT_NO_AVS";
            this.pATNOAVSDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pATNOAVSDataGridViewTextBoxColumn.Name = "pATNOAVSDataGridViewTextBoxColumn";
            this.pATNOAVSDataGridViewTextBoxColumn.ReadOnly = true;
            this.pATNOAVSDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.pATNOAVSDataGridViewTextBoxColumn.Width = 124;
            // 
            // FrmPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 437);
            this.Controls.Add(this.adgvSearch);
            this.Controls.Add(this.adgvPatients);
            this.Controls.Add(this.btnAddPatient);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(994, 445);
            this.Name = "FrmPatients";
            this.Text = "REDOC - Gestion des patients";
            this.Load += new System.EventHandler(this.FrmPatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adgvPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRedoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWPATIENTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddPatient;
        private Zuby.ADGV.AdvancedDataGridView adgvPatients;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMÉRODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRÉNOMDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATENAISSANCEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDRESSEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tÉLÉPHONEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOAVSDataGridViewTextBoxColumn1;
        private Zuby.ADGV.AdvancedDataGridViewSearchToolBar adgvSearch;
        private DataSetRedoc dataSetRedoc;
        private System.Windows.Forms.BindingSource vWPATIENTBindingSource;
        private DataSetRedocTableAdapters.VW_PATIENTTableAdapter vW_PATIENTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATNOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATPRENOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATNOMCOMPLETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATDATENAISSANCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATADRESSEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATTELEPHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATNOAVSDataGridViewTextBoxColumn;
    }
}