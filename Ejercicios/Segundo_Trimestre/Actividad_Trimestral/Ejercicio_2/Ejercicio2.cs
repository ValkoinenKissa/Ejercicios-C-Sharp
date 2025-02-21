/*
Crea un programa que inicialice un array de 8 números enteros. Pide al usuario que
ingrese un número para buscar en el array y muestra si el número está presente o no,
indicando su posición si lo encuentra.

*/

namespace Ejercicio_2;

class Ejercicio2
{
    static void Main()
    {
        //Se inicializa un array con 8 numeros ya declarados
        int[] arrayNumeros = { 89, 23, 92, 76, 34, -65, 72, 71 };
        //Se muestra al usuario los numeros del array
        MostrarArray(arrayNumeros);
        //Se invoca el metodo solicitar numero para buscarlo
        int numeroBuscado = SolicitarNumero();
        //Se devuelve la posicion del numero si es encontrado, sino se devuelve -1
        int posicionNumero = BuscarNumero(arrayNumeros, numeroBuscado);
        while (posicionNumero == -1)
        {
            //Si el numero buscado no es correcto, se entra en un bucle que pide un numero hasta que este mismo sea localizado
            Console.WriteLine($"El numero introducido: {numeroBuscado} no se ha encontrado en el array" +
                              $" prueba de nuevo");
            numeroBuscado = SolicitarNumero();
            posicionNumero = BuscarNumero(arrayNumeros, numeroBuscado);
        }
        
        //Se muestra el numero buscado y la posicion donde se ha localizado

        MostarInformacion(numeroBuscado, posicionNumero);
    }

    static int SolicitarNumero()
    {
        //Se pide un numero positivo u negativo
        int numeroBuscado;
        Console.WriteLine("Introduce un numero entero");
        numeroBuscado = Convert.ToInt32(Console.ReadLine());
        return numeroBuscado;
    }

    static int BuscarNumero(int[] arrayNumeros, int numeroBuscado)
    {
        //Se recorre el array en busca del numero, si se localiza se devulve la posicion, sino un -1
        for (int i = 0; i < arrayNumeros.Length; i++)
        {
            if (arrayNumeros[i] == numeroBuscado)
            {
                return i;
            }
        }

        return -1;
    }

    static void MostarInformacion(int numeroBuscado, int posicionBuscada)
    {
        //Si el numero buscado esta en el array se muestra su posicion
        if (posicionBuscada != -1)
        {
            Console.WriteLine($"El numero introducido: {numeroBuscado} se ha encontrado en la posicion:" +
                              $" {posicionBuscada}");
        }
    }

    static void MostrarArray(int[] arrayNumeros)
    {
        //Metodo para mostar todos los elementos del array
        Console.WriteLine("Mostrando todos los numeros del array: ");
        for (int i = 0; i < arrayNumeros.Length; i++)
        {
            Console.Write(arrayNumeros[i] + " ");
        }

        Console.WriteLine();
    }
}