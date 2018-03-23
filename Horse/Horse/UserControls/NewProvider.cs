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
    public partial class NewProvider : UserControl
    {
        private static NewProvider _instance;

        public static NewProvider Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NewProvider();
                return _instance;
            }
        }
        public NewProvider()
        {
            InitializeComponent();
        }
    }
}
