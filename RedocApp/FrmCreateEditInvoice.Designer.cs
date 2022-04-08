
namespace RedocApp
{
    partial class FrmCreateEditInvoice
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
            this.lblInvoice = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lsbExams = new System.Windows.Forms.ListBox();
            this.txbPatient = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpMain = new System.Windows.Forms.DateTimePicker();
            this.btnAddExam = new System.Windows.Forms.Button();
            this.btnRemoveExam = new System.Windows.Forms.Button();
            this.cmbExams = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblExamList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInvoice
            // 
            this.lblInvoice.AutoSize = true;
            this.lblInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoice.Location = new System.Drawing.Point(9, 7);
            this.lblInvoice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(265, 20);
            this.lblInvoice.TabIndex = 0;
            this.lblInvoice.Text = "Création / modification facture";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(10, 39);
            this.lblPatientName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(40, 13);
            this.lblPatientName.TabIndex = 1;
            this.lblPatientName.Text = "&Patient";
            // 
            // lsbExams
            // 
            this.lsbExams.FormattingEnabled = true;
            this.lsbExams.HorizontalScrollbar = true;
            this.lsbExams.Location = new System.Drawing.Point(13, 180);
            this.lsbExams.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lsbExams.Name = "lsbExams";
            this.lsbExams.Size = new System.Drawing.Size(278, 173);
            this.lsbExams.TabIndex = 9;
            // 
            // txbPatient
            // 
            this.txbPatient.Location = new System.Drawing.Point(93, 37);
            this.txbPatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbPatient.Name = "txbPatient";
            this.txbPatient.ReadOnly = true;
            this.txbPatient.Size = new System.Drawing.Size(198, 20);
            this.txbPatient.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(10, 68);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "&Date";
            // 
            // dtpMain
            // 
            this.dtpMain.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMain.Location = new System.Drawing.Point(93, 65);
            this.dtpMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpMain.Name = "dtpMain";
            this.dtpMain.Size = new System.Drawing.Size(198, 20);
            this.dtpMain.TabIndex = 4;
            // 
            // btnAddExam
            // 
            this.btnAddExam.Location = new System.Drawing.Point(13, 140);
            this.btnAddExam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddExam.Name = "btnAddExam";
            this.btnAddExam.Size = new System.Drawing.Size(92, 36);
            this.btnAddExam.TabIndex = 7;
            this.btnAddExam.Text = "A&jouter examen";
            this.btnAddExam.UseVisualStyleBackColor = true;
            // 
            // btnRemoveExam
            // 
            this.btnRemoveExam.Location = new System.Drawing.Point(190, 140);
            this.btnRemoveExam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoveExam.Name = "btnRemoveExam";
            this.btnRemoveExam.Size = new System.Drawing.Size(100, 36);
            this.btnRemoveExam.TabIndex = 8;
            this.btnRemoveExam.Text = "&Retirer examen sélectionné";
            this.btnRemoveExam.UseVisualStyleBackColor = true;
            // 
            // cmbExams
            // 
            this.cmbExams.FormattingEnabled = true;
            this.cmbExams.Location = new System.Drawing.Point(13, 115);
            this.cmbExams.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbExams.Name = "cmbExams";
            this.cmbExams.Size = new System.Drawing.Size(278, 21);
            this.cmbExams.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.89076F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(10, 364);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(65, 18);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "TOTAL:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(13, 393);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 37);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "&Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(206, 393);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(84, 37);
            this.btnConfirm.TabIndex = 12;
            this.btnConfirm.Text = "&Valider";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(121, 365);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(170, 19);
            this.lblTotalAmount.TabIndex = 11;
            this.lblTotalAmount.Text = "0.0";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblExamList
            // 
            this.lblExamList.AutoSize = true;
            this.lblExamList.Location = new System.Drawing.Point(10, 100);
            this.lblExamList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExamList.Name = "lblExamList";
            this.lblExamList.Size = new System.Drawing.Size(94, 13);
            this.lblExamList.TabIndex = 5;
            this.lblExamList.Text = "&Liste des examens";
            // 
            // FrmCreateEditInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 440);
            this.Controls.Add(this.lblExamList);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cmbExams);
            this.Controls.Add(this.btnRemoveExam);
            this.Controls.Add(this.btnAddExam);
            this.Controls.Add(this.dtpMain);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txbPatient);
            this.Controls.Add(this.lsbExams);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.lblInvoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmCreateEditInvoice";
            this.Text = "REDOC - Facturation";
            this.Load += new System.EventHandler(this.FrmCreateEditInvoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInvoice;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.ListBox lsbExams;
        private System.Windows.Forms.TextBox txbPatient;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpMain;
        private System.Windows.Forms.Button btnAddExam;
        private System.Windows.Forms.Button btnRemoveExam;
        private System.Windows.Forms.ComboBox cmbExams;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblExamList;
    }
}