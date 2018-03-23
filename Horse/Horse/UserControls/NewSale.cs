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
    public partial class NewSale : UserControl
    {
        private static NewSale _instance;

        public static NewSale Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NewSale();
                return _instance;
            }
        }
        public NewSale()
        {
            InitializeComponent();
        }
    }
}
