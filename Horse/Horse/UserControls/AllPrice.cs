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
    public partial class AllPrice : UserControl
    {
        private static AllPrice _instance;

        public static AllPrice Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AllPrice();
                return _instance;
            }
        }
        public AllPrice()
        {
            InitializeComponent();
        }
    }
}
