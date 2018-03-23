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
    public partial class ClientAccount : UserControl
    {
        private static ClientAccount _instance;

        public static ClientAccount Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ClientAccount();
                return _instance;
            }
        }
        public ClientAccount()
        {
            InitializeComponent();
        }
    }
}
