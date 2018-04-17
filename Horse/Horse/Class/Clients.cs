using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horse.Class
{
    public class Clients
    {
        private string id = string.Empty;
        private string name = string.Empty;
        private string lastname = string.Empty;
        private string email = string.Empty;
        private string cuit = string.Empty;
        private string dni = string.Empty;
        private string adress = string.Empty;
        private string location = string.Empty;
        private string petname = string.Empty;
        private string razonsoc = string.Empty;
        private string phone = string.Empty;
        private string phone2 = string.Empty;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Email { get => email; set => email = value; }
        public string Cuit { get => cuit; set => cuit = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Adress { get => adress; set => adress = value; }
        public string Location { get => location; set => location = value; }
        public string Petname { get => petname; set => petname = value; }
        public string Razonsoc { get => razonsoc; set => razonsoc = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Phone2 { get => phone2; set => phone2 = value; }

        public Clients()
        {

        }

        public Clients(string id, string name, string lastname, string email, string cuit, string dni, string adress, string location, string petname, string razonsoc, string phone, string phone2)
        {
            Id = id;
            Name = name;
            Lastname = lastname;
            Email = email;
            Cuit = cuit;
            Dni = dni;
            Adress = adress;
            Location = location;
            Petname = petname;
            Razonsoc = razonsoc;
            Phone = phone;
            Phone2 = phone2;
        }
    }
}
