namespace EjemploEnum
{
    class Program
    {
        static void Main()
        {
            Pedido pedido1 = new Pedido
            {
                Id = 1001,
                Cliente = "Juan Pérez",
                Estado = EstadoPedido.Procesando
            };

            pedido1.MostrarEstado();

            // Cambiar el estado
            pedido1.Estado = EstadoPedido.Enviado;
            pedido1.MostrarEstado();

            // Comparar estados
            if (pedido1.Estado == EstadoPedido.Enviado)
            {
                Console.WriteLine("El pedido ya ha sido enviado.");
            }
        }
    }
}