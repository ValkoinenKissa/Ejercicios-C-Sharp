using MathUtils;
using StringUtils;
namespace Ejecutables;
public class Mains
{
    public static void Main(string[] args)
    {
        double resultado = LibreriaMatematica.CuadradoDeUnNumero(5);
        Console.WriteLine($"Resultado: {resultado}");

        int contadorLetras = UtilidadesCadenas.ContarLetrasString("HOLA");
        Console.WriteLine($"La palabra HOLA tiene: {contadorLetras} letras");
    }
}