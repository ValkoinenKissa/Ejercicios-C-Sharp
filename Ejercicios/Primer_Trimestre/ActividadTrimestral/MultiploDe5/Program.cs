/*
Escribe un programa que pida al usuario un número entero y muestre si es múltiplo de
5 o no lo es. Usar if... else
*/

Console.WriteLine("Bienvenido al programa para indicar si un numero introducido por teclado es multiplo de 5" +
                  " a continuación elige un numero entero e introducelo por teclado para comprobarlo \n");

int num1;

Console.WriteLine("Introduce el numero: "); 
num1 = int.Parse(Console.ReadLine());

if (num1 % 5 == 0)
{
    Console.WriteLine("El numero es multiplo de 5");
}
else
{
    Console.WriteLine("El numero no es multiplo de 5");
}                