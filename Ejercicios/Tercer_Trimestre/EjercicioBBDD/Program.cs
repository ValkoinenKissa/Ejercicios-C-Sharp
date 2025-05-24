/*
Ejercicio 3: Sistema de Registro de Libros(3.5 puntos)
Crea un programa en C# que implemente un sistema simple de registro de libros utilizando una
base de datos MySQL. El programa debe permitir al usuario agregar nuevos libros a la base de
datos y listar todos los libros registrados.
Primero, necesitarás crear la base de datos y la tabla. Utiliza los siguientes comandos SQL:

CREATE DATABASE biblioteca;
USE biblioteca;
CREATE TABLE libros (
id INT AUTO_INCREMENT PRIMARY KEY,
titulo VARCHAR(100) NOT NULL,
autor VARCHAR(100) NOT NULL,
anio_publicacion INT,
isbn VARCHAR(13)
);

El programa en C# debe:

Presentar un menú al usuario con las siguientes opciones:
a. Agregar un nuevo libro
b. Listar todos los libros
c. Salir del programa

Para la opción "Agregar un nuevo libro":
• Solicitar al usuario que ingrese el título, autor, año de publicación e ISBN del
libro.
• Insertar estos datos en la tabla 'libros' de la base de datos.
• Mostrar un mensaje de confirmación.
Para la opción "Listar todos los libros":
• Realizar una consulta SELECT a la base de datos para obtener todos los libros.
• Mostrar la información de cada libro en un formato legible.
*/

using MySql.Data.MySqlClient;

namespace EjercicioBBDD
{

    class Program
    {

        static string connectionString = "Server=localhost;Database=biblioteca;Uid=root;Pwd=;";
        public static void Main()
        {

            Console.WriteLine("Bienvenido a la aplicacion usuario");

            bool salir = false;

            do
            {
                Console.WriteLine("¿Que quieres hacer??");
                Console.WriteLine("1. Agregar un nuevo libro");
                Console.WriteLine("2. Listar todos los libros");
                Console.WriteLine("3. Salir del programa");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        agregarLibro();
                        break;

                    case 2:
                        listarLibros();
                        break;
                    case 3:
                        salir = true;
                        Console.WriteLine("Hasta pronto!!");
                        break;

                    default:
                        Console.WriteLine("La opcion que acabas de introducir es incorrecta");
                        break;
                }

            } while (!salir);

        }

        static void agregarLibro()
        {
            /*
            Para la opción "Agregar un nuevo libro":
            • Solicitar al usuario que ingrese el título, autor, año de publicación e ISBN del
            libro.
            • Insertar estos datos en la tabla 'libros' de la base de datos.
            • Mostrar un mensaje de confirmación.
            */
            Console.WriteLine("-- REGISTRAR NUEVO LIBRO --");
            Console.Write("Titulo: ");
            string titulo = Console.ReadLine() ?? ""; //Verificación con null-coalescing operator (??)
            Console.Write("Autor: ");
            string autor = Console.ReadLine() ?? "";
            Console.Write("Año publicacion: ");
            int anioPub = int.Parse(Console.ReadLine() ?? "");
            Console.Write("ISBN: ");
            string isbn = Console.ReadLine() ?? "";

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();
                //Cuando se parametricen los parametros utilizar @ es mejor que ? ya que esta ultima da fallos
                string sql = "INSERT INTO biblioteca.libros (titulo, autor, anio_publicacion, isbn) VALUES (@titulo, @autor, @anioPub, @isbn)";
                MySqlCommand cmd = new MySqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@titulo", titulo);
                cmd.Parameters.AddWithValue("@autor", autor);
                cmd.Parameters.AddWithValue("@anioPub", anioPub);
                cmd.Parameters.AddWithValue("@isbn", isbn);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Libro registrado!");
            }
        }

        static void listarLibros()
        {

            /*
             Realizar una consulta SELECT a la base de datos para obtener todos los libros.
             Mostrar la información de cada libro en un formato legible.
            */

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();
                string sql = "SELECT * FROM biblioteca.libros";
                MySqlCommand cmd = new MySqlCommand(sql, conexion);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    Console.WriteLine("\nResultados:");
                    while (reader.Read())
                    {
                        Console.WriteLine($"Titulo: {reader["titulo"]}");
                        Console.WriteLine($"Autor: {reader["autor"]}");
                        Console.WriteLine($"Año publicacion: {reader["anio_publicacion"]}");
                        Console.WriteLine($"ISBN: {reader["isbn"]}");
                    }
                }
            }
        }

    }

}