// See https://aka.ms/new-console-template for more information

namespace EjemploVariableNullYClase
{
    public class EjemploVariableNullYClase
    {
        static void Main(string[] args)
        {
            // declaracion de variable con posibilidad de null
            string? nombre;
            string? apellidos = null;
            // ejecución del programa
            Console.WriteLine("Comenzando la ejecución del programa");
            Console.WriteLine("Para comenzar por favor introduce tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Perfecto {0} ya podemos comenzar", nombre, apellidos);
        }
    }
}