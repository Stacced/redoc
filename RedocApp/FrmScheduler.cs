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
            FrmAddEditAppointment frm = new FrmAddEditAppointment(false);
            frm.ShowDialog();
            LoadData();
        }

        private void FrmScheduler_Load(object sender, EventArgs e)
        {
            LoadData();   
            
            this.adgvSearch.SetColumns(adgvAppointments.Columns);
        }

        private void LoadData()
        {
            if (FrmLogin.userType == FrmLogin.UserType.ASSISTANT)
            {
                // TODO: cette ligne de code charge les données dans la table 'dataSetRedoc.VW_RENDEZVOUS'. Vous pouvez la déplacer ou la supprimer selon les besoins.
                this.vW_RENDEZVOUSTableAdapter.Fill(this.dataSetRedoc.VW_RENDEZVOUS);
                this.btnAddAppointment.Enabled = true;
            }
            else
            {
                this.vW_RENDEZVOUSTableAdapter.FillByDocNo(this.dataSetRedoc.VW_RENDEZVOUS, FrmLogin.userNo);
                this.btnAddAppointment.Enabled = false;
            }
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

        private void adgvAppointments_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = adgvAppointments.Rows[e.RowIndex];
            if (selectedRow.Cells[0] != null)
            {
                FrmAddEditAppointment frm = new FrmAddEditAppointment(true, int.Parse(selectedRow.Cells[0].Value.ToString()));
                frm.ShowDialog();
                LoadData();
            }
        }
    }
}
