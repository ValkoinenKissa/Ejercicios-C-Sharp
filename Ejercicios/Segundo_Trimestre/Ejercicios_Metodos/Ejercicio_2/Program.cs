// See https://aka.ms/new-console-template for more information
/*
 * Ejercicio 2: Verificar si un número es par
 * Enunciado:
 * Crea una función que reciba un número entero y devuelva true si el número es par,
 * y false en caso contrario. Muestra el resultado llamando a la función desde Main.
 */

namespace Ejercicio_2;

class Ejercicio2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Introduce un numero para comprobar si es par o es impar: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        
        ComprobarParOImpar(numero);
    }

    static void ComprobarParOImpar(int numero)
    {
        if (numero % 2 == 0)
        {
            Console.WriteLine($"El numero introducido: {numero} es par");
        }
        else
        {
            Console.WriteLine($"El numero introducido: {numero} NO es par");
        }
    }
}