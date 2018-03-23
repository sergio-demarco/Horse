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
    public partial class SurgeryPrice : UserControl
    {
        private static SurgeryPrice _instance;

        public static SurgeryPrice Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SurgeryPrice();
                return _instance;
            }
        }
        public SurgeryPrice()
        {
            InitializeComponent();
        }
    }
}
