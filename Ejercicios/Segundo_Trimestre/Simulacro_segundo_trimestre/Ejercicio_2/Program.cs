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
        List<int> listaNumerosClean = new List<int>();

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
                MostarNumeros(listaNumerosClean);
                Console.WriteLine("Mostrando la suma total de valores: ");
                SumaNumeros(listaNumeros, listaNumerosClean);
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

    static void SumaNumeros(List<String> listaNumeros, List<int> listaNumerosClean)
    {
        int acumulado = 0;
        
        foreach (String numeros in listaNumeros)
        {
            acumulado = int.Parse(numeros.Replace(",", ""));
            listaNumerosClean.Add(acumulado);
            acumulado += acumulado;
        }

        Console.WriteLine($"La suma total de valores del array es: {acumulado}");
    }

    static void MostarNumeros(List<int> listaNumerosClean)
    {
        foreach (int numeros in listaNumerosClean)
        {
            Console.Write(numeros);
        }

        Console.WriteLine();
    }
}