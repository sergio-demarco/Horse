using System;
using System.Data.SqlClient;

namespace ConsoleHorse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a Horse \n Espere mientras el servicio instala su base de datos \n\n Procesando archivos....");

            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = @"Data Source=SERGIO-NOTEBOOK\SQLEXPRESS;Initial Catalog=HORSE;Integrated Security=True;user id=SERGIO-NOTEBOOK\Admin";
                    // using the code here...
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
                            Console.WriteLine("Press any key to exit.");
                            Console.ReadKey();
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
    }
}
