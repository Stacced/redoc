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
    public partial class FrmExams : Form
    {
        private static FrmExams _instance = null;

        private FrmExams()
        {
            InitializeComponent();
        }

        public static FrmExams GetInstance()
        {
            if (_instance == null)
            {
                _instance = new FrmExams();
            }

            return _instance;
        }
    }
}
