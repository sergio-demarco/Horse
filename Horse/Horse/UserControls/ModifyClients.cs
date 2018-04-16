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
    public partial class ModifyClients : UserControl
    {
        private static ModifyClients _instance;

        public static ModifyClients Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ModifyClients();
                return _instance;
            }
        }
        public ModifyClients()
        {
            InitializeComponent();
        }
        public UserControl modifyClie()
        {
            InitializeComponent();
            _instance = new ModifyClients();
            return _instance;
        }
    }
}
