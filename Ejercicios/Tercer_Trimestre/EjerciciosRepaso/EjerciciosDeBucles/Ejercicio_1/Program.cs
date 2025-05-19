/*
Ejercicio 1: Contar hasta un número
Escribe un programa que pida al usuario un número entero
positivo y cuente
desde 1 hasta ese número. Usa un bucle for.
Ejemplo:
Entrada: 5
Salida: "1, 2, 3, 4, 5"

*/

Console.WriteLine("Introduce el numero hasta donde quieras contar: ");

int contarHasta = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= contarHasta; i++)
{
    Console.Write(i);
    if (i < contarHasta)
    {
        Console.Write(",");
    }
    else
    {
        Console.Write(" ");
    }
   
}