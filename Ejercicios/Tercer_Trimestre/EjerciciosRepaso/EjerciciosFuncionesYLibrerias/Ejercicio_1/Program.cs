/*

Ejercicio 1: Función para sumar dos números
Crea una función llamada Sumar que reciba dos números como parámetros y
devuelva su suma. Llama a esta función desde tu programa principal e imprime el
resultado.
Ejemplo:
Entrada a la función (Sumar(4,7)):
Salida esperada (en consola): "La suma es: 11"

*/

namespace Ejercicio_1
{
    class Ejercicio1
    {
        public static void Main()
        {
            int resultado = Sumar(4, 7);
            Console.WriteLine($"La suma es {resultado}");
        }

        static int Sumar(int a, int b)
        {
            return a + b;
        }
    }
}

