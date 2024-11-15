/*
Escribe un programa que pida al usuario dos números y muestre cuál de ellos es
mayor, o si ambos son iguales.
*/

//Declaración de variables

int num1, num2;

Console.WriteLine("Usuario, introduce dos numero para saber cual de ellos es mayor, o si son iguales \n");

Console.WriteLine("Introduce el primer numero: ");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Introduce el segundo numero: ");
num2 = int.Parse(Console.ReadLine());

if (num1 < num2)
{
    Console.WriteLine("El numero mayor es "+ "(" + num2 + ")");
}
else if (num1 > num2)
{
    Console.WriteLine("El numero mayor es "+ "(" + num1 + ")");
}

else
{
    Console.WriteLine("Ambos son iguales: " + num1);

}