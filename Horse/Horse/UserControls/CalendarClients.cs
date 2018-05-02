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
        public string name;
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
        public CalendarClients(string namecli)
        {
            InitializeComponent();
            this.name = namecli;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtDate.Text = Calendar.SelectionStart.ToString();
        }

        private void btnSaveCalendar_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            Forms.Clients clients = new Forms.Clients(1);
            clients.Show();
            clients.BringToFront();
        }

        private void CalendarClients_Load(object sender, EventArgs e)
        {

            txtClient.Text = this.name;
        }
    }
}
