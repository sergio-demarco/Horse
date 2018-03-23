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
    public partial class ModifyStock : UserControl
    {
        private static ModifyStock _instance;

        public static ModifyStock Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ModifyStock();
                return _instance;
            }
        }
        public ModifyStock()
        {
            InitializeComponent();
        }
    }
}
