
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
            this.grpWeekSchedule = new System.Windows.Forms.GroupBox();
            this.btnDeleteSelectedSchedule = new System.Windows.Forms.Button();
            this.btnAddSchedule = new System.Windows.Forms.Button();
            this.dgvWeekSchedule = new System.Windows.Forms.DataGridView();
            this.colWeekday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShiftStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShiftEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblShiftEnd = new System.Windows.Forms.Label();
            this.lblShiftStart = new System.Windows.Forms.Label();
            this.nudShiftEnd = new System.Windows.Forms.NumericUpDown();
            this.nudShiftStart = new System.Windows.Forms.NumericUpDown();
            this.lblWeekday = new System.Windows.Forms.Label();
            this.cmbWeekday = new System.Windows.Forms.ComboBox();
            this.grpScheduleExceptions = new System.Windows.Forms.GroupBox();
            this.dgvExceptions = new System.Windows.Forms.DataGridView();
            this.colExceptionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExceptionStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExceptionEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteSelectedException = new System.Windows.Forms.Button();
            this.btnAddException = new System.Windows.Forms.Button();
            this.nudExceptionEnd = new System.Windows.Forms.NumericUpDown();
            this.txbExceptionComment = new System.Windows.Forms.TextBox();
            this.nudExceptionStart = new System.Windows.Forms.NumericUpDown();
            this.lblExceptionComment = new System.Windows.Forms.Label();
            this.lblExceptionEnd = new System.Windows.Forms.Label();
            this.lblExceptionStart = new System.Windows.Forms.Label();
            this.lblExceptionDate = new System.Windows.Forms.Label();
            this.dtpException = new System.Windows.Forms.DateTimePicker();
            this.grpWeekSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeekSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShiftEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShiftStart)).BeginInit();
            this.grpScheduleExceptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExceptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExceptionEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExceptionStart)).BeginInit();
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
            this.grpWeekSchedule.Location = new System.Drawing.Point(12, 12);
            this.grpWeekSchedule.Name = "grpWeekSchedule";
            this.grpWeekSchedule.Size = new System.Drawing.Size(360, 467);
            this.grpWeekSchedule.TabIndex = 0;
            this.grpWeekSchedule.TabStop = false;
            this.grpWeekSchedule.Text = "Horaire hebdomadaire";
            // 
            // btnDeleteSelectedSchedule
            // 
            this.btnDeleteSelectedSchedule.Location = new System.Drawing.Point(238, 136);
            this.btnDeleteSelectedSchedule.Name = "btnDeleteSelectedSchedule";
            this.btnDeleteSelectedSchedule.Size = new System.Drawing.Size(113, 36);
            this.btnDeleteSelectedSchedule.TabIndex = 7;
            this.btnDeleteSelectedSchedule.Text = "&Supprimer horaire sélectionné";
            this.btnDeleteSelectedSchedule.UseVisualStyleBackColor = true;
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.Location = new System.Drawing.Point(9, 136);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(113, 36);
            this.btnAddSchedule.TabIndex = 6;
            this.btnAddSchedule.Text = "&Ajouter horaire";
            this.btnAddSchedule.UseVisualStyleBackColor = true;
            // 
            // dgvWeekSchedule
            // 
            this.dgvWeekSchedule.AllowUserToAddRows = false;
            this.dgvWeekSchedule.AllowUserToDeleteRows = false;
            this.dgvWeekSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWeekSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWeekSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colWeekday,
            this.colShiftStart,
            this.colShiftEnd});
            this.dgvWeekSchedule.Location = new System.Drawing.Point(9, 178);
            this.dgvWeekSchedule.Name = "dgvWeekSchedule";
            this.dgvWeekSchedule.ReadOnly = true;
            this.dgvWeekSchedule.Size = new System.Drawing.Size(342, 283);
            this.dgvWeekSchedule.TabIndex = 8;
            // 
            // colWeekday
            // 
            this.colWeekday.HeaderText = "Jour de la semaine";
            this.colWeekday.Name = "colWeekday";
            this.colWeekday.ReadOnly = true;
            // 
            // colShiftStart
            // 
            this.colShiftStart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colShiftStart.HeaderText = "Heure de début";
            this.colShiftStart.Name = "colShiftStart";
            this.colShiftStart.ReadOnly = true;
            this.colShiftStart.Width = 97;
            // 
            // colShiftEnd
            // 
            this.colShiftEnd.HeaderText = "Heure de fin";
            this.colShiftEnd.Name = "colShiftEnd";
            this.colShiftEnd.ReadOnly = true;
            // 
            // lblShiftEnd
            // 
            this.lblShiftEnd.AutoSize = true;
            this.lblShiftEnd.Location = new System.Drawing.Point(6, 103);
            this.lblShiftEnd.Name = "lblShiftEnd";
            this.lblShiftEnd.Size = new System.Drawing.Size(65, 13);
            this.lblShiftEnd.TabIndex = 4;
            this.lblShiftEnd.Text = "Heure de &fin";
            // 
            // lblShiftStart
            // 
            this.lblShiftStart.AutoSize = true;
            this.lblShiftStart.Location = new System.Drawing.Point(6, 65);
            this.lblShiftStart.Name = "lblShiftStart";
            this.lblShiftStart.Size = new System.Drawing.Size(81, 13);
            this.lblShiftStart.TabIndex = 2;
            this.lblShiftStart.Text = "Heure de &début";
            // 
            // nudShiftEnd
            // 
            this.nudShiftEnd.Location = new System.Drawing.Point(226, 101);
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
            this.nudShiftEnd.Size = new System.Drawing.Size(125, 20);
            this.nudShiftEnd.TabIndex = 5;
            this.nudShiftEnd.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // nudShiftStart
            // 
            this.nudShiftStart.Location = new System.Drawing.Point(226, 63);
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
            this.nudShiftStart.Size = new System.Drawing.Size(125, 20);
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
            this.lblWeekday.Location = new System.Drawing.Point(6, 27);
            this.lblWeekday.Name = "lblWeekday";
            this.lblWeekday.Size = new System.Drawing.Size(95, 13);
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
            this.cmbWeekday.Location = new System.Drawing.Point(226, 24);
            this.cmbWeekday.Name = "cmbWeekday";
            this.cmbWeekday.Size = new System.Drawing.Size(125, 21);
            this.cmbWeekday.TabIndex = 1;
            // 
            // grpScheduleExceptions
            // 
            this.grpScheduleExceptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grpScheduleExceptions.Controls.Add(this.dgvExceptions);
            this.grpScheduleExceptions.Controls.Add(this.btnDeleteSelectedException);
            this.grpScheduleExceptions.Controls.Add(this.btnAddException);
            this.grpScheduleExceptions.Controls.Add(this.nudExceptionEnd);
            this.grpScheduleExceptions.Controls.Add(this.txbExceptionComment);
            this.grpScheduleExceptions.Controls.Add(this.nudExceptionStart);
            this.grpScheduleExceptions.Controls.Add(this.lblExceptionComment);
            this.grpScheduleExceptions.Controls.Add(this.lblExceptionEnd);
            this.grpScheduleExceptions.Controls.Add(this.lblExceptionStart);
            this.grpScheduleExceptions.Controls.Add(this.lblExceptionDate);
            this.grpScheduleExceptions.Controls.Add(this.dtpException);
            this.grpScheduleExceptions.Location = new System.Drawing.Point(378, 12);
            this.grpScheduleExceptions.Name = "grpScheduleExceptions";
            this.grpScheduleExceptions.Size = new System.Drawing.Size(360, 467);
            this.grpScheduleExceptions.TabIndex = 1;
            this.grpScheduleExceptions.TabStop = false;
            this.grpScheduleExceptions.Text = "Exceptions horaire";
            // 
            // dgvExceptions
            // 
            this.dgvExceptions.AllowUserToAddRows = false;
            this.dgvExceptions.AllowUserToDeleteRows = false;
            this.dgvExceptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExceptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExceptions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colExceptionDate,
            this.colExceptionStart,
            this.colExceptionEnd});
            this.dgvExceptions.Location = new System.Drawing.Point(9, 231);
            this.dgvExceptions.Name = "dgvExceptions";
            this.dgvExceptions.ReadOnly = true;
            this.dgvExceptions.Size = new System.Drawing.Size(342, 230);
            this.dgvExceptions.TabIndex = 10;
            // 
            // colExceptionDate
            // 
            this.colExceptionDate.HeaderText = "Date";
            this.colExceptionDate.Name = "colExceptionDate";
            this.colExceptionDate.ReadOnly = true;
            // 
            // colExceptionStart
            // 
            this.colExceptionStart.HeaderText = "Heure de début";
            this.colExceptionStart.Name = "colExceptionStart";
            this.colExceptionStart.ReadOnly = true;
            this.colExceptionStart.Width = 97;
            // 
            // colExceptionEnd
            // 
            this.colExceptionEnd.HeaderText = "Heure de fin";
            this.colExceptionEnd.Name = "colExceptionEnd";
            this.colExceptionEnd.ReadOnly = true;
            // 
            // btnDeleteSelectedException
            // 
            this.btnDeleteSelectedException.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteSelectedException.Location = new System.Drawing.Point(238, 191);
            this.btnDeleteSelectedException.Name = "btnDeleteSelectedException";
            this.btnDeleteSelectedException.Size = new System.Drawing.Size(113, 36);
            this.btnDeleteSelectedException.TabIndex = 9;
            this.btnDeleteSelectedException.Text = "&Supprimer horaire sélectionné";
            this.btnDeleteSelectedException.UseVisualStyleBackColor = true;
            // 
            // btnAddException
            // 
            this.btnAddException.Location = new System.Drawing.Point(9, 191);
            this.btnAddException.Name = "btnAddException";
            this.btnAddException.Size = new System.Drawing.Size(113, 36);
            this.btnAddException.TabIndex = 8;
            this.btnAddException.Text = "&Ajouter exception";
            this.btnAddException.UseVisualStyleBackColor = true;
            // 
            // nudExceptionEnd
            // 
            this.nudExceptionEnd.Location = new System.Drawing.Point(226, 101);
            this.nudExceptionEnd.Maximum = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.nudExceptionEnd.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudExceptionEnd.Name = "nudExceptionEnd";
            this.nudExceptionEnd.Size = new System.Drawing.Size(125, 20);
            this.nudExceptionEnd.TabIndex = 5;
            this.nudExceptionEnd.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // txbExceptionComment
            // 
            this.txbExceptionComment.Location = new System.Drawing.Point(151, 136);
            this.txbExceptionComment.Multiline = true;
            this.txbExceptionComment.Name = "txbExceptionComment";
            this.txbExceptionComment.Size = new System.Drawing.Size(200, 39);
            this.txbExceptionComment.TabIndex = 7;
            // 
            // nudExceptionStart
            // 
            this.nudExceptionStart.Location = new System.Drawing.Point(226, 63);
            this.nudExceptionStart.Maximum = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.nudExceptionStart.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudExceptionStart.Name = "nudExceptionStart";
            this.nudExceptionStart.Size = new System.Drawing.Size(125, 20);
            this.nudExceptionStart.TabIndex = 3;
            this.nudExceptionStart.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // lblExceptionComment
            // 
            this.lblExceptionComment.AutoSize = true;
            this.lblExceptionComment.Location = new System.Drawing.Point(6, 139);
            this.lblExceptionComment.Name = "lblExceptionComment";
            this.lblExceptionComment.Size = new System.Drawing.Size(68, 13);
            this.lblExceptionComment.TabIndex = 6;
            this.lblExceptionComment.Text = "&Commentaire";
            // 
            // lblExceptionEnd
            // 
            this.lblExceptionEnd.AutoSize = true;
            this.lblExceptionEnd.Location = new System.Drawing.Point(6, 103);
            this.lblExceptionEnd.Name = "lblExceptionEnd";
            this.lblExceptionEnd.Size = new System.Drawing.Size(65, 13);
            this.lblExceptionEnd.TabIndex = 4;
            this.lblExceptionEnd.Text = "Heure de &fin";
            // 
            // lblExceptionStart
            // 
            this.lblExceptionStart.AutoSize = true;
            this.lblExceptionStart.Location = new System.Drawing.Point(6, 65);
            this.lblExceptionStart.Name = "lblExceptionStart";
            this.lblExceptionStart.Size = new System.Drawing.Size(81, 13);
            this.lblExceptionStart.TabIndex = 2;
            this.lblExceptionStart.Text = "Heure de &début";
            // 
            // lblExceptionDate
            // 
            this.lblExceptionDate.AutoSize = true;
            this.lblExceptionDate.Location = new System.Drawing.Point(6, 27);
            this.lblExceptionDate.Name = "lblExceptionDate";
            this.lblExceptionDate.Size = new System.Drawing.Size(79, 13);
            this.lblExceptionDate.TabIndex = 0;
            this.lblExceptionDate.Text = "&Date exception";
            // 
            // dtpException
            // 
            this.dtpException.Location = new System.Drawing.Point(151, 24);
            this.dtpException.Name = "dtpException";
            this.dtpException.Size = new System.Drawing.Size(200, 20);
            this.dtpException.TabIndex = 1;
            // 
            // FrmDoctorSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 491);
            this.Controls.Add(this.grpScheduleExceptions);
            this.Controls.Add(this.grpWeekSchedule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDoctorSchedule";
            this.Text = "REDOC - Gestion horaires";
            this.grpWeekSchedule.ResumeLayout(false);
            this.grpWeekSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeekSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShiftEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShiftStart)).EndInit();
            this.grpScheduleExceptions.ResumeLayout(false);
            this.grpScheduleExceptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExceptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExceptionEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExceptionStart)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeekday;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShiftStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShiftEnd;
        private System.Windows.Forms.Button btnAddSchedule;
        private System.Windows.Forms.Button btnDeleteSelectedSchedule;
        private System.Windows.Forms.Label lblExceptionDate;
        private System.Windows.Forms.DateTimePicker dtpException;
        private System.Windows.Forms.TextBox txbExceptionComment;
        private System.Windows.Forms.Label lblExceptionComment;
        private System.Windows.Forms.Label lblExceptionEnd;
        private System.Windows.Forms.Label lblExceptionStart;
        private System.Windows.Forms.NumericUpDown nudExceptionEnd;
        private System.Windows.Forms.NumericUpDown nudExceptionStart;
        private System.Windows.Forms.Button btnDeleteSelectedException;
        private System.Windows.Forms.Button btnAddException;
        private System.Windows.Forms.DataGridView dgvExceptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExceptionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExceptionStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExceptionEnd;
    }
}