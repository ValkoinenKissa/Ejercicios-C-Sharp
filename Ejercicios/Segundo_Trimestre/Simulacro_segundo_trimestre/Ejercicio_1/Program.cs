/*
Escribe un programa en C# que solicite al usuario un número entero positivo. El programa debe verificar si el número
es primo o no. Un número primo es aquel que solo es divisible por 1 y por sí mismo.
Si el número no es válido (negativo o cero), el programa debe mostrar un mensaje de error.
*/

namespace Ejercicio_1;

class NumerosPrimos
{
    public static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Usuario, introduce un numero para verificar si es primo o no lo es: ");
                int numeroIntroducido = Convert.ToInt32(Console.ReadLine());
                if (ValidarNumero(numeroIntroducido))
                {
                    ComprobarNumeroPrimo(numeroIntroducido);
                    break;
                }
                else
                {
                    Console.WriteLine("No puedes comprobar numeros que sean 0 o numeros menores que 0");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine(
                    "Solo se permite ingresar numeros, por favor no introduzcas nada que no sea un numero");
            }
        }
    }

    static void ComprobarNumeroPrimo(int numero)
    {
        if (numero % 2 == 0)
        {
            Console.WriteLine("El numero que has introducido es primo");
        }
        else
        {
            Console.WriteLine("El numero que has introducido no es primo");
        }
    }

    static Boolean ValidarNumero(int numero)
    {
        if (numero <= 0)
        {
            return false;
        }

        return true;
    }
}