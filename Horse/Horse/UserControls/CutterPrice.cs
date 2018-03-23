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
    public partial class CutterPrice : UserControl
    {
        private static CutterPrice _instance;

        public static CutterPrice Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CutterPrice();
                return _instance;
            }
        }
        public CutterPrice()
        {
            InitializeComponent();
        }
    }
}
