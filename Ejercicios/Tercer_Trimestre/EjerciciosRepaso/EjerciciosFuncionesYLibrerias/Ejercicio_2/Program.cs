/*

Ejercicio 2: Función para saber si es par
Escribe una función llamada EsPar que reciba como parámetro un número entero
y devuelva true si es par o false si no lo es. Llama a esta función desde tu programa
principal e imprime el resultado.
Ejemplo:
Entrada a la función (EsPar(8)):
Salida esperada (en consola): "El número es par."

*/

namespace Ejercicio_2
{
    class Ejercicio2
    {
        public static void Main()
        {
            EsPar(8);
        }

        static void EsPar(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero no es par");
            }
        }
    }
}