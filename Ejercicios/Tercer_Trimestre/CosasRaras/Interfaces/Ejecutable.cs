namespace Interfaces;

public class Ejecutable
{
    static void Main()
    {
        IFigura figura = new Circulo(5.0);

        Console.WriteLine("Área: " + figura.CalcularArea());
        Console.WriteLine("Perímetro: " + figura.CalcularPerimetro());
    }
}