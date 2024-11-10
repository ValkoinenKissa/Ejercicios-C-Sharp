// See https://aka.ms/new-console-template for more information

/*
 *Realiza un programa que permita realizar las siguientes acciones:
 *Pedir al usuario 2 números y guardarlos en variables
 *Crear 5 métodos para la realización de todas las operaciones
 *aritméticas explicadas. Éstos tendrán dos parámetros de entrada (los
 *operadores a utilizar) y como retorno el resultado de la operación.
 *Llama desde el método main a todos los métodos creados pasando
 *como parámetros los datos pedidos al usuario y muestra su resultado.
 *Comenta cada uno de los métodos dentro del código, indicando su
 *funcionalidad y sus parámetros.
 */


namespace EjercicioFunciones
{
    class EjercicioFunciones
    {
        static public void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Usuario, ingresa dos numeros para realizar todas las operaciones" +
                              " aritmeticas disponibles \n.");

            Console.WriteLine("Introduce el primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());


            Console.WriteLine("El resultado de la suma es: " + Suma(num1, num2));
            Console.WriteLine("El resultado de la multiplicacion es: " + Multiplicacion(num1, num2));
            Console.WriteLine("El resultado de la division es: " + Division(num1, num2));
            Console.WriteLine("El resultado de la resta es: " + Resta(num1, num2));
            Console.WriteLine("El resultado del modulo es: " + Modulo(num1, num2));
        }

        static public int Suma(int num1, int num2)
        {
            return num1 + num2;
        }

        static public int Multiplicacion(int num1, int num2)
        {
            return num1 * num2;
        }

        static public int Division(int num1, int num2)
        {
            return num1 / num2;
        }

        static public int Resta(int num1, int num2)
        {
            return num1 - num2;
        }

        static public int Modulo(int num1, int num2)
        {
            return num1 % num2;
        }
    }
}