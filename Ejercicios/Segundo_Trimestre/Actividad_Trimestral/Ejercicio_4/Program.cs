/*
Crea un programa de lista de compras que permita:
• Agregar elementos a la lista
• Mostrar todos los elementos de la lista
*/

namespace Ejercicio_4;

class Ejercicio4
{
    static void Main()
    {
        List<string> listaArticulos = new List<string>();
        IngresarElementos(listaArticulos);
        MostarArticulos(listaArticulos);
    }
    
    static void IngresarElementos(List<string> lista)
    {
        string decision, articulo;
        int contador = 1;
        Console.WriteLine("Ingresa los articulos de tu lista de la compra, para continuar introduce 'Y'. Para parar " +
                          " introduce 'N' ");

        do
        {
            Console.WriteLine($"Ingresa el articulos Nº {contador}");
            articulo = Console.ReadLine()?.ToUpper() ?? "NULL";
            if (articulo.Equals("NULL"))
            {
                Console.WriteLine("No has introducido ningún articulo");
                Console.WriteLine("¿Quieres continuar? (Y or N) ");
                decision = Console.ReadLine()?.ToUpper() ?? "N"; // Si es null, usa "N" como default
            }
            else
            {
                lista.Add(articulo);
                Console.WriteLine("Articulo registrado correctamente");
                Console.WriteLine("¿Quieres continuar? (Y or N) ");
                decision = Console.ReadLine()?.ToUpper() ?? "N"; // Si es null, usa "N" como default
                contador++;
            }

        } while (decision.Equals("Y"));
    }

    static void MostarArticulos(List<string> lista)
    {
        Console.WriteLine("Mostrando los articulos de la compra...");
        foreach (string articulo in lista)
        {
            Console.WriteLine(articulo);
        }
    }
}

