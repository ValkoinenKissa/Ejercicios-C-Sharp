/*
Escribe un programa en C# que permita al usuario ingresar una lista de números
enteros separados por comas. El programa debe almacenar los números en una
lista, calcular la suma de todos los elementos y mostrar tanto la lista como la
suma total.
*/

namespace Ejercicio_2;

class ListaNumeros
{
    public static void Main(string[] args)
    {
        List<String> listaNumeros = new List<String>();

        Console.WriteLine("Introduce una serie de numeros separados por comas para cargar la lista");

        do
        {
            Console.Write("Ingrese los numeros: ");
            String numero = (Console.ReadLine() ?? "");
            IngresarNumeros(listaNumeros, numero);
            Console.WriteLine("Quieres continuar? (S o N)");
            string continuar = (Console.ReadLine() ?? "").ToUpper();

            if (continuar.Equals("N"))
            {
                Console.WriteLine("Mostrando todos los valores de la lista: ");
                MostarNumeros(listaNumeros);
                Console.WriteLine("Mostrando la suma total de valores: ");
                SumaNumeros(listaNumeros);
                break;
            }

            if (continuar.Equals("S"))
            {
                Console.WriteLine("Has decidido continuar");
            }
            else
            {
                Console.WriteLine("Opcion no valida");
            }
        } while (true);
    }


    static void IngresarNumeros(List<String> listaNumeros, String numero)
    {
        Console.WriteLine("Ingresa los numeros que desees separados por comas: ");
        listaNumeros.Add(numero);
    }

    static void SumaNumeros(List<String> listaNumeros)
    {
        int acumulado = 0;
        String numeroClean;
        
        foreach (String numeros in listaNumeros)
        {
            numeroClean = numeros.Replace(",", " ");
            acumulado += int.Parse(numeroClean);
        }

        Console.WriteLine($"La suma total de valores del array es: {acumulado}");
    }

    static void MostarNumeros(List<String> listaNumeros)
    {
        foreach (String numeros in listaNumeros)
        {
            Console.Write(numeros);
        }
        Console.WriteLine();
    }
}