/*
Ejercicio 4: Ordenar la lista
Enunciado:
Crea un programa que ordene una lista de números en orden ascendente y los muestre por consola.
*/

namespace Ejercicio_4
{
    class Program
    {
        static void Main()
        {
            List<int> numeros = new List<int> { 42, 17, 33, 8, 50 };
            numeros.Sort();

            Console.WriteLine("Lista ordenada:");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}