using System;
using System.Data.SqlClient;

namespace ConsoleHorse
{
    class Program
    {
        /*pc*/
        public string firstConectionToSql = @"Data Source=SERGIO-PC\SQLEXPRESS; Integrated Security = True; user id = Sergio - pc\sergio";
        public string connectionToSql = @"Data Source=SERGIO-PC\SQLEXPRESS;Initial Catalog = HORSE; Integrated Security = True; user id = Sergio - pc\sergio";

        /*notebook*/
        //public string firstConectionToSql = @"Data Source=SERGIO-NOTEBOOK\SQLEXPRESS;Integrated Security=True;user id=SERGIO-NOTEBOOK\Admin";
        //public string connectionToSql = @"Data Source=SERGIO-NOTEBOOK\SQLEXPRESS;Initial Catalog=HORSE;Integrated Security=True;user id=SERGIO-NOTEBOOK\Admin";

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a Horse \n Espere mientras el servicio instala su base de datos \n\n Procesando archivos....");
            Program runApp = new Program();
            runApp.statusDataBase();
        }
        public void statusDataBase()
        {
            Program runApp = new Program();
            int numberSQL = 8;
            int partialSql = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = firstConectionToSql;
                    using (var command = new SqlCommand("IF EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'User') SELECT 1 ELSE SELECT 0", connection))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        command.Connection.Open();
                        int exists = (int)command.ExecuteScalar();
                        command.Connection.Close();
                        if (exists == 1)
                        {
                            Console.WriteLine("La base de datos se encuentra instalada previamente");
                            Console.WriteLine("Presione una tecla para salir.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("La base de datos esta generandose...\n Por favor aguarde...");
                            partialSql = runApp.createDatabase() 
                                + runApp.querySQL("CREATE TABLE Users (id int not null identity(1,1) primary key,username varchar(25),pass varchar (25),name varchar (30),lastname varchar(30),adress varchar (30),city varchar(30),country varchar (30),phone varchar(30),active bit,isAdmin bit);", "La tabla *Users* se creo correctamente!", "Error al generar la tabla *Users*")
                                + runApp.querySQL("CREATE TABLE Clients (id int not null identity(1,1) primary key,name varchar(30),lastname varchar (30),email varchar(30),cuit varchar(30),dni varchar(30),adress varchar(30),location varchar (30),petname varchar(30),razonsoc varchar(30),phone varchar(30));", "La tabla *Clients* se creo correctamente!", "Error al generar la tabla *Clients*")
                                + runApp.querySQL("CREATE PROCEDURE LoginToHorse @username varchar(25), @pass varchar(25) AS SELECT username,pass FROM Users WHERE username = @username and pass=@pass and active=1 ", "El SP *LoginToHorse* se creo correctamente!", "Error al generar el SP *LoginToHorse*") 
                                + runApp.querySQL("Insert into Users (username,pass,active,isAdmin) values('admin','admin',1,1);", "Se inserto *admin* a la base de datos correctamente!", "Error al insertar admin en la base de datos") 
                                + runApp.querySQL("insert into users (username,pass,active,isAdmin) values ('horse','horse',1,1)", "Se inserto *horse* a la base de datos correctamente!", "Error al insertar horse en la base de datos")
                               CREATE PROCEDURE InsertClient
                                + runApp.querySQL("CREATE PROCEDURE [dbo].[IsAdmin] @username varchar(25), @pass varchar(25) AS BEGIN SELECT isAdmin FROM Users WHERE username = @username and pass=@pass END", "El SP *IsAdmin* se creo correctamente!", "Error al generar el SP *IsAdmin* en de datos") 
                                + runApp.querySQL("CREATE PROCEDURE [dbo].[ResetPassword]    @username varchar(25), @pass varchar(25)  AS BEGIN update Users set pass=@pass where username = @username END", "El SP *ResetPassword* se creo correctamente!", "Error al generar el SP *ResetPassword* en de datos"); 
                            if (partialSql== numberSQL)
                            {
                                Console.WriteLine("LA BASE DE DATOS SE CARGO CORRECTAMENTE!");
                                Console.WriteLine("Presione una tecla para salir.");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("LA BASE DE DATOS NO SE CARGO CORRECTAMENTE\n");
                                Console.WriteLine("Error. Contacte a su proveedor del servicio");
                                Console.WriteLine("Presione una tecla para salir.");
                                Console.ReadKey();
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine("Error. Contacte a su proveedor del servicio y brindele el siguiente error:\n\n");
                Console.WriteLine(ex);
                Console.ReadKey();
            }
        }
        public int createDatabase()
        {
            int validation=0;
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = firstConectionToSql;
                    using (var command = new SqlCommand("CREATE DATABASE HORSE", connection))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        command.Connection.Open();
                        int rowsUpdated = command.ExecuteNonQuery();
                        command.Connection.Close();
                        if (rowsUpdated != 0)
                        {
                            Console.WriteLine("La base de datos *Horse* se creo correctamente!");
                            validation = 1;
                        }
                        else
                        {
                            Console.WriteLine("Error al generar la base de datos *Horse*");
                        }
                    }
                }
          
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error. Contacte a su proveedor del servicio y brindele el siguiente error:\n\n\n");
                Console.WriteLine(ex);
                Console.WriteLine("\n\n\n Error. Contacte a su proveedor del servicio");
                Console.ReadKey();
            }
            return validation;
        }
        public int querySQL(string query,string messageOk, string messageFail)
        {
            int validation = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = connectionToSql;
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        command.Connection.Open();
                        int rowsUpdated = command.ExecuteNonQuery();
                        command.Connection.Close();
                        if (rowsUpdated != 0)
                        {
                            Console.WriteLine(messageOk);
                            validation = 1;
                        }
                        else
                        {
                            Console.WriteLine(messageFail);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error. Contacte a su proveedor del servicio y brindele el siguiente error:\n\n");
                Console.WriteLine(ex);
                Console.ReadKey();
            }
            return validation;
        }

    }
}
