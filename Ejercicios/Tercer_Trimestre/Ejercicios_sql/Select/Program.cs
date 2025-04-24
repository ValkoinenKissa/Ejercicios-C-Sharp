namespace Select
{
    using MySql.Data.MySqlClient;
    using System;

    class Program
    {
        static void Main()
        {
            string connectionString = "Server=localhost;Database=Tienda;Uid=root;Pwd=;";

            Console.WriteLine("-- BUSCAR PRODUCTOS --");
            Console.Write("Introduce nombre o parte: ");
            string busqueda = Console.ReadLine() ?? "";

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();
                string sql = "SELECT * FROM productos WHERE Nombre LIKE @busqueda";
                MySqlCommand cmd = new MySqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@busqueda", "%" + busqueda + "%");
            
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    Console.WriteLine("\nResultados:");
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["Id"]}");
                        Console.WriteLine($"Nombre: {reader["Nombre"]}");
                        Console.WriteLine($"Categoría: {reader["Categoria"]}");
                        Console.WriteLine($"Precio: {reader["Precio"]}€");
                        Console.WriteLine($"Stock: {reader["Stock"]} unidades\n");
                    }
                }
            }
        }
    }

}

