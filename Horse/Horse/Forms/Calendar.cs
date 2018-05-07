using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horse.Forms
{
    public partial class Calendar : Form
    {
        private Class.Clients myClient;
        public Calendar()
        {
            InitializeComponent();
            btnSaveCalendar.Enabled = false;
        }
        public Calendar(Class.Clients client)
        {
            InitializeComponent();
            myClient = client;
            txtClient.Text = client.Name.ToString();
            btnSaveCalendar.Enabled = true;
        }

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            Forms.Clients clients = new Clients();
            this.Close();
            clients.Show();
            clients.BringToFront();
        }

        private void btnSaveCalendar_Click(object sender, EventArgs e)
        {
            
            int addDays = Convert.ToInt16(numericPeriodDays.Value);
            if (addDays<1 || txtDate.Text==null || txtDate.Text=="")
            {
                Color myColor = System.Drawing.Color.Red;
                Forms.DialogOk insertOk = new Forms.DialogOk("Todos los campos deben ser completados", myColor);
                insertOk.Show();
                insertOk.BringToFront();
            }
            else
            {
                try
                {
                    Class.LoginController MyConnection = new Class.LoginController();
                    SqlConnection connection = MyConnection.getConnection();

                    int count = 0;
                    using (var command = new SqlCommand("InsertCalendarVacine", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Connection.Open();
                        command.Parameters.AddWithValue("@idClient", myClient.Id.ToString());
                        command.Parameters.AddWithValue("@startDate", DateTime.Parse(txtDate.Text));
                        command.Parameters.AddWithValue("@period", numericPeriodDays.Value);
                        command.Parameters.AddWithValue("@dateFrom", DateTime.Parse(txtDate.Text));
                        command.Parameters.AddWithValue("@dateTo", (DateTime.Parse(txtDate.Text)).AddDays(addDays));

                        count = command.ExecuteNonQuery();
                        if (count > 0)
                        {
                            Color myColor = System.Drawing.Color.Black;
                            Forms.DialogOk insertOk = new Forms.DialogOk("Los datos fueron grabados con exito!", myColor);
                            insertOk.Show();
                            insertOk.BringToFront();
                        }
                    }

                }
                catch (Exception ec)
                {
                    string a = ec.ToString();
                }
            }
               
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtDate.Text = monthCalendar1.SelectionStart.ToString("dd/MM/yyyy");
        }
    }
}
