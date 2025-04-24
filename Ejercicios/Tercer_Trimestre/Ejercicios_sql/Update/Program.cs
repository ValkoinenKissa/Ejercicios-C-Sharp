namespace Update
{
    using MySql.Data.MySqlClient;
    using System;

    class Program
    {
        static void Main()
        {
            string connectionString = "Server=localhost;Database=Tienda;Uid=root;Pwd=;";

            Console.WriteLine("-- ACTUALIZAR PRODUCTO --");
            Console.Write("ID del producto a actualizar: ");
            int id = int.Parse(Console.ReadLine() ?? "");
            Console.Write("Nuevo precio: ");
            float precioProducto = float.Parse(Console.ReadLine() ?? "");
            Console.Write("Nuevo stock: ");
            int stockProc = int.Parse(Console.ReadLine() ?? "");

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();
                string sql = "UPDATE tienda.productos SET precio = @precioProducto, stock = @stockProc WHERE Id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@precioProducto", precioProducto);
                cmd.Parameters.AddWithValue("@stockProc", stockProc);
                cmd.Parameters.AddWithValue("@id", id);
            
                int filasAfectadas = cmd.ExecuteNonQuery();
                Console.WriteLine(filasAfectadas > 0 ? "¡Producto actualizado!" : "❌ Producto no encontrado");
            }
        }
    }

}