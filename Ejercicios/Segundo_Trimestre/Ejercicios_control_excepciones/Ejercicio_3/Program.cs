/*
Ejercicio 3: Excepción genérica para múltiples errores
Enunciado:
Crea un programa que solicite dos números al usuario y maneje excepciones de tipo
FormatException y DivideByZeroException en un solo bloque catch.
*/

namespace Ejercicio_3;

class MultiplesExcepciones
{
    static void Main()
    {
        int num1, num2, resultado;
        try
        {
            try
            {
                Console.WriteLine("Usuario, introduce el primer numero que quieras dividir: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Usuario, ahora introduce el numero por el cual quieras dividir el num1 -->" + num1);
                num2 = Convert.ToInt32(Console.ReadLine());
                resultado = num1 / num2;
                Console.WriteLine("Resultado de la division: " + resultado);
            }
            catch (FormatException)
            {
                Console.WriteLine("Solo se permite ingresar numeros enteros, prueba de nuevo");
            }
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("No puedes dividir algo entre 0");
        }
    }
}