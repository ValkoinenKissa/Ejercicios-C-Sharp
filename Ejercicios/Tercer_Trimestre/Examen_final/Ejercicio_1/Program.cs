/*
Crea un programa en C# que calcule el factorial de un número entero positivo ingresado por el usuario. 
El factorial de un número n (representado como n!) es el producto de todos los enteros positivos desde 1 hasta n. Por ejemplo, 5! = 5 x 4 x 3 x 2 x 1 = 120.

El programa debe:

•	Solicitar al usuario que ingrese un número entero positivo.

•	Validar que el número ingresado sea positivo. Si no lo es, mostrar un mensaje de error y volver a solicitar el número.

•	Calcular el factorial del número utilizando un bucle (puedes elegir entre for o while).

•	Mostrar el resultado del cálculo.

•	Preguntar al usuario si desea calcular otro factorial o salir del programa.

Utiliza estructuras de control condicionales (if-else) para la validación y un bucle para el cálculo del factorial y la repetición del programa.

*/

namespace Ejercicio_1
{
    class Factorial
    {
        public static void Main()
        {

            bool salir = false;
            int num;

            do
            {

                Console.WriteLine("Hola usuario, introduce un numero entero positivo para calcular su factorial");
                Console.WriteLine("Introduce un numero: ");
                num = Convert.ToInt32(Console.ReadLine());
                do
                {
                    if (num < 0)
                    {
                        Console.WriteLine("ERROR: Debes de introducir un numero positivo, por favor vuelve a intentarlo");
                        Console.WriteLine("Introduce un numero: ");
                        num = Convert.ToInt32(Console.ReadLine());

                    }
                    else
                    {
                        Console.WriteLine($"El numero: {num} Se ha registrado correctamente");
                    }


                } while (num < 0);

                int resultado = calcularFactorial(num);
                Console.WriteLine($"El factorial del numero {num} es {resultado}");
                Console.WriteLine();
                Console.WriteLine("¿Quieres calcular otro factorial? (S o N)");
                string decision = Convert.ToString(Console.ReadLine() ?? "").ToUpper();
                if (decision.Equals("S"))
                {
                    Console.WriteLine("Has decidido continuar");


                }
                else if (decision.Equals("N"))
                {
                    Console.WriteLine("Has decidido abandonar la aplicación, ¡Hasta pronto!");
                    salir = true;
                }
                else
                {
                    Console.WriteLine("Opcion incorrecta");
                    break;
                }

            } while (!salir);

        }

        //Metodo calcular factorial con recursividad
        static int calcularFactorial(int num)
        {
            if (num <= 1)
            {
                return 1;
            }

            return num * calcularFactorial(num - 1);
        }
    }
}