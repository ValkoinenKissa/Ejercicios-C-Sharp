/*
3.-Solicita al usuario que introduzca un número entero.
El programa debe verificar si el número no es múltiplo de 7 utilizando el operador NOT (!).
Si no es múltiplo de 7, mostrar un mensaje indicando que no lo es; de lo contrario, indicar que sí lo es.
*/

int numero;
Console.WriteLine("Usuario, introduce un numero: ");
numero = int.Parse(Console.ReadLine());

if (numero % 7 != 0)
{
    Console.WriteLine("El numero introducido no es multiplo de 7");
}
else
{
    Console.WriteLine("El numero introducido es multiplo de 7");
}