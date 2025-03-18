// See https://aka.ms/new-console-template for more information
/*
 * Ejercicio 3: Calcular el área de un círculo
 * Enunciado:
 * Crea una función que reciba el radio de un círculo y devuelva su área.
 * Usa la fórmula Área = π * radio^2. Llama a la función y muestra el resultado.
 */

namespace Ejercicio_3;

class Ejercicio3
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Usuario, introduce el radio de la circunferencia para calcular su area: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        double resultado = CalcularAreaCirculo(radio); 
        
        Console.WriteLine($"El área de la circunferencia es: {resultado}");
    }


    static double CalcularAreaCirculo(double radio)
    {
        return Math.PI * Math.Pow(radio, 2);
    }
}