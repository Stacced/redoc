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
    public partial class FrmPatients : Form
    {
        public FrmPatients()
        {
            InitializeComponent();
        }

        private void FrmPatients_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSetRedoc.VW_PATIENT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vW_PATIENTTableAdapter.Fill(this.dataSetRedoc.VW_PATIENT);
            // TODO: cette ligne de code charge les données dans la table 'dataSetRedoc.VWR_PATIENT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vW_PATIENTTableAdapter.Fill(this.dataSetRedoc.VW_PATIENT);

            this.adgvSearch.SetColumns(adgvPatients.Columns);
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            FrmAddEditPatient frm = new FrmAddEditPatient(false);
            frm.ShowDialog();
        }

        private void adgvSearch_Search(object sender, Zuby.ADGV.AdvancedDataGridViewSearchToolBarSearchEventArgs e)
        {
            bool restartsearch = true;
            int startColumn = 0;
            int startRow = 0;
            if (!e.FromBegin)
            {
                bool endcol = adgvPatients.CurrentCell.ColumnIndex + 1 >= adgvPatients.ColumnCount;
                bool endrow = adgvPatients.CurrentCell.RowIndex + 1 >= adgvPatients.RowCount;

                if (endcol && endrow)
                {
                    startColumn = adgvPatients.CurrentCell.ColumnIndex;
                    startRow = adgvPatients.CurrentCell.RowIndex;
                }
                else
                {
                    startColumn = endcol ? 0 : adgvPatients.CurrentCell.ColumnIndex + 1;
                    startRow = adgvPatients.CurrentCell.RowIndex + (endcol ? 1 : 0);
                }
            }
            DataGridViewCell c = adgvPatients.FindCell(
                e.ValueToSearch,
                e.ColumnToSearch != null ? e.ColumnToSearch.Name : null,
                startRow,
                startColumn,
                e.WholeWord,
                e.CaseSensitive);
            if (c == null && restartsearch)
                c = adgvPatients.FindCell(
                    e.ValueToSearch,
                    e.ColumnToSearch != null ? e.ColumnToSearch.Name : null,
                    0,
                    0,
                    e.WholeWord,
                    e.CaseSensitive);
            if (c != null)
                adgvPatients.CurrentCell = c;
        }

        private void adgvPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = adgvPatients.Rows[e.RowIndex];
            FrmPatientFile frm = new FrmPatientFile(0);
            frm.ShowDialog();
        }
    }
}
