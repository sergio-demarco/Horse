using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horse
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            //Services.EmailService myservice = new Services.EmailService();
            //myservice.SendEmail();
            //boton salir tenia esto:
            //Login miLogin = new Login();
            //this.Hide();  // oculta el form inicial 
            //miLogin.ShowDialog(this);  // (muestra el form de tu app)
            //this.Dispose();
        }

        private void ClientsButton_Click(object sender, EventArgs e)
        {

            if (!PanelMainView.Controls.Contains(UserControls.Clients.Instance))
            {

                PanelMainView.Controls.Add(UserControls.Clients.Instance);
                UserControls.Clients.Instance.Dock = DockStyle.Fill;
                UserControls.Clients.Instance.BringToFront();
            }
            else
                UserControls.Clients.Instance.BringToFront();
        }

        private void CalendarButton_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Forms.Calendar))
                {
                    frm.Hide();
                }
            }

            Forms.Calendar myCalendar = new Forms.Calendar();
            myCalendar.Show();
            myCalendar.BringToFront();
            //if (!PanelMainView.Controls.Contains(UserControls.CalendarClients.Instance))
            //{

            //    PanelMainView.Controls.Add(UserControls.CalendarClients.Instance);
            //    UserControls.CalendarClients.Instance.Dock = DockStyle.Fill;
            //    UserControls.CalendarClients.Instance.BringToFront();
            //}
            //else
            //    UserControls.CalendarClients.Instance.BringToFront();

        }

        private void ClientAccountButton_Click(object sender, EventArgs e)
        {
            if (!PanelMainView.Controls.Contains(UserControls.ClientAccount.Instance))
            {

                PanelMainView.Controls.Add(UserControls.ClientAccount.Instance);
                UserControls.ClientAccount.Instance.Dock = DockStyle.Fill;
                UserControls.ClientAccount.Instance.BringToFront();
            }
            else
                UserControls.ClientAccount.Instance.BringToFront();
        }

        private void SaleButton_Click(object sender, EventArgs e)
        {
            if (!PanelMainView.Controls.Contains(UserControls.NewSale.Instance))
            {

                PanelMainView.Controls.Add(UserControls.NewSale.Instance);
                UserControls.NewSale.Instance.Dock = DockStyle.Fill;
                UserControls.NewSale.Instance.BringToFront();
            }
            else
                UserControls.NewSale.Instance.BringToFront();

        }

        private void CutterButton_Click(object sender, EventArgs e)
        {
            if (!PanelMainView.Controls.Contains(UserControls.CutterPrice.Instance))
            {

                PanelMainView.Controls.Add(UserControls.CutterPrice.Instance);
                UserControls.CutterPrice.Instance.Dock = DockStyle.Fill;
                UserControls.CutterPrice.Instance.BringToFront();
            }
            else
                UserControls.CutterPrice.Instance.BringToFront();
        }

        private void FoodButton_Click(object sender, EventArgs e)
        {
            if (!PanelMainView.Controls.Contains(UserControls.FoodPrice.Instance))
            {

                PanelMainView.Controls.Add(UserControls.FoodPrice.Instance);
                UserControls.FoodPrice.Instance.Dock = DockStyle.Fill;
                UserControls.FoodPrice.Instance.BringToFront();
            }
            else
                UserControls.FoodPrice.Instance.BringToFront();

        }

        private void PensionaryButton_Click(object sender, EventArgs e)
        {
            if (!PanelMainView.Controls.Contains(UserControls.PensionerPrice.Instance))
            {

                PanelMainView.Controls.Add(UserControls.PensionerPrice.Instance);
                UserControls.PensionerPrice.Instance.Dock = DockStyle.Fill;
                UserControls.PensionerPrice.Instance.BringToFront();
            }
            else
                UserControls.PensionerPrice.Instance.BringToFront();
        }

        private void VaccineButton_Click(object sender, EventArgs e)
        {
            if (!PanelMainView.Controls.Contains(UserControls.VaccinePrice.Instance))
            {

                PanelMainView.Controls.Add(UserControls.VaccinePrice.Instance);
                UserControls.VaccinePrice.Instance.Dock = DockStyle.Fill;
                UserControls.VaccinePrice.Instance.BringToFront();
            }
            else
                UserControls.VaccinePrice.Instance.BringToFront();
        }

        private void AccesoryButton_Click(object sender, EventArgs e)
        {
            if (!PanelMainView.Controls.Contains(UserControls.AccesoryPrice.Instance))
            {

                PanelMainView.Controls.Add(UserControls.AccesoryPrice.Instance);
                UserControls.AccesoryPrice.Instance.Dock = DockStyle.Fill;
                UserControls.AccesoryPrice.Instance.BringToFront();
            }
            else
                UserControls.AccesoryPrice.Instance.BringToFront();
        }

        private void SurgeryButton_Click(object sender, EventArgs e)
        {
            if (!PanelMainView.Controls.Contains(UserControls.SurgeryPrice.Instance))
            {

                PanelMainView.Controls.Add(UserControls.SurgeryPrice.Instance);
                UserControls.SurgeryPrice.Instance.Dock = DockStyle.Fill;
                UserControls.SurgeryPrice.Instance.BringToFront();
            }
            else
                UserControls.SurgeryPrice.Instance.BringToFront();
        }

        private void AllProductsButton_Click(object sender, EventArgs e)
        {
            if (!PanelMainView.Controls.Contains(UserControls.AllPrice.Instance))
            {

                PanelMainView.Controls.Add(UserControls.AllPrice.Instance);
                UserControls.AllPrice.Instance.Dock = DockStyle.Fill;
                UserControls.AllPrice.Instance.BringToFront();
            }
            else
                UserControls.AllPrice.Instance.BringToFront();
        }

        private void NewStockButton_Click(object sender, EventArgs e)
        {
            if (!PanelMainView.Controls.Contains(UserControls.NewStock.Instance))
            {

                PanelMainView.Controls.Add(UserControls.NewStock.Instance);
                UserControls.NewStock.Instance.Dock = DockStyle.Fill;
                UserControls.NewStock.Instance.BringToFront();
            }
            else
                UserControls.NewStock.Instance.BringToFront();
        }

        public void ModifyStockButton_Click(object sender, EventArgs e)
        {
            if (!PanelMainView.Controls.Contains(UserControls.ModifyStock.Instance))
            {

                PanelMainView.Controls.Add(UserControls.ModifyStock.Instance);
                UserControls.ModifyStock.Instance.Dock = DockStyle.Fill;
                UserControls.ModifyStock.Instance.BringToFront();
            }
            else
                UserControls.ModifyStock.Instance.BringToFront();
        }

        private void SearchStockButton_Click(object sender, EventArgs e)
        {
            if (!PanelMainView.Controls.Contains(UserControls.SearchStock.Instance))
            {

                PanelMainView.Controls.Add(UserControls.SearchStock.Instance);
                UserControls.SearchStock.Instance.Dock = DockStyle.Fill;
                UserControls.SearchStock.Instance.BringToFront();
            }
            else
                UserControls.SearchStock.Instance.BringToFront();
        }

        private void NewSuppliersButton_Click(object sender, EventArgs e)
        {
            if (!PanelMainView.Controls.Contains(UserControls.NewProvider.Instance))
            {

                PanelMainView.Controls.Add(UserControls.NewProvider.Instance);
                UserControls.NewProvider.Instance.Dock = DockStyle.Fill;
                UserControls.NewProvider.Instance.BringToFront();
            }
            else
                UserControls.NewProvider.Instance.BringToFront();
        }

        private void SearchSuppliersButton_Click(object sender, EventArgs e)
        {
            if (!PanelMainView.Controls.Contains(UserControls.SearchProvider.Instance))
            {

                PanelMainView.Controls.Add(UserControls.SearchProvider.Instance);
                UserControls.SearchProvider.Instance.Dock = DockStyle.Fill;
                UserControls.SearchProvider.Instance.BringToFront();
            }
            else
                UserControls.SearchProvider.Instance.BringToFront();
        }

        private void PrintSuppliersButton_Click(object sender, EventArgs e)
        {
            if (!PanelMainView.Controls.Contains(UserControls.PrintProvider.Instance))
            {

                PanelMainView.Controls.Add(UserControls.PrintProvider.Instance);
                UserControls.PrintProvider.Instance.Dock = DockStyle.Fill;
                UserControls.PrintProvider.Instance.BringToFront();
            }
            else
                UserControls.PrintProvider.Instance.BringToFront();
        }

        private void DailyBalanceButton_Click(object sender, EventArgs e)
        {
            if (!PanelMainView.Controls.Contains(UserControls.DailyBalance.Instance))
            {

                PanelMainView.Controls.Add(UserControls.DailyBalance.Instance);
                UserControls.DailyBalance.Instance.Dock = DockStyle.Fill;
                UserControls.DailyBalance.Instance.BringToFront();
            }
            else
                UserControls.DailyBalance.Instance.BringToFront();
        }

        private void MonthlyBalanceButton_Click(object sender, EventArgs e)
        {
            if (!PanelMainView.Controls.Contains(UserControls.MonthlyBalance.Instance))
            {

                PanelMainView.Controls.Add(UserControls.MonthlyBalance.Instance);
                UserControls.MonthlyBalance.Instance.Dock = DockStyle.Fill;
                UserControls.MonthlyBalance.Instance.BringToFront();
            }
            else
                UserControls.MonthlyBalance.Instance.BringToFront();
        }

        private void StaticsSuppliersButton_Click(object sender, EventArgs e)
        {
            if (!PanelMainView.Controls.Contains(UserControls.StaticsBalance.Instance))
            {

                PanelMainView.Controls.Add(UserControls.StaticsBalance.Instance);
                UserControls.StaticsBalance.Instance.Dock = DockStyle.Fill;
                UserControls.StaticsBalance.Instance.BringToFront();
            }
            else
                UserControls.StaticsBalance.Instance.BringToFront();
        }

        private void NewClient_Click(object sender, EventArgs e)
        {
            if (!PanelMainView.Controls.Contains(UserControls.NewClient.Instance))
            {

                PanelMainView.Controls.Add(UserControls.NewClient.Instance);
                UserControls.NewClient.Instance.Dock = DockStyle.Fill;
                UserControls.NewClient.Instance.BringToFront();
            }
            else
                UserControls.NewClient.Instance.BringToFront();
        }

        private void DebtsButton_Click(object sender, EventArgs e)
        {
            if (!PanelMainView.Controls.Contains(UserControls.Debts.Instance))
            {

                PanelMainView.Controls.Add(UserControls.Debts.Instance);
                UserControls.Debts.Instance.Dock = DockStyle.Fill;
                UserControls.Debts.Instance.BringToFront();
            }
            else
                UserControls.Debts.Instance.BringToFront();
        }
    }
}
