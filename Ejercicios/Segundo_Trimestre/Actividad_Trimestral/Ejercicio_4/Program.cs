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
        //Declaracion de lista y llamada a metodos IngresarElementos y mostarArticulos
        List<string> listaArticulos = new List<string>();
        IngresarElementos(listaArticulos);
        MostarArticulos(listaArticulos);
    }
    
    static void IngresarElementos(List<string> lista)
    {
        //Declaracion de variables y se muestra mensaje al usuario del funcionamiento del programa
        string decision, articulo;
        int contador = 1;
        Console.WriteLine("Ingresa los articulos de tu lista de la compra, para continuar introduce 'Y'. Para parar " +
                          " introduce 'N' ");

        
        //Bucle do-while para ingresar elementos hasta que el usuario quiera
        do
        {
            Console.WriteLine($"Ingresa el articulos Nº {contador}");
            articulo = Console.ReadLine()?.ToUpper() ?? "NULL";
            //Control de elementos vacios 'null' dentro de la variable articulo
            if (articulo.Equals("NULL"))
            {
                Console.WriteLine("No has introducido ningún articulo");
                Console.WriteLine("¿Quieres continuar? (Y or N) ");
                decision = Console.ReadLine()?.ToUpper() ?? "N"; // Si es null, usa "N" como default
            }
            else
            {
                //Si el elemento introducido no es nulo, se añade a la lista mediante el metodo .add
                lista.Add(articulo);
                Console.WriteLine("Articulo registrado correctamente");
                //Se pregunta al usuario si quiere seguir añadiendo articulos siempre.
                Console.WriteLine("¿Quieres continuar? (Y or N) ");
                decision = Console.ReadLine()?.ToUpper() ?? "N"; // Si es null, usa "N" como default
                contador++;
            }
            
            //Se ejecuta el bucle siempre que la condicion de salida sea diferente de 'Y'

        } while (decision.Equals("Y"));
    }

    static void MostarArticulos(List<string> lista)
    {
        //Se recorre toda la lista para mostrar todos sus articulos
        Console.WriteLine("Mostrando los articulos de la compra...");
        foreach (string articulo in lista)
        {
            Console.WriteLine(articulo);
        }
    }
}

