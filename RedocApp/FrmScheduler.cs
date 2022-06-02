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
    public partial class FrmScheduler : Form
    {
        public FrmScheduler()
        {
            InitializeComponent();
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            FrmAddEditAppointment frm = new FrmAddEditAppointment();
            frm.ShowDialog();
        }

        private void dgvAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                FrmAddEditAppointment frm = new FrmAddEditAppointment();
                frm.ShowDialog();
            }
        }

        private void FrmScheduler_Load(object sender, EventArgs e)
        {
            this.btnAddAppointment.Enabled = FrmDashboard.userType == FrmLogin.UserType.ASSISTANT;
            this.adgvSearch.SetColumns(adgvAppointments.Columns);
        }

        private void adgvSearch_Search(object sender, Zuby.ADGV.AdvancedDataGridViewSearchToolBarSearchEventArgs e)
        {
            bool restartsearch = true;
            int startColumn = 0;
            int startRow = 0;
            if (!e.FromBegin)
            {
                bool endcol = adgvAppointments.CurrentCell.ColumnIndex + 1 >= adgvAppointments.ColumnCount;
                bool endrow = adgvAppointments.CurrentCell.RowIndex + 1 >= adgvAppointments.RowCount;

                if (endcol && endrow)
                {
                    startColumn = adgvAppointments.CurrentCell.ColumnIndex;
                    startRow = adgvAppointments.CurrentCell.RowIndex;
                }
                else
                {
                    startColumn = endcol ? 0 : adgvAppointments.CurrentCell.ColumnIndex + 1;
                    startRow = adgvAppointments.CurrentCell.RowIndex + (endcol ? 1 : 0);
                }
            }
            DataGridViewCell c = adgvAppointments.FindCell(
                e.ValueToSearch,
                e.ColumnToSearch != null ? e.ColumnToSearch.Name : null,
                startRow,
                startColumn,
                e.WholeWord,
                e.CaseSensitive);
            if (c == null && restartsearch)
                c = adgvAppointments.FindCell(
                    e.ValueToSearch,
                    e.ColumnToSearch != null ? e.ColumnToSearch.Name : null,
                    0,
                    0,
                    e.WholeWord,
                    e.CaseSensitive);
            if (c != null)
                adgvAppointments.CurrentCell = c;
        }
    }
}
