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
    public partial class CalendarClients : UserControl
    {
        private static CalendarClients _instance;

        public static CalendarClients Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CalendarClients();
                return _instance;
            }
        }
        public CalendarClients()
        {
            InitializeComponent();
        }
    }
}
