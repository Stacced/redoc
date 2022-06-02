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
        public FrmDoctorSchedule()
        {
            InitializeComponent();
        }

        private void FrmDoctorSchedule_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSetRedoc.VW_EXCEPTION_HORAIRE_DOCTEUR'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vW_EXCEPTION_HORAIRE_DOCTEURTableAdapter.FillByUtiNo(this.dataSetRedoc.VW_EXCEPTION_HORAIRE_DOCTEUR, FrmLogin.userNo);
            // TODO: cette ligne de code charge les données dans la table 'dataSetRedoc.VW_HORAIRE_DOCTEUR'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vW_HORAIRE_DOCTEURTableAdapter.FillByUtiNo(this.dataSetRedoc.VW_HORAIRE_DOCTEUR, FrmLogin.userNo);
        }
    }
}
