/*
Ejercicio 2: Manejar errores de conversión de datos
Enunciado:
Escribe un programa que solicite un número entero al usuario y
maneje la excepción que se produce si el usuario introduce texto en lugar de un número.
*/

namespace Ejercicio_2;

class ExcepcionDeFormato
{
    static void Main()
    {
        try
        {
            int num1;
            Console.WriteLine("Usuario, introduce un numero para mostralo por pantalla: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mostrando el numero --> " + num1);
        }
        catch (FormatException)
        {
            Console.WriteLine("Solo se permite la introduccion de numeros");
        }
    }
}