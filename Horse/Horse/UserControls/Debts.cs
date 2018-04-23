using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horse.UserControls
{
    public partial class Debts : UserControl
    {
        private static Debts _instance;
        public static Debts Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Debts();
                return _instance;
            }
        }
        public Debts()
        {
            InitializeComponent();
        }

        private void Debts_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
