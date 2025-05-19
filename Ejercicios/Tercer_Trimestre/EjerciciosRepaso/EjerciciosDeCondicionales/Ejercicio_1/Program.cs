/*
Escribe un programa que pida al usuario un número entero y determine si es
positivo, negativo o cero.
Ejemplo:
Entrada: -5
Salida: "El número es negativo."
*/

Console.WriteLine("Usuario introduce un numero entero: ");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero == 0)
{
    Console.WriteLine("El numero es 0");
}else if (numero < 0)
{
    Console.WriteLine("El numero es negativo");
}
else
{
    Console.WriteLine("El numero es positivo");
}