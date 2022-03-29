
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Docteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Annulé = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mcScheduler = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Docteur,
            this.Patient,
            this.Annulé});
            this.dataGridView1.Location = new System.Drawing.Point(12, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(683, 258);
            this.dataGridView1.TabIndex = 1;
            // 
            // Docteur
            // 
            this.Docteur.HeaderText = "Docteur";
            this.Docteur.MinimumWidth = 6;
            this.Docteur.Name = "Docteur";
            this.Docteur.Width = 124;
            // 
            // Patient
            // 
            this.Patient.HeaderText = "Patient";
            this.Patient.MinimumWidth = 6;
            this.Patient.Name = "Patient";
            this.Patient.Width = 124;
            // 
            // Annulé
            // 
            this.Annulé.HeaderText = "Annulé";
            this.Annulé.MinimumWidth = 6;
            this.Annulé.Name = "Annulé";
            this.Annulé.Width = 124;
            // 
            // mcScheduler
            // 
            this.mcScheduler.Location = new System.Drawing.Point(12, 18);
            this.mcScheduler.Name = "mcScheduler";
            this.mcScheduler.ShowWeekNumbers = true;
            this.mcScheduler.TabIndex = 2;
            // 
            // FrmScheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 507);
            this.Controls.Add(this.mcScheduler);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmScheduler";
            this.Text = "REDOC - Calendrier des rendez-vous";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Docteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patient;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Annulé;
        private System.Windows.Forms.MonthCalendar mcScheduler;
    }
}