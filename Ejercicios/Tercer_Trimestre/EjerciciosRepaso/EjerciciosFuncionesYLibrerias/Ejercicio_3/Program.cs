/*
Ejercicio 3: Uso de Math.Pow()
Crea una función llamada ElevarAlCuadrado que reciba como parámetro un
número y devuelva su cuadrado usando la librería Math. Llama a esta función
desde tu programa principal e imprime el resultado.
*/

namespace Ejercicio_3
{
    class Ejercicio3
    {
        public static void Main()
        {
            ElevarAlCuadrado(3);
        }

        static void ElevarAlCuadrado(int num)
        {
            
            double numeroAlCudrado = Math.Pow(num, 2);
            Console.WriteLine($"El cuadrado de {num} es: {numeroAlCudrado}");
        }
    }
}