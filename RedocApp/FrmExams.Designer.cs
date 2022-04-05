
namespace RedocApp
{
    partial class FrmExams
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
            this.dgvExams = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durée = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.btnAddExam = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExams)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExams
            // 
            this.dgvExams.AllowUserToAddRows = false;
            this.dgvExams.AllowUserToDeleteRows = false;
            this.dgvExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Tarif,
            this.Durée});
            this.dgvExams.Location = new System.Drawing.Point(12, 53);
            this.dgvExams.Name = "dgvExams";
            this.dgvExams.ReadOnly = true;
            this.dgvExams.RowHeadersWidth = 51;
            this.dgvExams.RowTemplate.Height = 24;
            this.dgvExams.Size = new System.Drawing.Size(532, 241);
            this.dgvExams.TabIndex = 0;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Width = 124;
            // 
            // Tarif
            // 
            this.Tarif.HeaderText = "Tarif";
            this.Tarif.MinimumWidth = 6;
            this.Tarif.Name = "Tarif";
            this.Tarif.ReadOnly = true;
            this.Tarif.Width = 124;
            // 
            // Durée
            // 
            this.Durée.HeaderText = "Durée";
            this.Durée.MinimumWidth = 6;
            this.Durée.Name = "Durée";
            this.Durée.ReadOnly = true;
            this.Durée.Width = 124;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(12, 12);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(125, 25);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Recherche";
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(158, 15);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(187, 22);
            this.txbSearch.TabIndex = 2;
            // 
            // btnAddExam
            // 
            this.btnAddExam.Location = new System.Drawing.Point(376, 10);
            this.btnAddExam.Name = "btnAddExam";
            this.btnAddExam.Size = new System.Drawing.Size(168, 33);
            this.btnAddExam.TabIndex = 3;
            this.btnAddExam.Text = "Ajouter un examen";
            this.btnAddExam.UseVisualStyleBackColor = true;
            // 
            // FrmExams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 306);
            this.Controls.Add(this.btnAddExam);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvExams);
            this.MinimumSize = new System.Drawing.Size(574, 352);
            this.Name = "FrmExams";
            this.Text = "REDOC - Gestion examens";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExams;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarif;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durée;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Button btnAddExam;
    }
}