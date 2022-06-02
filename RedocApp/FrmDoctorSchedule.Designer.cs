
namespace RedocApp
{
    partial class FrmDoctorSchedule
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
            this.grpWeekSchedule = new System.Windows.Forms.GroupBox();
            this.btnDeleteSelectedSchedule = new System.Windows.Forms.Button();
            this.btnAddSchedule = new System.Windows.Forms.Button();
            this.dgvWeekSchedule = new System.Windows.Forms.DataGridView();
            this.lblShiftEnd = new System.Windows.Forms.Label();
            this.lblShiftStart = new System.Windows.Forms.Label();
            this.nudShiftEnd = new System.Windows.Forms.NumericUpDown();
            this.nudShiftStart = new System.Windows.Forms.NumericUpDown();
            this.lblWeekday = new System.Windows.Forms.Label();
            this.cmbWeekday = new System.Windows.Forms.ComboBox();
            this.grpScheduleExceptions = new System.Windows.Forms.GroupBox();
            this.lblExceptionDateEnd = new System.Windows.Forms.Label();
            this.dtpExceptionEnd = new System.Windows.Forms.DateTimePicker();
            this.dgvExceptions = new System.Windows.Forms.DataGridView();
            this.btnDeleteSelectedException = new System.Windows.Forms.Button();
            this.btnAddException = new System.Windows.Forms.Button();
            this.txbExceptionComment = new System.Windows.Forms.TextBox();
            this.lblExceptionComment = new System.Windows.Forms.Label();
            this.lblExceptionDateStart = new System.Windows.Forms.Label();
            this.dtpExceptionStart = new System.Windows.Forms.DateTimePicker();
            this.eXCDEBUTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXCFINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXCCOMMENTAIREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vWEXCEPTIONHORAIREDOCTEURBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRedoc = new RedocApp.DataSetRedoc();
            this.hORJOURDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORDEBUTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORFINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vWHORAIREDOCTEURBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vW_HORAIRE_DOCTEURTableAdapter = new RedocApp.DataSetRedocTableAdapters.VW_HORAIRE_DOCTEURTableAdapter();
            this.vW_EXCEPTION_HORAIRE_DOCTEURTableAdapter = new RedocApp.DataSetRedocTableAdapters.VW_EXCEPTION_HORAIRE_DOCTEURTableAdapter();
            this.grpWeekSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeekSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShiftEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShiftStart)).BeginInit();
            this.grpScheduleExceptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExceptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWEXCEPTIONHORAIREDOCTEURBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRedoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWHORAIREDOCTEURBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpWeekSchedule
            // 
            this.grpWeekSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpWeekSchedule.Controls.Add(this.btnDeleteSelectedSchedule);
            this.grpWeekSchedule.Controls.Add(this.btnAddSchedule);
            this.grpWeekSchedule.Controls.Add(this.dgvWeekSchedule);
            this.grpWeekSchedule.Controls.Add(this.lblShiftEnd);
            this.grpWeekSchedule.Controls.Add(this.lblShiftStart);
            this.grpWeekSchedule.Controls.Add(this.nudShiftEnd);
            this.grpWeekSchedule.Controls.Add(this.nudShiftStart);
            this.grpWeekSchedule.Controls.Add(this.lblWeekday);
            this.grpWeekSchedule.Controls.Add(this.cmbWeekday);
            this.grpWeekSchedule.Location = new System.Drawing.Point(16, 15);
            this.grpWeekSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.grpWeekSchedule.Name = "grpWeekSchedule";
            this.grpWeekSchedule.Padding = new System.Windows.Forms.Padding(4);
            this.grpWeekSchedule.Size = new System.Drawing.Size(488, 599);
            this.grpWeekSchedule.TabIndex = 0;
            this.grpWeekSchedule.TabStop = false;
            this.grpWeekSchedule.Text = "Horaire hebdomadaire";
            // 
            // btnDeleteSelectedSchedule
            // 
            this.btnDeleteSelectedSchedule.Location = new System.Drawing.Point(317, 167);
            this.btnDeleteSelectedSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteSelectedSchedule.Name = "btnDeleteSelectedSchedule";
            this.btnDeleteSelectedSchedule.Size = new System.Drawing.Size(151, 44);
            this.btnDeleteSelectedSchedule.TabIndex = 7;
            this.btnDeleteSelectedSchedule.Text = "&Supprimer horaire sélectionné";
            this.btnDeleteSelectedSchedule.UseVisualStyleBackColor = true;
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.Location = new System.Drawing.Point(12, 167);
            this.btnAddSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(151, 44);
            this.btnAddSchedule.TabIndex = 6;
            this.btnAddSchedule.Text = "&Ajouter horaire";
            this.btnAddSchedule.UseVisualStyleBackColor = true;
            // 
            // dgvWeekSchedule
            // 
            this.dgvWeekSchedule.AllowUserToAddRows = false;
            this.dgvWeekSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWeekSchedule.AutoGenerateColumns = false;
            this.dgvWeekSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWeekSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hORJOURDataGridViewTextBoxColumn,
            this.hORDEBUTDataGridViewTextBoxColumn,
            this.hORFINDataGridViewTextBoxColumn});
            this.dgvWeekSchedule.DataSource = this.vWHORAIREDOCTEURBindingSource;
            this.dgvWeekSchedule.Location = new System.Drawing.Point(12, 219);
            this.dgvWeekSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.dgvWeekSchedule.Name = "dgvWeekSchedule";
            this.dgvWeekSchedule.ReadOnly = true;
            this.dgvWeekSchedule.RowHeadersWidth = 51;
            this.dgvWeekSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWeekSchedule.Size = new System.Drawing.Size(464, 372);
            this.dgvWeekSchedule.TabIndex = 8;
            // 
            // lblShiftEnd
            // 
            this.lblShiftEnd.AutoSize = true;
            this.lblShiftEnd.Location = new System.Drawing.Point(8, 127);
            this.lblShiftEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShiftEnd.Name = "lblShiftEnd";
            this.lblShiftEnd.Size = new System.Drawing.Size(86, 17);
            this.lblShiftEnd.TabIndex = 4;
            this.lblShiftEnd.Text = "Heure de &fin";
            // 
            // lblShiftStart
            // 
            this.lblShiftStart.AutoSize = true;
            this.lblShiftStart.Location = new System.Drawing.Point(8, 80);
            this.lblShiftStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShiftStart.Name = "lblShiftStart";
            this.lblShiftStart.Size = new System.Drawing.Size(107, 17);
            this.lblShiftStart.TabIndex = 2;
            this.lblShiftStart.Text = "Heure de &début";
            // 
            // nudShiftEnd
            // 
            this.nudShiftEnd.Location = new System.Drawing.Point(301, 124);
            this.nudShiftEnd.Margin = new System.Windows.Forms.Padding(4);
            this.nudShiftEnd.Maximum = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.nudShiftEnd.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudShiftEnd.Name = "nudShiftEnd";
            this.nudShiftEnd.Size = new System.Drawing.Size(167, 22);
            this.nudShiftEnd.TabIndex = 5;
            this.nudShiftEnd.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // nudShiftStart
            // 
            this.nudShiftStart.Location = new System.Drawing.Point(301, 78);
            this.nudShiftStart.Margin = new System.Windows.Forms.Padding(4);
            this.nudShiftStart.Maximum = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.nudShiftStart.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudShiftStart.Name = "nudShiftStart";
            this.nudShiftStart.Size = new System.Drawing.Size(167, 22);
            this.nudShiftStart.TabIndex = 3;
            this.nudShiftStart.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // lblWeekday
            // 
            this.lblWeekday.AutoSize = true;
            this.lblWeekday.Location = new System.Drawing.Point(8, 33);
            this.lblWeekday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeekday.Name = "lblWeekday";
            this.lblWeekday.Size = new System.Drawing.Size(128, 17);
            this.lblWeekday.TabIndex = 0;
            this.lblWeekday.Text = "&Jour de la semaine";
            // 
            // cmbWeekday
            // 
            this.cmbWeekday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWeekday.FormattingEnabled = true;
            this.cmbWeekday.Items.AddRange(new object[] {
            "Lundi",
            "Mardi",
            "Mercredi",
            "Jeudi",
            "Vendredi"});
            this.cmbWeekday.Location = new System.Drawing.Point(301, 30);
            this.cmbWeekday.Margin = new System.Windows.Forms.Padding(4);
            this.cmbWeekday.Name = "cmbWeekday";
            this.cmbWeekday.Size = new System.Drawing.Size(165, 24);
            this.cmbWeekday.TabIndex = 1;
            // 
            // grpScheduleExceptions
            // 
            this.grpScheduleExceptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grpScheduleExceptions.Controls.Add(this.lblExceptionDateEnd);
            this.grpScheduleExceptions.Controls.Add(this.dtpExceptionEnd);
            this.grpScheduleExceptions.Controls.Add(this.dgvExceptions);
            this.grpScheduleExceptions.Controls.Add(this.btnDeleteSelectedException);
            this.grpScheduleExceptions.Controls.Add(this.btnAddException);
            this.grpScheduleExceptions.Controls.Add(this.txbExceptionComment);
            this.grpScheduleExceptions.Controls.Add(this.lblExceptionComment);
            this.grpScheduleExceptions.Controls.Add(this.lblExceptionDateStart);
            this.grpScheduleExceptions.Controls.Add(this.dtpExceptionStart);
            this.grpScheduleExceptions.Location = new System.Drawing.Point(508, 15);
            this.grpScheduleExceptions.Margin = new System.Windows.Forms.Padding(4);
            this.grpScheduleExceptions.Name = "grpScheduleExceptions";
            this.grpScheduleExceptions.Padding = new System.Windows.Forms.Padding(4);
            this.grpScheduleExceptions.Size = new System.Drawing.Size(488, 599);
            this.grpScheduleExceptions.TabIndex = 1;
            this.grpScheduleExceptions.TabStop = false;
            this.grpScheduleExceptions.Text = "Exceptions horaire";
            // 
            // lblExceptionDateEnd
            // 
            this.lblExceptionDateEnd.AutoSize = true;
            this.lblExceptionDateEnd.Location = new System.Drawing.Point(8, 80);
            this.lblExceptionDateEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExceptionDateEnd.Name = "lblExceptionDateEnd";
            this.lblExceptionDateEnd.Size = new System.Drawing.Size(121, 17);
            this.lblExceptionDateEnd.TabIndex = 11;
            this.lblExceptionDateEnd.Text = "&Date exception fin";
            // 
            // dtpExceptionEnd
            // 
            this.dtpExceptionEnd.Location = new System.Drawing.Point(201, 78);
            this.dtpExceptionEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtpExceptionEnd.Name = "dtpExceptionEnd";
            this.dtpExceptionEnd.Size = new System.Drawing.Size(265, 22);
            this.dtpExceptionEnd.TabIndex = 12;
            // 
            // dgvExceptions
            // 
            this.dgvExceptions.AllowUserToAddRows = false;
            this.dgvExceptions.AllowUserToDeleteRows = false;
            this.dgvExceptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExceptions.AutoGenerateColumns = false;
            this.dgvExceptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExceptions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eXCDEBUTDataGridViewTextBoxColumn,
            this.eXCFINDataGridViewTextBoxColumn,
            this.eXCCOMMENTAIREDataGridViewTextBoxColumn});
            this.dgvExceptions.DataSource = this.vWEXCEPTIONHORAIREDOCTEURBindingSource;
            this.dgvExceptions.Location = new System.Drawing.Point(12, 284);
            this.dgvExceptions.Margin = new System.Windows.Forms.Padding(4);
            this.dgvExceptions.Name = "dgvExceptions";
            this.dgvExceptions.ReadOnly = true;
            this.dgvExceptions.RowHeadersWidth = 51;
            this.dgvExceptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExceptions.Size = new System.Drawing.Size(464, 307);
            this.dgvExceptions.TabIndex = 10;
            // 
            // btnDeleteSelectedException
            // 
            this.btnDeleteSelectedException.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteSelectedException.Location = new System.Drawing.Point(325, 235);
            this.btnDeleteSelectedException.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteSelectedException.Name = "btnDeleteSelectedException";
            this.btnDeleteSelectedException.Size = new System.Drawing.Size(151, 44);
            this.btnDeleteSelectedException.TabIndex = 9;
            this.btnDeleteSelectedException.Text = "&Supprimer horaire sélectionné";
            this.btnDeleteSelectedException.UseVisualStyleBackColor = true;
            // 
            // btnAddException
            // 
            this.btnAddException.Location = new System.Drawing.Point(12, 235);
            this.btnAddException.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddException.Name = "btnAddException";
            this.btnAddException.Size = new System.Drawing.Size(151, 44);
            this.btnAddException.TabIndex = 8;
            this.btnAddException.Text = "&Ajouter exception";
            this.btnAddException.UseVisualStyleBackColor = true;
            // 
            // txbExceptionComment
            // 
            this.txbExceptionComment.Location = new System.Drawing.Point(201, 123);
            this.txbExceptionComment.Margin = new System.Windows.Forms.Padding(4);
            this.txbExceptionComment.Multiline = true;
            this.txbExceptionComment.Name = "txbExceptionComment";
            this.txbExceptionComment.Size = new System.Drawing.Size(265, 88);
            this.txbExceptionComment.TabIndex = 7;
            // 
            // lblExceptionComment
            // 
            this.lblExceptionComment.AutoSize = true;
            this.lblExceptionComment.Location = new System.Drawing.Point(8, 127);
            this.lblExceptionComment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExceptionComment.Name = "lblExceptionComment";
            this.lblExceptionComment.Size = new System.Drawing.Size(91, 17);
            this.lblExceptionComment.TabIndex = 6;
            this.lblExceptionComment.Text = "&Commentaire";
            // 
            // lblExceptionDateStart
            // 
            this.lblExceptionDateStart.AutoSize = true;
            this.lblExceptionDateStart.Location = new System.Drawing.Point(8, 33);
            this.lblExceptionDateStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExceptionDateStart.Name = "lblExceptionDateStart";
            this.lblExceptionDateStart.Size = new System.Drawing.Size(142, 17);
            this.lblExceptionDateStart.TabIndex = 0;
            this.lblExceptionDateStart.Text = "&Date exception début";
            // 
            // dtpExceptionStart
            // 
            this.dtpExceptionStart.Location = new System.Drawing.Point(201, 30);
            this.dtpExceptionStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtpExceptionStart.Name = "dtpExceptionStart";
            this.dtpExceptionStart.Size = new System.Drawing.Size(265, 22);
            this.dtpExceptionStart.TabIndex = 1;
            // 
            // eXCDEBUTDataGridViewTextBoxColumn
            // 
            this.eXCDEBUTDataGridViewTextBoxColumn.DataPropertyName = "EXC_DEBUT";
            this.eXCDEBUTDataGridViewTextBoxColumn.HeaderText = "EXC_DEBUT";
            this.eXCDEBUTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eXCDEBUTDataGridViewTextBoxColumn.Name = "eXCDEBUTDataGridViewTextBoxColumn";
            this.eXCDEBUTDataGridViewTextBoxColumn.ReadOnly = true;
            this.eXCDEBUTDataGridViewTextBoxColumn.Width = 124;
            // 
            // eXCFINDataGridViewTextBoxColumn
            // 
            this.eXCFINDataGridViewTextBoxColumn.DataPropertyName = "EXC_FIN";
            this.eXCFINDataGridViewTextBoxColumn.HeaderText = "EXC_FIN";
            this.eXCFINDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eXCFINDataGridViewTextBoxColumn.Name = "eXCFINDataGridViewTextBoxColumn";
            this.eXCFINDataGridViewTextBoxColumn.ReadOnly = true;
            this.eXCFINDataGridViewTextBoxColumn.Width = 124;
            // 
            // eXCCOMMENTAIREDataGridViewTextBoxColumn
            // 
            this.eXCCOMMENTAIREDataGridViewTextBoxColumn.DataPropertyName = "EXC_COMMENTAIRE";
            this.eXCCOMMENTAIREDataGridViewTextBoxColumn.HeaderText = "EXC_COMMENTAIRE";
            this.eXCCOMMENTAIREDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eXCCOMMENTAIREDataGridViewTextBoxColumn.Name = "eXCCOMMENTAIREDataGridViewTextBoxColumn";
            this.eXCCOMMENTAIREDataGridViewTextBoxColumn.ReadOnly = true;
            this.eXCCOMMENTAIREDataGridViewTextBoxColumn.Width = 124;
            // 
            // vWEXCEPTIONHORAIREDOCTEURBindingSource
            // 
            this.vWEXCEPTIONHORAIREDOCTEURBindingSource.DataMember = "VW_EXCEPTION_HORAIRE_DOCTEUR";
            this.vWEXCEPTIONHORAIREDOCTEURBindingSource.DataSource = this.dataSetRedoc;
            // 
            // dataSetRedoc
            // 
            this.dataSetRedoc.DataSetName = "DataSetRedoc";
            this.dataSetRedoc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hORJOURDataGridViewTextBoxColumn
            // 
            this.hORJOURDataGridViewTextBoxColumn.DataPropertyName = "HOR_JOUR";
            this.hORJOURDataGridViewTextBoxColumn.HeaderText = "HOR_JOUR";
            this.hORJOURDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hORJOURDataGridViewTextBoxColumn.Name = "hORJOURDataGridViewTextBoxColumn";
            this.hORJOURDataGridViewTextBoxColumn.ReadOnly = true;
            this.hORJOURDataGridViewTextBoxColumn.Width = 124;
            // 
            // hORDEBUTDataGridViewTextBoxColumn
            // 
            this.hORDEBUTDataGridViewTextBoxColumn.DataPropertyName = "HOR_DEBUT";
            this.hORDEBUTDataGridViewTextBoxColumn.HeaderText = "HOR_DEBUT";
            this.hORDEBUTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hORDEBUTDataGridViewTextBoxColumn.Name = "hORDEBUTDataGridViewTextBoxColumn";
            this.hORDEBUTDataGridViewTextBoxColumn.ReadOnly = true;
            this.hORDEBUTDataGridViewTextBoxColumn.Width = 124;
            // 
            // hORFINDataGridViewTextBoxColumn
            // 
            this.hORFINDataGridViewTextBoxColumn.DataPropertyName = "HOR_FIN";
            this.hORFINDataGridViewTextBoxColumn.HeaderText = "HOR_FIN";
            this.hORFINDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hORFINDataGridViewTextBoxColumn.Name = "hORFINDataGridViewTextBoxColumn";
            this.hORFINDataGridViewTextBoxColumn.ReadOnly = true;
            this.hORFINDataGridViewTextBoxColumn.Width = 124;
            // 
            // vWHORAIREDOCTEURBindingSource
            // 
            this.vWHORAIREDOCTEURBindingSource.DataMember = "VW_HORAIRE_DOCTEUR";
            this.vWHORAIREDOCTEURBindingSource.DataSource = this.dataSetRedoc;
            // 
            // vW_HORAIRE_DOCTEURTableAdapter
            // 
            this.vW_HORAIRE_DOCTEURTableAdapter.ClearBeforeFill = true;
            // 
            // vW_EXCEPTION_HORAIRE_DOCTEURTableAdapter
            // 
            this.vW_EXCEPTION_HORAIRE_DOCTEURTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDoctorSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 628);
            this.Controls.Add(this.grpScheduleExceptions);
            this.Controls.Add(this.grpWeekSchedule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmDoctorSchedule";
            this.Text = "REDOC - Gestion horaires";
            this.Load += new System.EventHandler(this.FrmDoctorSchedule_Load);
            this.grpWeekSchedule.ResumeLayout(false);
            this.grpWeekSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeekSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShiftEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShiftStart)).EndInit();
            this.grpScheduleExceptions.ResumeLayout(false);
            this.grpScheduleExceptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExceptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWEXCEPTIONHORAIREDOCTEURBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRedoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWHORAIREDOCTEURBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpWeekSchedule;
        private System.Windows.Forms.GroupBox grpScheduleExceptions;
        private System.Windows.Forms.Label lblWeekday;
        private System.Windows.Forms.ComboBox cmbWeekday;
        private System.Windows.Forms.NumericUpDown nudShiftEnd;
        private System.Windows.Forms.NumericUpDown nudShiftStart;
        private System.Windows.Forms.Label lblShiftEnd;
        private System.Windows.Forms.Label lblShiftStart;
        private System.Windows.Forms.DataGridView dgvWeekSchedule;
        private System.Windows.Forms.Button btnAddSchedule;
        private System.Windows.Forms.Button btnDeleteSelectedSchedule;
        private System.Windows.Forms.Label lblExceptionDateStart;
        private System.Windows.Forms.DateTimePicker dtpExceptionStart;
        private System.Windows.Forms.TextBox txbExceptionComment;
        private System.Windows.Forms.Label lblExceptionComment;
        private System.Windows.Forms.Button btnDeleteSelectedException;
        private System.Windows.Forms.Button btnAddException;
        private System.Windows.Forms.DataGridView dgvExceptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOURDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hEUREDÉBUTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hEUREFINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEHEUREDÉBUTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEHEUREFINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMMENTAIREDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblExceptionDateEnd;
        private System.Windows.Forms.DateTimePicker dtpExceptionEnd;
        private DataSetRedoc dataSetRedoc;
        private System.Windows.Forms.BindingSource vWHORAIREDOCTEURBindingSource;
        private DataSetRedocTableAdapters.VW_HORAIRE_DOCTEURTableAdapter vW_HORAIRE_DOCTEURTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORJOURDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORDEBUTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORFINDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vWEXCEPTIONHORAIREDOCTEURBindingSource;
        private DataSetRedocTableAdapters.VW_EXCEPTION_HORAIRE_DOCTEURTableAdapter vW_EXCEPTION_HORAIRE_DOCTEURTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXCDEBUTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXCFINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXCCOMMENTAIREDataGridViewTextBoxColumn;
    }
}