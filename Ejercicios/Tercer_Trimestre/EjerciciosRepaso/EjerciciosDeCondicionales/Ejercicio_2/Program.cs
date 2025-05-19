/*
Crea un programa que solicite dos números al usuario y
muestre cuál de los dos
es mayor o si son iguales.
Ejemplo:
Entrada: 3, 7
Salida: "El mayor es 7."
*/

int num1, num2;

Console.WriteLine("Introduce el numero 1: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Introduce el numero 2: ");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"El mayor es el: {num1}");
}
else if (num1 == num2)
{
    Console.WriteLine($"{num1} y {num2} son iguales");
}