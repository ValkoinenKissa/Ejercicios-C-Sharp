/*
Ejercicio 2: Eliminar un elemento de la lista
Enunciado:
Crea un programa que permita al usuario eliminar un elemento de una lista de números si este existe.
*/

namespace Ejercicio_2
{
    class Program
    {
        static void Main()
        {
            List<int> numeros = new List<int> { 10, 20, 30, 40, 50 };
            Console.WriteLine("Introduce el número a eliminar:");
            int numeroAEliminar = Convert.ToInt32(Console.ReadLine());

            if (numeros.Remove(numeroAEliminar))
            {
                Console.WriteLine("Número eliminado.");
            }
            else
            {
                Console.WriteLine("El número no está en la lista.");
            }

            Console.WriteLine("Lista actual:");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}