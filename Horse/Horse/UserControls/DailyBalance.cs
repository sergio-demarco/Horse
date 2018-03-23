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
    public partial class DailyBalance : UserControl
    {
        private static DailyBalance _instance;

        public static DailyBalance Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DailyBalance();
                return _instance;
            }
        }
        public DailyBalance()
        {
            InitializeComponent();
        }
    }
}
