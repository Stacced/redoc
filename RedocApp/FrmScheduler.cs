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
        private static FrmScheduler _instance = null;
        private FrmScheduler()
        {
            InitializeComponent();
        }

        public static FrmScheduler GetInstance()
        {
            if (_instance == null)
            {
                _instance = new FrmScheduler();
            }

            return _instance;
        }
    }
}
