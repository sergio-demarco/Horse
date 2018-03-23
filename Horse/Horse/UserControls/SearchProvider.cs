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
    public partial class SearchProvider : UserControl
    {
        private static SearchProvider _instance;

        public static SearchProvider Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SearchProvider();
                return _instance;
            }
        }
        public SearchProvider()
        {
            InitializeComponent();
        }
    }
}
