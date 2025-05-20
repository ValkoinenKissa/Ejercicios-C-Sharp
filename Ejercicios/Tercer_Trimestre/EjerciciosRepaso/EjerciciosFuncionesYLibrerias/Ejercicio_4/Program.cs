/*
Ejercicio 4: Función para calcular factorial
Haz una función llamada Factorial que reciba como parámetro un número entero
positivo y devuelva su factorial usando un bucle
(n! = n * (n-1) * ... *1). Llama a esta
función desde tu programa principal e imprime el resultado.
Ejemplo:
Entrada a la función (Factorial(5)):
Salida esperada (en consola): "El factorial de 5 es: 120"
*/

namespace Ejercicio_4
{
    class Ejercicio4
    {
        public static void Main()
        {
            int num = 5;
            int resultado = Factorial(num);
            Console.WriteLine($"El resultado del factorial de {num} es {resultado}");
        }

        static int Factorial(int num)
        {
            if (num <= 1)
            {
                return 1;
            }

            return num * Factorial(num - 1);
        }
    }
}