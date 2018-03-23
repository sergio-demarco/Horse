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
    public partial class AccesoryPrice : UserControl
    {
        private static AccesoryPrice _instance;

        public static AccesoryPrice Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AccesoryPrice();
                return _instance;
            }
        }
        public AccesoryPrice()
        {
            InitializeComponent();
        }
    }
}
