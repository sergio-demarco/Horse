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
    public partial class MonthlyBalance : UserControl
    {
        private static MonthlyBalance _instance;

        public static MonthlyBalance Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MonthlyBalance();
                return _instance;
            }
        }
        public MonthlyBalance()
        {
            InitializeComponent();
        }
    }
}
