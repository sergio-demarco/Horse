using System;
using System.Data.SqlClient;

namespace ConsoleHorse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a Horse \n Espere mientras el servicio instala su base de datos \n\n Procesando archivos....");
            Program runApp = new Program();
            runApp.statusDataBase();
        }
        public void statusDataBase()
        {
            Program runApp = new Program();
            int numberSQL = 7;
            int partialSql = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = @"Data Source=SERGIO-NOTEBOOK\SQLEXPRESS;Initial Catalog=HORSE;Integrated Security=True;user id=SERGIO-NOTEBOOK\Admin";
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
                            partialSql = runApp.h1() + runApp.h2() + runApp.h3() + runApp.h4() + runApp.h5() + runApp.h6() + runApp.h7(); 
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
            }
        }
        public int h1()
        {
            int validation=0;
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = @"Data Source=SERGIO-NOTEBOOK\SQLEXPRESS;Initial Catalog=HORSE;Integrated Security=True;user id=SERGIO-NOTEBOOK\Admin";
                    using (var command = new SqlCommand("CREATE DATABASE HORSE", connection))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        command.Connection.Open();
                        int rowsUpdated = command.ExecuteNonQuery();
                        command.Connection.Close();
                        if (rowsUpdated > 0)
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
                Console.WriteLine("Error. Contacte a su proveedor del servicio y brindele el siguiente error:\n\n");
                Console.WriteLine(ex);
            }
            return validation;
        }
        public int h2()
        {
            int validation = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = @"Data Source=SERGIO-NOTEBOOK\SQLEXPRESS;Initial Catalog=HORSE;Integrated Security=True;user id=SERGIO-NOTEBOOK\Admin";
                    using (var command = new SqlCommand("USE [HORSE] CREATE TABLE Users (id int not null identity(1,1) primary key,username varchar(25),pass varchar (25),name varchar (30),lastname varchar(30),adress varchar (30),city varchar(30),country varchar (30),phone varchar(30),active bit,isAdmin bit);", connection))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        command.Connection.Open();
                        int rowsUpdated = command.ExecuteNonQuery();
                        command.Connection.Close();
                        if (rowsUpdated > 0)
                        {
                            Console.WriteLine("La tabla *Users* se creo correctamente!");
                            validation = 1;
                        }
                        else
                        {
                            Console.WriteLine("Error al generar la tabla *Users*");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error. Contacte a su proveedor del servicio y brindele el siguiente error:\n\n");
                Console.WriteLine(ex);
            }
            return validation;
        }
        public int h3()
        {
            int validation = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = @"Data Source=SERGIO-NOTEBOOK\SQLEXPRESS;Initial Catalog=HORSE;Integrated Security=True;user id=SERGIO-NOTEBOOK\Admin";
                    using (var command = new SqlCommand("USE [HORSE] GO  CREATE PROCEDURE LoginToHorse @username varchar(25), @pass varchar(25) AS SELECT username,pass FROM Users WHERE username = @username and pass=@pass and active=1 GO ", connection))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        command.Connection.Open();
                        int rowsUpdated = command.ExecuteNonQuery();
                        command.Connection.Close();
                        if (rowsUpdated > 0)
                        {
                            Console.WriteLine("El SP *LoginToHorse* se creo correctamente!");
                            validation = 1;
                        }
                        else
                        {
                            Console.WriteLine("Error al generar el SP *LoginToHorse*");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error. Contacte a su proveedor del servicio y brindele el siguiente error:\n\n");
                Console.WriteLine(ex);
            }
            return validation;
        }
        public int h4()
        {
            int validation = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = @"Data Source=SERGIO-NOTEBOOK\SQLEXPRESS;Initial Catalog=HORSE;Integrated Security=True;user id=SERGIO-NOTEBOOK\Admin";
                    using (var command = new SqlCommand("Insert into Users (username,pass,active,isAdmin) values('admin','admin',1,1);", connection))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        command.Connection.Open();
                        int rowsUpdated = command.ExecuteNonQuery();
                        command.Connection.Close();
                        if (rowsUpdated > 0)
                        {
                            Console.WriteLine("Se inserto *admin* a la base de datos correctamente!");
                            validation = 1;
                        }
                        else
                        {
                            Console.WriteLine("Error al insertar admin en la base de datos");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error. Contacte a su proveedor del servicio y brindele el siguiente error:\n\n");
                Console.WriteLine(ex);
            }
            return validation;
        }
        public int h5()
        {
            int validation = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = @"Data Source=SERGIO-NOTEBOOK\SQLEXPRESS;Initial Catalog=HORSE;Integrated Security=True;user id=SERGIO-NOTEBOOK\Admin";
                    using (var command = new SqlCommand("insert into users (username,pass,active,isAdmin) values ('horse','horse',1,1)", connection))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        command.Connection.Open();
                        int rowsUpdated = command.ExecuteNonQuery();
                        command.Connection.Close();
                        if (rowsUpdated > 0)
                        {
                            Console.WriteLine("Se inserto *horse* a la base de datos correctamente!");
                            validation = 1;
                        }
                        else
                        {
                            Console.WriteLine("Error al insertar horse en la base de datos");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error. Contacte a su proveedor del servicio y brindele el siguiente error:\n\n");
                Console.WriteLine(ex);
            }
            return validation;
        }
        public int h6()
        {
            int validation = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = @"Data Source=SERGIO-NOTEBOOK\SQLEXPRESS;Initial Catalog=HORSE;Integrated Security=True;user id=SERGIO-NOTEBOOK\Admin";
                    using (var command = new SqlCommand("USE [HORSE] CREATE PROCEDURE [dbo].[IsAdmin] @username varchar(25), @pass varchar(25) AS BEGIN SELECT isAdmin FROM Users WHERE username = @username and pass=@pass END", connection))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        command.Connection.Open();
                        int rowsUpdated = command.ExecuteNonQuery();
                        command.Connection.Close();
                        if (rowsUpdated > 0)
                        {
                            Console.WriteLine("El SP *IsAdmin* se creo correctamente!");
                            validation = 1;
                        }
                        else
                        {
                            Console.WriteLine("Error al generar el SP *IsAdmin* en de datos");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error. Contacte a su proveedor del servicio y brindele el siguiente error:\n\n");
                Console.WriteLine(ex);
            }
            return validation;
        }
        public int h7()
        {
            int validation = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = @"Data Source=SERGIO-NOTEBOOK\SQLEXPRESS;Initial Catalog=HORSE;Integrated Security=True;user id=SERGIO-NOTEBOOK\Admin";
                    using (var command = new SqlCommand("USE [HORSE] GO CREATE PROCEDURE [dbo].[ResetPassword]    @username varchar(25), @pass varchar(25)  AS BEGIN update Users set pass=@pass where username = @username END", connection))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        command.Connection.Open();
                        int rowsUpdated = command.ExecuteNonQuery();
                        command.Connection.Close();
                        if (rowsUpdated > 0)
                        {
                            Console.WriteLine("El SP *ResetPassword* se creo correctamente!");
                            validation = 1;
                        }
                        else
                        {
                            Console.WriteLine("Error al generar el SP *ResetPassword* en de datos");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error. Contacte a su proveedor del servicio y brindele el siguiente error:\n\n");
                Console.WriteLine(ex);
            }
            return validation;
        }

    }
}
