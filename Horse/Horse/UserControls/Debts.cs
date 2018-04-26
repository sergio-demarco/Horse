﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Horse.UserControls
{
    public partial class Debts : UserControl
    {
        private static Debts _instance;
        public static Debts Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Debts();
                return _instance;
            }
        }
        public Debts()
        {
            InitializeComponent();
        }

        private void Debts_Load(object sender, EventArgs e)
        {
            dropOrderBy.SelectedItem= dropOrderBy.Items[0];
            //select d.indebt,d.infavor,c.name,c.lastname,c.phone,c.phone2 from clients c inner  join debts d on c.id=d.idCliente 
            //            string query = "select d.indebt,d.infavor,c.name,c.lastname,c.phone,c.phone2 from clients c inner  join debts d on c.id=d.idCliente  ";
            string query = "select isnull(sum(d.indebt),'0') as indebt,isnull(sum(d.infavor),'0') as infavor,c.name,c.lastname,c.phone,c.phone2 from clients c left outer join debts d on c.id = d.idCliente group by c.name,c.lastname,c.phone,c.phone2 order by indebt desc";
            txtClients.Focus();
            Class.LoginController MyConnection = new Class.LoginController();
            SqlConnection connection = MyConnection.getConnection();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = connection;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = query;
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            dataClients.AutoGenerateColumns = false;
            dataClients.DataSource = dtRecord;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void dropOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            var d = dropOrderBy.SelectedItem.ToString();
            if (dropOrderBy.SelectedItem.ToString() == "Debe")
            {
                dataClients.Sort(dataClients.Columns[1], ListSortDirection.Descending);


            }
            else
            {
                dataClients.Sort(dataClients.Columns[2], ListSortDirection.Descending);
            }
            
        }

        private void dataClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataClients.Columns[e.ColumnIndex].Name.Equals("Agregar"))
            {
                DataGridViewRow row = this.dataClients.Rows[e.RowIndex];

                string name = row.Cells[3].Value.ToString();
                string lastname = row.Cells[4].Value.ToString();

                Forms.AddDebts addDebts = new Forms.AddDebts(name,lastname);
                addDebts.Show();

                //Class.Clients cliente = new Class.Clients(id, name, lastname, email, cuit, dni, adress, location, petname, razonsoc, phone, phone2);

                //Forms.ModifyClient modifyClient = new Forms.ModifyClient(cliente);
                //modifyClient.Show();
            }
        }
    }
}
