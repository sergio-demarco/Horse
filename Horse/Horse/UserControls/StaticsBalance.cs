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
    public partial class StaticsBalance : UserControl
    {
        private static StaticsBalance _instance;

        public static StaticsBalance Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new StaticsBalance();
                return _instance;
            }
        }
        public StaticsBalance()
        {
            InitializeComponent();
        }
    }
}
