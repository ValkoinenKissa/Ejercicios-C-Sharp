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
        int[] arrayNumeros = { 89, 23, 92, 76, 34, 65, 72, 71 };
        MostrarArray(arrayNumeros);
        int numeroBuscado = SolicitarNumero();
        int posicionNumero = BuscarNumero(arrayNumeros, numeroBuscado);
        while (posicionNumero == -1)
        {
            Console.WriteLine($"El numero introducido: {numeroBuscado} no se ha encontrado en el array" +
                              $" prueba de nuevo");
            numeroBuscado = SolicitarNumero();
            posicionNumero = BuscarNumero(arrayNumeros, numeroBuscado);
        }

        MostarInformacion(numeroBuscado, posicionNumero);
    }

    static int SolicitarNumero()
    {
        int numeroBuscado;
        Console.WriteLine("Introduce un numero entero positivo");
        numeroBuscado = Convert.ToInt32(Console.ReadLine());
        return numeroBuscado;
    }

    static int BuscarNumero(int[] arrayNumeros, int numeroBuscado)
    {
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
        if (posicionBuscada != -1)
        {
            Console.WriteLine($"El numero introducido: {numeroBuscado} se ha encontrado en la posicion:" +
                              $" {posicionBuscada}");
        }
    }

    static void MostrarArray(int[] arrayNumeros)
    {
        Console.WriteLine("Mostrando todos los numeros del array: ");
        for (int i = 0; i < arrayNumeros.Length; i++)
        {
            Console.Write(arrayNumeros[i] + " ");
        }

        Console.WriteLine();
    }
}