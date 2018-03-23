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
    public partial class PrintProvider : UserControl
    {
        private static PrintProvider _instance;

        public static PrintProvider Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PrintProvider();
                return _instance;
            }
        }
        public PrintProvider()
        {
            InitializeComponent();
        }
    }
}
