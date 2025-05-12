/*
 * Crea una aplicación en C# que se conecte a una base de datos MySQL
 * llamada ejemploDB y consulte la tabla Personas, que contiene los campos Id, Nombre y Edad.
 * El programa debe realizar una consulta SELECT para obtener todos los registros de la tabla y
 * mostrar los resultados en la consola.
La tabla Personas debe contener al menos tres registros de ejemplo. Asegúrate de manejar posibles errores 
de conexión o ejecución de la consulta y muestra un mensaje adecuado en caso de que ocurra un problema.
Código de ayuda
 */
namespace Ejercicio_3
{
    
    using MySql.Data.MySqlClient;
    using System;
    
    class Ejercicio3
    {
        static void Main()
        {
            string connectionString = "Server=localhost;Database=Tienda;Uid=root;Pwd=;";

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();
                string sql = "SELECT * FROM ejemplodb.personas";
                MySqlCommand cmd = new MySqlCommand(sql, conexion);
            
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    Console.WriteLine("\nResultados:");
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["Id"]}");
                        Console.WriteLine($"Nombre: {reader["Nombre"]}");
                        Console.WriteLine($"Precio: {reader["Edad"]}");
                    }
                }
            }
        }
    }
}

