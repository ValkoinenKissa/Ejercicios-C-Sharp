namespace Delete
{
    using MySql.Data.MySqlClient;
    using System;

    class Program
    {
        static void Main()
        {
            string connectionString = "Server=localhost;Database=Tienda;Uid=root;Pwd=;";

            Console.WriteLine("-- ELIMINAR PRODUCTO --");
            Console.Write("ID del producto a eliminar: ");
            int id = int.Parse(Console.ReadLine() ?? "");

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();
                string sql = "DELETE FROM tienda.productos WHERE Id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@id", id);
            
                int filasAfectadas = cmd.ExecuteNonQuery();
                Console.WriteLine(filasAfectadas > 0 ? "¡Producto eliminado!" : "❌ Producto no encontrado");
            }
        }
    }

}