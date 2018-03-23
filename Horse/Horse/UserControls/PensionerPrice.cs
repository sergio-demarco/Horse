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
    public partial class PensionerPrice : UserControl
    {
        private static PensionerPrice _instance;

        public static PensionerPrice Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PensionerPrice();
                return _instance;
            }
        }
        public PensionerPrice()
        {
            InitializeComponent();
        }
    }
}
