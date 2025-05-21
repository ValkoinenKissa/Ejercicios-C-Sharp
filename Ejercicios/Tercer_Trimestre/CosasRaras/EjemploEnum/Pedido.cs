using EjemploEnum;

public class Pedido
{
    public int Id { get; set; }
    public string Cliente { get; set; }
    public EstadoPedido Estado { get; set; }

    public void MostrarEstado()
    {
        Console.WriteLine($"Pedido {Id} para {Cliente} está en estado: {Estado}");
    }
}