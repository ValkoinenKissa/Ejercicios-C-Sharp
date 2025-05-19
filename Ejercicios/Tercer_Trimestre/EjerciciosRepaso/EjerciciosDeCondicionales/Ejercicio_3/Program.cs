/*

Haz un programa que pida al usuario un año y determine si 
es bisiesto. 
Un año es
bisiesto si es divisible entre 4, pero no entre 100, 
a menos que también sea
divisible entre 400.
Ejemplo:
Entrada: 2024
Salida: "El año es bisiesto."
*/

Console.WriteLine("Usuario, introduce un año para ver si es o no bisiesto");
int year = Convert.ToInt32(Console.ReadLine());

if (year % 4 == 0)
{
    Console.WriteLine("El año es bisiesto");
} else
{
    Console.WriteLine("El año no es bisiesto");
}