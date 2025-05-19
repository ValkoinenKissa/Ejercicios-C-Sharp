/*
Ejercicio 2: Suma de números consecutivos
Haz un programa que sume los números del 1 al 10 
usando un bucle while. Al
final, muestra el resultado.
Salida esperada: "La suma de los números del 1 al 10 es 55."

*/


Console.WriteLine("Programa que suma los números del 1 al 10");

int acumulador = 0;

for (int i = 1; i <= 10; i++)
{
    acumulador += i;
}

Console.WriteLine($"La suma de los números del 1 al 10 es: {acumulador}");