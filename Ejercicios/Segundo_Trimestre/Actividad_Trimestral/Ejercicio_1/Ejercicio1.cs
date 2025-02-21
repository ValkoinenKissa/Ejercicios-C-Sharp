/*
Escribe un programa que cree un array de 5 números enteros, solicite al usuario que
ingrese los valores manualmente, y luego calcule y muestre la suma de todos los
elementos del array.
*/

namespace Ejercicio_1
{
    
    class Ejercicio1
    {
   
        //Metodo principal
        static void Main()
        {
            //Declaracion de array 5 posiciones y llamada a metodos Rellenar y procesamiento de resultado
            int [] arrayNumeros = new int [5];
            Rellenar(arrayNumeros);
            int resultado = SumaArray(arrayNumeros);
            Console.WriteLine($"La suma de todos los elementos del array es: {resultado}");

        }

        static int IntroducirNumeros()
        {
            //Se pide un numero entero positivo y se verifica que se introduzca un numero positivo con un bucle
            int numeroEntero;
            Console.WriteLine("Introduce un numero entero positivo");
            numeroEntero = Convert.ToInt32(Console.ReadLine());
            while (numeroEntero < 0)
            {
                Console.WriteLine("Error, introduce un numero entero positivo: ");
                numeroEntero = Convert.ToInt32(Console.ReadLine());
            }
            
            //Se retorna el numero verificado
    
            return numeroEntero;
        }

        static int SumaArray(int[] numeros)
        {
            //Acumulador para recopilar todos los numeros del array y realizar la suma
            int acumulador = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                acumulador += numeros[i];
            }
            
            //Se devuelve una cadena directamente con el resultado

            return acumulador;
        }

        static void Rellenar(int[] numeros)
        //Metodo para rellenar el array, se invoca en el metodo Main una vez que se comprueba el numero
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = IntroducirNumeros();
            }
        } 
    }
    
}