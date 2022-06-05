
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
            this.components = new System.ComponentModel.Container();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.adgvAppointments = new Zuby.ADGV.AdvancedDataGridView();
            this.rENNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rENDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATNOMCOMPLETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCNOMCOMPLETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rENANNULEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rENCOMMENTAIREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vWRENDEZVOUSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRedoc = new RedocApp.DataSetRedoc();
            this.adgvSearch = new Zuby.ADGV.AdvancedDataGridViewSearchToolBar();
            this.vW_RENDEZVOUSTableAdapter = new RedocApp.DataSetRedocTableAdapters.VW_RENDEZVOUSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.adgvAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWRENDEZVOUSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRedoc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAppointment.Location = new System.Drawing.Point(810, 42);
            this.btnAddAppointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(165, 31);
            this.btnAddAppointment.TabIndex = 3;
            this.btnAddAppointment.Text = "Ajouter un RDV";
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // adgvAppointments
            // 
            this.adgvAppointments.AllowUserToAddRows = false;
            this.adgvAppointments.AllowUserToDeleteRows = false;
            this.adgvAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adgvAppointments.AutoGenerateColumns = false;
            this.adgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgvAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rENNODataGridViewTextBoxColumn,
            this.rENDATEDataGridViewTextBoxColumn,
            this.pATNOMCOMPLETDataGridViewTextBoxColumn,
            this.dOCNOMCOMPLETDataGridViewTextBoxColumn,
            this.rENANNULEDataGridViewTextBoxColumn,
            this.rENCOMMENTAIREDataGridViewTextBoxColumn});
            this.adgvAppointments.DataSource = this.vWRENDEZVOUSBindingSource;
            this.adgvAppointments.FilterAndSortEnabled = true;
            this.adgvAppointments.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.adgvAppointments.Location = new System.Drawing.Point(0, 90);
            this.adgvAppointments.Name = "adgvAppointments";
            this.adgvAppointments.ReadOnly = true;
            this.adgvAppointments.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adgvAppointments.RowHeadersWidth = 51;
            this.adgvAppointments.RowTemplate.Height = 24;
            this.adgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adgvAppointments.Size = new System.Drawing.Size(987, 332);
            this.adgvAppointments.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.adgvAppointments.TabIndex = 5;
            this.adgvAppointments.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adgvAppointments_CellContentDoubleClick);
            // 
            // rENNODataGridViewTextBoxColumn
            // 
            this.rENNODataGridViewTextBoxColumn.DataPropertyName = "REN_NO";
            this.rENNODataGridViewTextBoxColumn.HeaderText = "REN_NO";
            this.rENNODataGridViewTextBoxColumn.MinimumWidth = 22;
            this.rENNODataGridViewTextBoxColumn.Name = "rENNODataGridViewTextBoxColumn";
            this.rENNODataGridViewTextBoxColumn.ReadOnly = true;
            this.rENNODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.rENNODataGridViewTextBoxColumn.Width = 124;
            // 
            // rENDATEDataGridViewTextBoxColumn
            // 
            this.rENDATEDataGridViewTextBoxColumn.DataPropertyName = "REN_DATE";
            this.rENDATEDataGridViewTextBoxColumn.HeaderText = "REN_DATE";
            this.rENDATEDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.rENDATEDataGridViewTextBoxColumn.Name = "rENDATEDataGridViewTextBoxColumn";
            this.rENDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.rENDATEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.rENDATEDataGridViewTextBoxColumn.Width = 124;
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
            // dOCNOMCOMPLETDataGridViewTextBoxColumn
            // 
            this.dOCNOMCOMPLETDataGridViewTextBoxColumn.DataPropertyName = "DOC_NOM_COMPLET";
            this.dOCNOMCOMPLETDataGridViewTextBoxColumn.HeaderText = "DOC_NOM_COMPLET";
            this.dOCNOMCOMPLETDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.dOCNOMCOMPLETDataGridViewTextBoxColumn.Name = "dOCNOMCOMPLETDataGridViewTextBoxColumn";
            this.dOCNOMCOMPLETDataGridViewTextBoxColumn.ReadOnly = true;
            this.dOCNOMCOMPLETDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dOCNOMCOMPLETDataGridViewTextBoxColumn.Width = 124;
            // 
            // rENANNULEDataGridViewTextBoxColumn
            // 
            this.rENANNULEDataGridViewTextBoxColumn.DataPropertyName = "REN_ANNULE";
            this.rENANNULEDataGridViewTextBoxColumn.HeaderText = "REN_ANNULE";
            this.rENANNULEDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.rENANNULEDataGridViewTextBoxColumn.Name = "rENANNULEDataGridViewTextBoxColumn";
            this.rENANNULEDataGridViewTextBoxColumn.ReadOnly = true;
            this.rENANNULEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rENANNULEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.rENANNULEDataGridViewTextBoxColumn.Width = 124;
            // 
            // rENCOMMENTAIREDataGridViewTextBoxColumn
            // 
            this.rENCOMMENTAIREDataGridViewTextBoxColumn.DataPropertyName = "REN_COMMENTAIRE";
            this.rENCOMMENTAIREDataGridViewTextBoxColumn.HeaderText = "REN_COMMENTAIRE";
            this.rENCOMMENTAIREDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.rENCOMMENTAIREDataGridViewTextBoxColumn.Name = "rENCOMMENTAIREDataGridViewTextBoxColumn";
            this.rENCOMMENTAIREDataGridViewTextBoxColumn.ReadOnly = true;
            this.rENCOMMENTAIREDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.rENCOMMENTAIREDataGridViewTextBoxColumn.Width = 124;
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
            this.adgvSearch.Size = new System.Drawing.Size(987, 27);
            this.adgvSearch.TabIndex = 6;
            this.adgvSearch.Text = "advancedDataGridViewSearchToolBar1";
            this.adgvSearch.Search += new Zuby.ADGV.AdvancedDataGridViewSearchToolBarSearchEventHandler(this.adgvSearch_Search);
            // 
            // vW_RENDEZVOUSTableAdapter
            // 
            this.vW_RENDEZVOUSTableAdapter.ClearBeforeFill = true;
            // 
            // FrmScheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 422);
            this.Controls.Add(this.adgvSearch);
            this.Controls.Add(this.adgvAppointments);
            this.Controls.Add(this.btnAddAppointment);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(567, 46);
            this.Name = "FrmScheduler";
            this.Text = "REDOC - Calendrier des rendez-vous";
            this.Load += new System.EventHandler(this.FrmScheduler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adgvAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWRENDEZVOUSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRedoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddAppointment;
        private Zuby.ADGV.AdvancedDataGridView adgvAppointments;
        private Zuby.ADGV.AdvancedDataGridViewSearchToolBar adgvSearch;
        private DataSetRedoc dataSetRedoc;
        private System.Windows.Forms.BindingSource vWRENDEZVOUSBindingSource;
        private DataSetRedocTableAdapters.VW_RENDEZVOUSTableAdapter vW_RENDEZVOUSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rENNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rENDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATNOMCOMPLETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCNOMCOMPLETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rENANNULEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rENCOMMENTAIREDataGridViewTextBoxColumn;
    }
}