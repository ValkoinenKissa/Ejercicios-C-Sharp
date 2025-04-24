using MySql.Data.MySqlClient;

namespace Insert
{
    class Program
    {
        static void Main()
        {
            string connectionString = "Server=localhost;Database=Tienda;Uid=root;Pwd=;";

            Console.WriteLine("-- REGISTRAR NUEVO PRODUCTO --");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine() ?? ""; //Verificación con null-coalescing operator (??)
            Console.Write("Categoría: ");
            string categoria = Console.ReadLine() ?? "";
            Console.Write("Precio: ");
            float precio = float.Parse(Console.ReadLine() ?? "");
            Console.Write("Stock: ");
            int stock = int.Parse(Console.ReadLine() ?? "");

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();
                //Cuando se parametricen los parametros utilizar @ es mejor que ? ya que esta ultima da fallos
                string sql = "INSERT INTO tienda.productos (nombre, categoria, precio, Stock) VALUES (@nombre, @categoria, @precio, @stock)";
                MySqlCommand cmd = new MySqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@categoria", categoria);
                cmd.Parameters.AddWithValue("@precio", precio);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.ExecuteNonQuery();
                Console.WriteLine("¡Producto registrado!");
            }
        }
    }
}