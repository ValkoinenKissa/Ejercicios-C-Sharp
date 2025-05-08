/*
 Ejercicio 3: Buscar un elemento en la lista
Enunciado:
Escribe un programa que permita al usuario buscar un número en una lista y diga si está presente.
 */

namespace Ejercicio_3
{
    class Program
    {
        static void Main()
        {
            List<int> numeros = new List<int> { 5, 15, 25, 35, 45 };
            Console.WriteLine("Introduce un número para buscar:");
            int numeroBuscado = Convert.ToInt32(Console.ReadLine());

            if (numeros.Contains(numeroBuscado))
            {
                Console.WriteLine("El número está en la lista.");
            }
            else
            {
                Console.WriteLine("El número no está en la lista.");
            }
        }
    }
}