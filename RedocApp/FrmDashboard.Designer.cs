
namespace RedocApp
{
    partial class FrmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.tsmiFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdition = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditionCopier = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditionColler = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrMain = new System.Windows.Forms.ToolStrip();
            this.tsbtnRdv = new System.Windows.Forms.ToolStripButton();
            this.tssRdv = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnPatients = new System.Windows.Forms.ToolStripButton();
            this.tss = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnExams = new System.Windows.Forms.ToolStripButton();
            this.mnsMain.SuspendLayout();
            this.tsrMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMain
            // 
            this.mnsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFichier,
            this.tsmiEdition});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Size = new System.Drawing.Size(958, 28);
            this.mnsMain.TabIndex = 1;
            this.mnsMain.Text = "mnsMain";
            // 
            // tsmiFichier
            // 
            this.tsmiFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFichierQuitter});
            this.tsmiFichier.Name = "tsmiFichier";
            this.tsmiFichier.Size = new System.Drawing.Size(66, 24);
            this.tsmiFichier.Text = "&Fichier";
            // 
            // tsmiFichierQuitter
            // 
            this.tsmiFichierQuitter.Name = "tsmiFichierQuitter";
            this.tsmiFichierQuitter.Size = new System.Drawing.Size(138, 26);
            this.tsmiFichierQuitter.Text = "&Quitter";
            this.tsmiFichierQuitter.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // tsmiEdition
            // 
            this.tsmiEdition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditionCopier,
            this.tsmiEditionColler});
            this.tsmiEdition.Name = "tsmiEdition";
            this.tsmiEdition.Size = new System.Drawing.Size(70, 24);
            this.tsmiEdition.Text = "&Edition";
            // 
            // tsmiEditionCopier
            // 
            this.tsmiEditionCopier.Name = "tsmiEditionCopier";
            this.tsmiEditionCopier.Size = new System.Drawing.Size(136, 26);
            this.tsmiEditionCopier.Text = "&Copier";
            // 
            // tsmiEditionColler
            // 
            this.tsmiEditionColler.Name = "tsmiEditionColler";
            this.tsmiEditionColler.Size = new System.Drawing.Size(136, 26);
            this.tsmiEditionColler.Text = "C&oller";
            // 
            // tsrMain
            // 
            this.tsrMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsrMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnRdv,
            this.tssRdv,
            this.tsbtnPatients,
            this.tss,
            this.tsbtnExams});
            this.tsrMain.Location = new System.Drawing.Point(0, 28);
            this.tsrMain.Name = "tsrMain";
            this.tsrMain.Size = new System.Drawing.Size(958, 27);
            this.tsrMain.TabIndex = 2;
            this.tsrMain.Text = "tsrMain";
            // 
            // tsbtnRdv
            // 
            this.tsbtnRdv.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRdv.Image")));
            this.tsbtnRdv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRdv.Name = "tsbtnRdv";
            this.tsbtnRdv.Size = new System.Drawing.Size(118, 24);
            this.tsbtnRdv.Text = "Rendez-vous";
            this.tsbtnRdv.Click += new System.EventHandler(this.tsbtnRdv_Click);
            // 
            // tssRdv
            // 
            this.tssRdv.Name = "tssRdv";
            this.tssRdv.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbtnPatients
            // 
            this.tsbtnPatients.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPatients.Image")));
            this.tsbtnPatients.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPatients.Name = "tsbtnPatients";
            this.tsbtnPatients.Size = new System.Drawing.Size(140, 24);
            this.tsbtnPatients.Text = "Gestion patients";
            this.tsbtnPatients.Click += new System.EventHandler(this.tsbtnPatients_Click);
            // 
            // tss
            // 
            this.tss.Name = "tss";
            this.tss.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbtnExams
            // 
            this.tsbtnExams.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnExams.Image")));
            this.tsbtnExams.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExams.Name = "tsbtnExams";
            this.tsbtnExams.Size = new System.Drawing.Size(145, 24);
            this.tsbtnExams.Text = "Gestion examens";
            this.tsbtnExams.Click += new System.EventHandler(this.tsbtnExams_Click);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 537);
            this.Controls.Add(this.tsrMain);
            this.Controls.Add(this.mnsMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsMain;
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REDOC - Dashboard";
            this.Load += new System.EventHandler(this.frmDashboardAdmin_Load);
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            this.tsrMain.ResumeLayout(false);
            this.tsrMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiFichier;
        private System.Windows.Forms.ToolStrip tsrMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiFichierQuitter;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdition;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditionCopier;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditionColler;
        private System.Windows.Forms.ToolStripSeparator tssRdv;
        private System.Windows.Forms.ToolStripButton tsbtnPatients;
        private System.Windows.Forms.ToolStripSeparator tss;
        private System.Windows.Forms.ToolStripButton tsbtnExams;
        private System.Windows.Forms.ToolStripButton tsbtnRdv;
    }
}