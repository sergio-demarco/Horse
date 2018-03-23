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
    public partial class SearchStock : UserControl
    {
        private static SearchStock _instance;

        public static SearchStock Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SearchStock();
                return _instance;
            }
        }
        public SearchStock()
        {
            InitializeComponent();
        }
    }
}
