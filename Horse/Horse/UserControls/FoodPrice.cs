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
    public partial class FoodPrice : UserControl
    {
        private static FoodPrice _instance;

        public static FoodPrice Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FoodPrice();
                return _instance;
            }
        }
        public FoodPrice()
        {
            InitializeComponent();
        }
    }
}
