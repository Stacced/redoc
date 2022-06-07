
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
            this.components = new System.ComponentModel.Container();
            this.lblInvoice = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lsbExams = new System.Windows.Forms.ListBox();
            this.vWEXAMENSFACTUREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRedoc = new RedocApp.DataSetRedoc();
            this.txtPatient = new System.Windows.Forms.TextBox();
            this.vWRENDEZVOUSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vWFACTUREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpMain = new System.Windows.Forms.DateTimePicker();
            this.btnAddExam = new System.Windows.Forms.Button();
            this.btnRemoveExam = new System.Windows.Forms.Button();
            this.cmbExams = new System.Windows.Forms.ComboBox();
            this.vWEXAMENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblExamList = new System.Windows.Forms.Label();
            this.vW_EXAMENTableAdapter = new RedocApp.DataSetRedocTableAdapters.VW_EXAMENTableAdapter();
            this.vW_FACTURETableAdapter = new RedocApp.DataSetRedocTableAdapters.VW_FACTURETableAdapter();
            this.vW_PATIENTTableAdapter = new RedocApp.DataSetRedocTableAdapters.VW_PATIENTTableAdapter();
            this.tableAdapterManager = new RedocApp.DataSetRedocTableAdapters.TableAdapterManager();
            this.vW_RENDEZVOUSTableAdapter = new RedocApp.DataSetRedocTableAdapters.VW_RENDEZVOUSTableAdapter();
            this.vW_EXAMENS_FACTURETableAdapter = new RedocApp.DataSetRedocTableAdapters.VW_EXAMENS_FACTURETableAdapter();
            this.cbxPaid = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.vWEXAMENSFACTUREBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRedoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWRENDEZVOUSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWFACTUREBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWEXAMENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInvoice
            // 
            this.lblInvoice.AutoSize = true;
            this.lblInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoice.Location = new System.Drawing.Point(12, 9);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(300, 25);
            this.lblInvoice.TabIndex = 0;
            this.lblInvoice.Text = "Création / modification facture";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(13, 48);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(52, 17);
            this.lblPatientName.TabIndex = 1;
            this.lblPatientName.Text = "&Patient";
            // 
            // lsbExams
            // 
            this.lsbExams.DataSource = this.vWEXAMENSFACTUREBindingSource;
            this.lsbExams.DisplayMember = "EXA_NOM";
            this.lsbExams.FormattingEnabled = true;
            this.lsbExams.HorizontalScrollbar = true;
            this.lsbExams.ItemHeight = 16;
            this.lsbExams.Location = new System.Drawing.Point(17, 222);
            this.lsbExams.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsbExams.Name = "lsbExams";
            this.lsbExams.Size = new System.Drawing.Size(369, 212);
            this.lsbExams.TabIndex = 10;
            this.lsbExams.ValueMember = "EXA_NO";
            // 
            // vWEXAMENSFACTUREBindingSource
            // 
            this.vWEXAMENSFACTUREBindingSource.DataMember = "VW_EXAMENS_FACTURE";
            this.vWEXAMENSFACTUREBindingSource.DataSource = this.dataSetRedoc;
            // 
            // dataSetRedoc
            // 
            this.dataSetRedoc.DataSetName = "DataSetRedoc";
            this.dataSetRedoc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPatient
            // 
            this.txtPatient.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vWRENDEZVOUSBindingSource, "PAT_NOM_COMPLET", true));
            this.txtPatient.Location = new System.Drawing.Point(124, 46);
            this.txtPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.ReadOnly = true;
            this.txtPatient.Size = new System.Drawing.Size(263, 22);
            this.txtPatient.TabIndex = 2;
            // 
            // vWRENDEZVOUSBindingSource
            // 
            this.vWRENDEZVOUSBindingSource.DataMember = "VW_RENDEZVOUS";
            this.vWRENDEZVOUSBindingSource.DataSource = this.dataSetRedoc;
            // 
            // vWFACTUREBindingSource
            // 
            this.vWFACTUREBindingSource.DataMember = "VW_FACTURE";
            this.vWFACTUREBindingSource.DataSource = this.dataSetRedoc;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(13, 84);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 17);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "&Date";
            // 
            // dtpMain
            // 
            this.dtpMain.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vWFACTUREBindingSource, "FAC_DATE", true));
            this.dtpMain.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMain.Location = new System.Drawing.Point(124, 80);
            this.dtpMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpMain.Name = "dtpMain";
            this.dtpMain.Size = new System.Drawing.Size(263, 22);
            this.dtpMain.TabIndex = 4;
            // 
            // btnAddExam
            // 
            this.btnAddExam.Location = new System.Drawing.Point(17, 172);
            this.btnAddExam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddExam.Name = "btnAddExam";
            this.btnAddExam.Size = new System.Drawing.Size(123, 44);
            this.btnAddExam.TabIndex = 8;
            this.btnAddExam.Text = "A&jouter examen";
            this.btnAddExam.UseVisualStyleBackColor = true;
            this.btnAddExam.Click += new System.EventHandler(this.btnAddExam_Click);
            // 
            // btnRemoveExam
            // 
            this.btnRemoveExam.Location = new System.Drawing.Point(253, 172);
            this.btnRemoveExam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveExam.Name = "btnRemoveExam";
            this.btnRemoveExam.Size = new System.Drawing.Size(133, 44);
            this.btnRemoveExam.TabIndex = 9;
            this.btnRemoveExam.Text = "&Retirer examen sélectionné";
            this.btnRemoveExam.UseVisualStyleBackColor = true;
            this.btnRemoveExam.Click += new System.EventHandler(this.btnRemoveExam_Click);
            // 
            // cmbExams
            // 
            this.cmbExams.DataSource = this.vWEXAMENBindingSource;
            this.cmbExams.DisplayMember = "LIS_NOM";
            this.cmbExams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExams.FormattingEnabled = true;
            this.cmbExams.Location = new System.Drawing.Point(17, 142);
            this.cmbExams.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbExams.Name = "cmbExams";
            this.cmbExams.Size = new System.Drawing.Size(369, 24);
            this.cmbExams.TabIndex = 7;
            this.cmbExams.ValueMember = "LIS_NO";
            // 
            // vWEXAMENBindingSource
            // 
            this.vWEXAMENBindingSource.DataMember = "VW_EXAMEN";
            this.vWEXAMENBindingSource.DataSource = this.dataSetRedoc;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.89076F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(13, 448);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(83, 24);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "TOTAL:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(17, 484);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 46);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "&Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(275, 484);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(112, 46);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "&Valider";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vWFACTUREBindingSource, "FAC_TOTAL", true));
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(171, 449);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(227, 23);
            this.lblTotalAmount.TabIndex = 12;
            this.lblTotalAmount.Text = "0.0";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblExamList
            // 
            this.lblExamList.AutoSize = true;
            this.lblExamList.Location = new System.Drawing.Point(13, 123);
            this.lblExamList.Name = "lblExamList";
            this.lblExamList.Size = new System.Drawing.Size(125, 17);
            this.lblExamList.TabIndex = 6;
            this.lblExamList.Text = "&Liste des examens";
            // 
            // vW_EXAMENTableAdapter
            // 
            this.vW_EXAMENTableAdapter.ClearBeforeFill = true;
            // 
            // vW_FACTURETableAdapter
            // 
            this.vW_FACTURETableAdapter.ClearBeforeFill = true;
            // 
            // vW_PATIENTTableAdapter
            // 
            this.vW_PATIENTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CAB_EXCEPTION_HORAIRETableAdapter = null;
            this.tableAdapterManager.CAB_FACTURETableAdapter = null;
            this.tableAdapterManager.CAB_HORAIRETableAdapter = null;
            this.tableAdapterManager.CAB_LIGNE_FACTURETableAdapter = null;
            this.tableAdapterManager.CAB_LISTE_EXAMENSTableAdapter = null;
            this.tableAdapterManager.CAB_PATIENTTableAdapter = null;
            this.tableAdapterManager.CAB_RENDEZVOUSTableAdapter = null;
            this.tableAdapterManager.CAB_SPE_UTILISATEURTableAdapter = null;
            this.tableAdapterManager.CAB_SPECIALISATIONTableAdapter = null;
            this.tableAdapterManager.CAB_UTILISATEURTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = RedocApp.DataSetRedocTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // vW_RENDEZVOUSTableAdapter
            // 
            this.vW_RENDEZVOUSTableAdapter.ClearBeforeFill = true;
            // 
            // vW_EXAMENS_FACTURETableAdapter
            // 
            this.vW_EXAMENS_FACTURETableAdapter.ClearBeforeFill = true;
            // 
            // cbxPaid
            // 
            this.cbxPaid.AutoSize = true;
            this.cbxPaid.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.vWFACTUREBindingSource, "FAC_PAYE", true));
            this.cbxPaid.Location = new System.Drawing.Point(335, 111);
            this.cbxPaid.Name = "cbxPaid";
            this.cbxPaid.Size = new System.Drawing.Size(59, 21);
            this.cbxPaid.TabIndex = 5;
            this.cbxPaid.Text = "Payé";
            this.cbxPaid.UseVisualStyleBackColor = true;
            // 
            // FrmCreateEditInvoice
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(413, 550);
            this.Controls.Add(this.cbxPaid);
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
            this.Controls.Add(this.txtPatient);
            this.Controls.Add(this.lsbExams);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.lblInvoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmCreateEditInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REDOC - Facturation";
            this.Load += new System.EventHandler(this.FrmCreateEditInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vWEXAMENSFACTUREBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRedoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWRENDEZVOUSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWFACTUREBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWEXAMENBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInvoice;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.ListBox lsbExams;
        private System.Windows.Forms.TextBox txtPatient;
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
        private DataSetRedoc dataSetRedoc;
        private System.Windows.Forms.BindingSource vWEXAMENBindingSource;
        private DataSetRedocTableAdapters.VW_EXAMENTableAdapter vW_EXAMENTableAdapter;
        private System.Windows.Forms.BindingSource vWFACTUREBindingSource;
        private DataSetRedocTableAdapters.VW_FACTURETableAdapter vW_FACTURETableAdapter;
        private DataSetRedocTableAdapters.VW_PATIENTTableAdapter vW_PATIENTTableAdapter;
        private DataSetRedocTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource vWRENDEZVOUSBindingSource;
        private DataSetRedocTableAdapters.VW_RENDEZVOUSTableAdapter vW_RENDEZVOUSTableAdapter;
        private System.Windows.Forms.BindingSource vWEXAMENSFACTUREBindingSource;
        private DataSetRedocTableAdapters.VW_EXAMENS_FACTURETableAdapter vW_EXAMENS_FACTURETableAdapter;
        private System.Windows.Forms.CheckBox cbxPaid;
    }
}