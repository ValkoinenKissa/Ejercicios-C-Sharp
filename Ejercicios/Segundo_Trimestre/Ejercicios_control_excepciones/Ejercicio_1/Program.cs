/*
Ejercicio 1: Capturar una división por cero
Enunciado:
Escribe un programa que solicite dos números al usuario y realice la división del primero por el segundo.
Maneja la excepción de división por cero e informa al usuario del error.
*/

namespace Ejercicio_1;

class ExcepcionDivisionZero
{
    static void Main()
    {
        int num1, num2, resultado;
        try
        {
            Console.WriteLine("Usuario, introduce el primer numero que quieras dividir: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Usuario, ahora introduce el numero por el cual quieras dividir el num1 -->" + num1);
            num2 = Convert.ToInt32(Console.ReadLine());

            resultado = num1 / num2;

            Console.WriteLine("Resultado de la division: " + resultado);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("No puedes dividir algo entre 0");
        }
     
    }
}

