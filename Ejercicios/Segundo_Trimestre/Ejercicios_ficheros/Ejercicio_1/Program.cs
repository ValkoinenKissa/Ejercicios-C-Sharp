/*
Ejercicio 1: Añadir elementos a una lista
Enunciado:
Crea un programa en C# que permita al usuario añadir 5 nombres a una lista y luego los muestre por consola.
*/

namespace Ejercicio_1
{
    class Program
    {
        static void Main()
        {
            List<string> nombres = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Introduce el nombre {i + 1}:");
                string nombre = Console.ReadLine() ?? ""; //Operador de sustitucion para evitar nulos
                nombres.Add(nombre);
            }

            Console.WriteLine("Los nombres introducidos son:");
            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }
        }
    }
}
