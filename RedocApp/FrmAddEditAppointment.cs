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
    public partial class FrmAddEditAppointment : Form
    {
        bool isEdit = false;
        public FrmAddEditAppointment()
        {
            InitializeComponent();
        }

        public FrmAddEditAppointment(bool isEdit)
        {
            InitializeComponent();
            this.isEdit = isEdit;
        }

        private void FrmAddEditAppointment_Load(object sender, EventArgs e)
        {
            if (isEdit)
            {
                lblAddEditAppointment.Text = "Modification rendez-vous";
                this.Text = "REDOC - Modification rendez-vous";
            } else
            {
                lblAddEditAppointment.Text = "Ajout rendez-vous";
                this.Text = "REDOC - Ajout d'un rendez-vous";
            }
        }
    }
}
