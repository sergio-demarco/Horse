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
    public partial class NewStock : UserControl
    {
        private static NewStock _instance;

        public static NewStock Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NewStock();
                return _instance;
            }
        }
        public NewStock()
        {
            InitializeComponent();
        }
    }
}
