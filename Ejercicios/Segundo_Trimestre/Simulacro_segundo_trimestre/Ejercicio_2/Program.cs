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
        Console.WriteLine("Introduce una serie de numeros separados por comas para cargar la lista");
        do
        {
            Console.Write("Ingrese los numeros: ");
            String numero = (Console.ReadLine() ?? "");
            Console.WriteLine("Quieres continuar? (S o N)");
            string continuar = (Console.ReadLine() ?? "").ToUpper();

            if (continuar.Equals("N") && numero.Contains(','))
            {
                Console.WriteLine("Mostrando todos los valores de la lista: ");
                MostarNumeros(numero);
                Console.WriteLine("Mostrando la suma total de valores: ");
                SumaNumeros(numero);
                break;
            }
            else if (continuar.Equals("N") && !numero.Contains(','))
            {
                Console.WriteLine("Error: Debes de separar los numeros con una coma (,) Ejemplo: 5,6,7,8,9,10");
            }
            else if (continuar.Equals("S"))
            {
                Console.WriteLine("Has decidido continuar");
            }
            else
            {
                Console.WriteLine("Opcion no valida");
            }
        } while (true);
    }

    static void SumaNumeros(String listaNumeros)
    {
        int acumulado = 0;
        String[] numeroClean = listaNumeros.Split(',');

        foreach (var numero in numeroClean)
        {
            acumulado += Convert.ToInt32(numero);
        }

        Console.WriteLine($"La suma total de valores del array es: {acumulado}");
    }

    static void MostarNumeros(String listaNumeros)
    {
        Console.WriteLine(listaNumeros);
    }
}