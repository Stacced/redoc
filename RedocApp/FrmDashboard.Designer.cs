
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
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrMain = new System.Windows.Forms.ToolStrip();
            this.tsbtnAppointments = new System.Windows.Forms.ToolStripButton();
            this.tssAppointments = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnPatients = new System.Windows.Forms.ToolStripButton();
            this.tssPatients = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnInvoicing = new System.Windows.Forms.ToolStripButton();
            this.tssInvoicing = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnManageDocSchedule = new System.Windows.Forms.ToolStripButton();
            this.mnsMain.SuspendLayout();
            this.tsrMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMain
            // 
            this.mnsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiEdit,
            this.tsmiWindow});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.MdiWindowListItem = this.tsmiWindow;
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnsMain.Size = new System.Drawing.Size(718, 24);
            this.mnsMain.TabIndex = 1;
            this.mnsMain.Text = "mnsMain";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFileQuit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(54, 20);
            this.tsmiFile.Text = "&Fichier";
            // 
            // tsmiFileQuit
            // 
            this.tsmiFileQuit.Name = "tsmiFileQuit";
            this.tsmiFileQuit.Size = new System.Drawing.Size(111, 22);
            this.tsmiFileQuit.Text = "&Quitter";
            this.tsmiFileQuit.Click += new System.EventHandler(this.tsmiFileQuit_Click);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditCopy,
            this.tsmiEditPaste});
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(56, 20);
            this.tsmiEdit.Text = "&Edition";
            // 
            // tsmiEditCopy
            // 
            this.tsmiEditCopy.Name = "tsmiEditCopy";
            this.tsmiEditCopy.Size = new System.Drawing.Size(109, 22);
            this.tsmiEditCopy.Text = "&Copier";
            // 
            // tsmiEditPaste
            // 
            this.tsmiEditPaste.Name = "tsmiEditPaste";
            this.tsmiEditPaste.Size = new System.Drawing.Size(109, 22);
            this.tsmiEditPaste.Text = "C&oller";
            // 
            // tsmiWindow
            // 
            this.tsmiWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTileHorizontal,
            this.tsmiTileVertical});
            this.tsmiWindow.Name = "tsmiWindow";
            this.tsmiWindow.Size = new System.Drawing.Size(58, 20);
            this.tsmiWindow.Text = "&Fenêtre";
            // 
            // tsmiTileHorizontal
            // 
            this.tsmiTileHorizontal.Name = "tsmiTileHorizontal";
            this.tsmiTileHorizontal.Size = new System.Drawing.Size(215, 22);
            this.tsmiTileHorizontal.Text = "Organiser &horizontalement";
            this.tsmiTileHorizontal.Click += new System.EventHandler(this.tsmiTileHorizontal_Click);
            // 
            // tsmiTileVertical
            // 
            this.tsmiTileVertical.Name = "tsmiTileVertical";
            this.tsmiTileVertical.Size = new System.Drawing.Size(215, 22);
            this.tsmiTileVertical.Text = "Organiser &verticalement";
            this.tsmiTileVertical.Click += new System.EventHandler(this.tsmiTileVertical_Click);
            // 
            // tsrMain
            // 
            this.tsrMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsrMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAppointments,
            this.tssAppointments,
            this.tsbtnPatients,
            this.tssPatients,
            this.tsbtnInvoicing,
            this.tssInvoicing,
            this.tsbtnManageDocSchedule});
            this.tsrMain.Location = new System.Drawing.Point(0, 24);
            this.tsrMain.Name = "tsrMain";
            this.tsrMain.Size = new System.Drawing.Size(718, 27);
            this.tsrMain.TabIndex = 2;
            this.tsrMain.Text = "tsrMain";
            // 
            // tsbtnAppointments
            // 
            this.tsbtnAppointments.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAppointments.Image")));
            this.tsbtnAppointments.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAppointments.Name = "tsbtnAppointments";
            this.tsbtnAppointments.Size = new System.Drawing.Size(99, 24);
            this.tsbtnAppointments.Text = "&Rendez-vous";
            this.tsbtnAppointments.Click += new System.EventHandler(this.tsbtnAppointments_Click);
            // 
            // tssAppointments
            // 
            this.tssAppointments.Name = "tssAppointments";
            this.tssAppointments.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbtnPatients
            // 
            this.tsbtnPatients.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPatients.Image")));
            this.tsbtnPatients.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPatients.Name = "tsbtnPatients";
            this.tsbtnPatients.Size = new System.Drawing.Size(116, 24);
            this.tsbtnPatients.Text = "Gestion &patients";
            this.tsbtnPatients.Click += new System.EventHandler(this.tsbtnPatients_Click);
            // 
            // tssPatients
            // 
            this.tssPatients.Name = "tssPatients";
            this.tssPatients.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbtnInvoicing
            // 
            this.tsbtnInvoicing.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnInvoicing.Image")));
            this.tsbtnInvoicing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnInvoicing.Name = "tsbtnInvoicing";
            this.tsbtnInvoicing.Size = new System.Drawing.Size(91, 24);
            this.tsbtnInvoicing.Text = "Facturation";
            this.tsbtnInvoicing.Click += new System.EventHandler(this.tsbtnInvoicing_Click);
            // 
            // tssInvoicing
            // 
            this.tssInvoicing.Name = "tssInvoicing";
            this.tssInvoicing.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbtnManageDocSchedule
            // 
            this.tsbtnManageDocSchedule.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnManageDocSchedule.Image")));
            this.tsbtnManageDocSchedule.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnManageDocSchedule.Name = "tsbtnManageDocSchedule";
            this.tsbtnManageDocSchedule.Size = new System.Drawing.Size(116, 24);
            this.tsbtnManageDocSchedule.Text = "Gestion horaires";
            this.tsbtnManageDocSchedule.Click += new System.EventHandler(this.tsbtnSchedules_Click);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 436);
            this.Controls.Add(this.tsrMain);
            this.Controls.Add(this.mnsMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsMain;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(642, 414);
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REDOC - Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStrip tsrMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileQuit;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditPaste;
        private System.Windows.Forms.ToolStripSeparator tssAppointments;
        private System.Windows.Forms.ToolStripButton tsbtnPatients;
        private System.Windows.Forms.ToolStripSeparator tssPatients;
        private System.Windows.Forms.ToolStripButton tsbtnAppointments;
        private System.Windows.Forms.ToolStripMenuItem tsmiWindow;
        private System.Windows.Forms.ToolStripMenuItem tsmiTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem tsmiTileVertical;
        private System.Windows.Forms.ToolStripButton tsbtnInvoicing;
        private System.Windows.Forms.ToolStripSeparator tssInvoicing;
        private System.Windows.Forms.ToolStripButton tsbtnManageDocSchedule;
    }
}