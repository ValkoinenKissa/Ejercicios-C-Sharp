namespace Ejercicio_numeros;

using System;
using System.IO;

class Program
{
    static void Main()
    {
        string rutaArchivo = "numeros.txt";

        try
        {
            // Verificar si el archivo existe
            if (!File.Exists(rutaArchivo))
            {
                Console.WriteLine("El archivo no existe.");
                return;
            }

            // Variables para realizar los cálculos
            int suma = 0;
            int maximo = int.MinValue;

            Console.WriteLine("Números en el archivo:");

            // Leer el archivo línea por línea
            foreach (string linea in File.ReadLines(rutaArchivo))
            {
                // Convertir la línea a entero
                int numero = int.Parse(linea);

                // Mostrar el número por consola
                Console.WriteLine(numero);

                // Actualizar la suma y el máximo
                suma += numero;
                if (numero > maximo)
                {
                    maximo = numero;
                }
            }

            // Mostrar los resultados
            Console.WriteLine($"\nSuma de los números: {suma}");
            Console.WriteLine($"Número más grande: {maximo}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("El archivo no se encuentra.");
        }
        catch (FormatException)
        {
            Console.WriteLine("El archivo contiene datos inválidos.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió un error: {ex.Message}");
        }
    }
}