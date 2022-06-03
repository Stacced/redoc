using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedocApp
{
    public partial class FrmDoctorSchedule : Form
    {
        public enum WeekDay
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5
        }

        public FrmDoctorSchedule()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSetRedoc.VW_EXCEPTION_HORAIRE_DOCTEUR'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vW_EXCEPTION_HORAIRE_DOCTEURTableAdapter.FillByUtiNo(this.dataSetRedoc.VW_EXCEPTION_HORAIRE_DOCTEUR, FrmLogin.userNo);
            // TODO: cette ligne de code charge les données dans la table 'dataSetRedoc.VW_HORAIRE_DOCTEUR'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vW_HORAIRE_DOCTEURTableAdapter.FillByUtiNo(this.dataSetRedoc.VW_HORAIRE_DOCTEUR, FrmLogin.userNo);
        }

        private void FrmDoctorSchedule_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            WeekDay day = (WeekDay)cmbWeekday.SelectedIndex + 1;
            int startHour = (int)nudShiftStart.Value;
            int endHour = (int)nudShiftEnd.Value;

            if (startHour < endHour)
            {
                DataSetRedocTableAdapters.QueriesTableAdapter request = new DataSetRedocTableAdapters.QueriesTableAdapter();
                request.PKG_REDOC_ADDDOCSCHEDULE(FrmLogin.userNo, startHour, endHour, (int)day);
                LoadData();
            } else
            {
                MessageBox.Show("L'heure de fin ne peut pas être inférieure à l'heure de début", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddException_Click(object sender, EventArgs e)
        {
            DateTime exceptionStart = dtpExceptionStart.Value;
            DateTime exceptionEnd = dtpExceptionEnd.Value;
            string notes = txtExceptionComment.Text;

            if (exceptionStart < exceptionEnd)
            {
                DataSetRedocTableAdapters.QueriesTableAdapter request = new DataSetRedocTableAdapters.QueriesTableAdapter();
                request.PKG_REDOC_ADDDOCSCHEDULEEXCEPTION(FrmLogin.userNo, exceptionStart, exceptionEnd, notes);
                LoadData();
            } else
            {
                MessageBox.Show("La date de fin ne peut pas être inférieure à la date de début", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteSelectedSchedule_Click(object sender, EventArgs e)
        {
            if (dgvWeekSchedule.CurrentRow != null)
            {
                DataSetRedocTableAdapters.QueriesTableAdapter request = new DataSetRedocTableAdapters.QueriesTableAdapter();
                request.PKG_REDOC_DELETEDOCSCHEDULE(int.Parse(dgvWeekSchedule.CurrentRow.Cells[0].Value.ToString()));
                LoadData();
            }
        }

        private void btnDeleteSelectedException_Click(object sender, EventArgs e)
        {
            if (dgvExceptions.CurrentRow != null)
            {
                DataSetRedocTableAdapters.QueriesTableAdapter request = new DataSetRedocTableAdapters.QueriesTableAdapter();
                request.PKG_REDOC_DELETEDOCSCHEDULEEXCEPTION(int.Parse(dgvExceptions.CurrentRow.Cells[0].Value.ToString()));
                LoadData();
            }
        }
    }
}
