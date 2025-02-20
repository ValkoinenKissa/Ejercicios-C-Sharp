/*
Escribe un programa que cree un array de 5 números enteros, solicite al usuario que
ingrese los valores manualmente, y luego calcule y muestre la suma de todos los
elementos del array.
*/

namespace Ejercicio_1
{
    
    class Ejercicio1
    {
   
        static void Main()
        {
            int [] arrayNumeros = new int [5];
            Rellenar(arrayNumeros);
            Console.WriteLine(SumaArray(arrayNumeros));

        }

        static int IntroducirNumeros()
        {
            int numeroEntero;
            Console.WriteLine("Introduce un numero entero positivo");
            numeroEntero = Convert.ToInt32(Console.ReadLine());
            while (numeroEntero < 0)
            {
                Console.WriteLine("Error, introduce un numero entero positivo: ");
                numeroEntero = Convert.ToInt32(Console.ReadLine());
            }
    
            return numeroEntero;
        }

        static string SumaArray(int[] numeros)
        {
            int acumulador = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                acumulador += numeros[i];
            }

            return "La suma de todos los numeros del array es: " + acumulador;
        }

        static void Rellenar(int[] numeros)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = IntroducirNumeros();
            }
        } 
    }
    
}