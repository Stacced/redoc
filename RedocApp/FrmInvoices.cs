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
    public partial class FrmInvoices : Form
    {
        public FrmInvoices()
        {
            InitializeComponent();
        }

        private void FrmInvoices_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSetRedoc.VW_FACTURE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vW_FACTURETableAdapter.Fill(this.dataSetRedoc.VW_FACTURE);
        }

        private void adgvSearch_Search(object sender, Zuby.ADGV.AdvancedDataGridViewSearchToolBarSearchEventArgs e)
        {
            bool restartsearch = true;
            int startColumn = 0;
            int startRow = 0;
            if (!e.FromBegin)
            {
                bool endcol = adgvInvoices.CurrentCell.ColumnIndex + 1 >= adgvInvoices.ColumnCount;
                bool endrow = adgvInvoices.CurrentCell.RowIndex + 1 >= adgvInvoices.RowCount;

                if (endcol && endrow)
                {
                    startColumn = adgvInvoices.CurrentCell.ColumnIndex;
                    startRow = adgvInvoices.CurrentCell.RowIndex;
                }
                else
                {
                    startColumn = endcol ? 0 : adgvInvoices.CurrentCell.ColumnIndex + 1;
                    startRow = adgvInvoices.CurrentCell.RowIndex + (endcol ? 1 : 0);
                }
            }
            DataGridViewCell c = adgvInvoices.FindCell(
                e.ValueToSearch,
                e.ColumnToSearch != null ? e.ColumnToSearch.Name : null,
                startRow,
                startColumn,
                e.WholeWord,
                e.CaseSensitive);
            if (c == null && restartsearch)
                c = adgvInvoices.FindCell(
                    e.ValueToSearch,
                    e.ColumnToSearch != null ? e.ColumnToSearch.Name : null,
                    0,
                    0,
                    e.WholeWord,
                    e.CaseSensitive);
            if (c != null)
                adgvInvoices.CurrentCell = c;
        }
    }
}
