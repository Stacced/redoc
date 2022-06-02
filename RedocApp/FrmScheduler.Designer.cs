
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
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.adgvAppointments = new Zuby.ADGV.AdvancedDataGridView();
            this.adgvSearch = new Zuby.ADGV.AdvancedDataGridViewSearchToolBar();
            ((System.ComponentModel.ISupportInitialize)(this.adgvAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAppointment.Location = new System.Drawing.Point(802, 39);
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
            this.adgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgvAppointments.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.adgvAppointments.FilterAndSortEnabled = true;
            this.adgvAppointments.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.adgvAppointments.Location = new System.Drawing.Point(0, 75);
            this.adgvAppointments.Name = "adgvAppointments";
            this.adgvAppointments.ReadOnly = true;
            this.adgvAppointments.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adgvAppointments.RowHeadersWidth = 51;
            this.adgvAppointments.RowTemplate.Height = 24;
            this.adgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adgvAppointments.Size = new System.Drawing.Size(979, 332);
            this.adgvAppointments.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.adgvAppointments.TabIndex = 5;
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
            this.adgvSearch.TabIndex = 6;
            this.adgvSearch.Text = "advancedDataGridViewSearchToolBar1";
            this.adgvSearch.Search += new Zuby.ADGV.AdvancedDataGridViewSearchToolBarSearchEventHandler(this.adgvSearch_Search);
            // 
            // FrmScheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 407);
            this.Controls.Add(this.adgvSearch);
            this.Controls.Add(this.adgvAppointments);
            this.Controls.Add(this.btnAddAppointment);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(567, 445);
            this.Name = "FrmScheduler";
            this.Text = "REDOC - Calendrier des rendez-vous";
            this.Load += new System.EventHandler(this.FrmScheduler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adgvAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddAppointment;
        private Zuby.ADGV.AdvancedDataGridView adgvAppointments;
        private Zuby.ADGV.AdvancedDataGridViewSearchToolBar adgvSearch;
    }
}