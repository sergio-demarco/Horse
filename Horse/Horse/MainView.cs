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
            //boton salir tenia esto:
            //Login miLogin = new Login();
            //this.Hide();  // oculta el form inicial 
            //miLogin.ShowDialog(this);  // (muestra el form de tu app)
            //this.Dispose();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login miLogin = new Login();
            this.Hide();  // oculta el form inicial 
            miLogin.ShowDialog(this);  // (muestra el form de tu app)
            this.Dispose();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Password pass = new Forms.Password();
            pass.Show();
        }

        private void miContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.MyPass pass = new Forms.MyPass();
            pass.Show();
        }

        private void gestionarPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Permision myPermission  = new Forms.Permision();
            myPermission.Show();
        }

        private void ClientsButton_Click(object sender, EventArgs e)
        {
            MainMenuForms.Clients myClients = new MainMenuForms.Clients();
            myClients.Show();
        }

        private void EditClientButton_Click(object sender, EventArgs e)
        {
            MainMenuForms.ModifyClients myModifyClients = new MainMenuForms.ModifyClients();
            myModifyClients.Show();
        }

        private void CalendarButton_Click(object sender, EventArgs e)
        {
            MainMenuForms.CalendarClients myCalendarClients = new MainMenuForms.CalendarClients();
            myCalendarClients.Show();
        }

        private void ClientAccountButton_Click(object sender, EventArgs e)
        {
            MainMenuForms.ClientAccount myClientAccount = new MainMenuForms.ClientAccount();
            myClientAccount.Show();
        }

        private void SaleButton_Click(object sender, EventArgs e)
        {
            MainMenuForms.NewSale myNewSale = new MainMenuForms.NewSale();
            myNewSale.Show();
        }

        private void CutterButton_Click(object sender, EventArgs e)
        {
            MainMenuForms.CutterPrice myCutterPrice = new MainMenuForms.CutterPrice();
            myCutterPrice.Show();
        }

        private void FoodButton_Click(object sender, EventArgs e)
        {
            MainMenuForms.FoodPrice myFoodPrice = new MainMenuForms.FoodPrice();
            myFoodPrice.Show();
        }

        private void PensionaryButton_Click(object sender, EventArgs e)
        {
            MainMenuForms.PensionerPrice myPensionerPrice = new MainMenuForms.PensionerPrice();
            myPensionerPrice.Show();
        }

        private void VaccineButton_Click(object sender, EventArgs e)
        {
            MainMenuForms.VaccinePrice myVaccinePrice = new MainMenuForms.VaccinePrice();
            myVaccinePrice.Show();
        }

        private void AccesoryButton_Click(object sender, EventArgs e)
        {
            MainMenuForms.AccesoryPrice myAccesoryPrice = new MainMenuForms.AccesoryPrice();
            myAccesoryPrice.Show();
        }

        private void SurgeryButton_Click(object sender, EventArgs e)
        {
            MainMenuForms.SurgeryPrice mySurgeryPrice = new MainMenuForms.SurgeryPrice();
            mySurgeryPrice.Show();
        }

        private void AllProductsButton_Click(object sender, EventArgs e)
        {
            MainMenuForms.AllPrice myAllPrice = new MainMenuForms.AllPrice();
            myAllPrice.Show();
        }

        private void NewStockButton_Click(object sender, EventArgs e)
        {
            MainMenuForms.NewStock myNewStock = new MainMenuForms.NewStock();
            myNewStock.Show();
        }

        private void ModifyStockButton_Click(object sender, EventArgs e)
        {
            MainMenuForms.ModifyStock myModifyStock = new MainMenuForms.ModifyStock();
            myModifyStock.Show();
        }

        private void SearchStockButton_Click(object sender, EventArgs e)
        {
            MainMenuForms.SearchStock mySearchStock = new MainMenuForms.SearchStock();
            mySearchStock.Show();
        }

        private void NewSuppliersButton_Click(object sender, EventArgs e)
        {
            MainMenuForms.NewProvider myNewProvider = new MainMenuForms.NewProvider();
            myNewProvider.Show();
        }

        private void SearchSuppliersButton_Click(object sender, EventArgs e)
        {
            MainMenuForms.SearchProvider mySearchProvider = new MainMenuForms.SearchProvider();
            mySearchProvider.Show();
        }

        private void PrintSuppliersButton_Click(object sender, EventArgs e)
        {
            MainMenuForms.PrintProvider myPrintProvider = new MainMenuForms.PrintProvider();
            myPrintProvider.Show();
        }

        private void DailyBalanceButton_Click(object sender, EventArgs e)
        {
            MainMenuForms.DailyBalance myDailyBalance = new MainMenuForms.DailyBalance();
            myDailyBalance.Show();
        }

        private void MonthlyBalanceButton_Click(object sender, EventArgs e)
        {
            MainMenuForms.MonthlyBalance myMonthlyBalance = new MainMenuForms.MonthlyBalance();
            myMonthlyBalance.Show();
        }

        private void StaticsSuppliersButton_Click(object sender, EventArgs e)
        {
            MainMenuForms.StaticsBalance myStaticsBalance = new MainMenuForms.StaticsBalance();
            myStaticsBalance.Show();
        }

        private void NewClient_Click(object sender, EventArgs e)
        {
            MainMenuForms.NewClient myNewClient = new MainMenuForms.NewClient();
            myNewClient.Show();
        }
    }
}
