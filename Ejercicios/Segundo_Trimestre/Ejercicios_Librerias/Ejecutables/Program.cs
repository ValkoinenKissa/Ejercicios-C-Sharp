using MathUtils;
namespace Ejecutables;
public class Mains
{
    public static void Main(string[] args)
    {
        double resultado = LibreriaMatematica.CuadradoDeUnNumero(5);
        Console.WriteLine($"Resultado: {resultado}");
    }
}