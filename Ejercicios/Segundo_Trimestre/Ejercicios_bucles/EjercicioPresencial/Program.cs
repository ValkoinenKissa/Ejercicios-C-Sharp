/*

Escribe un programa en C# que permita al usuario ingresar un número y muestre la
tabla de multiplicar de ese número hasta el 10. Por ejemplo, si el usuario ingresa
5, el programa debe mostrar:
5 x 1 = 5 5 x 2 = 10 ... 5 x 10 = 50

*/
int numero;
Console.WriteLine("Usuario, introduce un numero para generar su tabla de multiplicar hasta el 10:");

numero = Convert.ToInt32(Console.ReadLine());

if (numero < 0 || numero > 10)
{
    Console.WriteLine("El numero para generar la tabla de multiplicar, no puede ser menor que 0 ni mayor que 10");
}
else
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{numero} X {i} = {numero * i}");

    }
}