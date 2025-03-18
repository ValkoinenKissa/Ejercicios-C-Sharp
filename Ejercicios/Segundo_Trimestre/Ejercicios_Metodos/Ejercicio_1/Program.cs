// See https://aka.ms/new-console-template for more information
/*
Ejercicio 1: Sumar dos números
Enunciado:
Escribe una función que reciba dos números enteros como parámetros y devuelva su suma. Llama a la función desde el método Main y muestra el resultado.
 */

namespace Ejercicio_1;

class Ejercicio1
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Introduce el primer numero que quieres sumar");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduce el segundo numero que quieres sumar");
        int num2 = Convert.ToInt32(Console.ReadLine());


        int resultado = SumaNumeros(num1, num2);

        Console.WriteLine("El resultado de los operadores introducidos es: " + resultado);
    }

    static int SumaNumeros(int numero1, int numero2)
    {
        return numero1 + numero2;
    }
}