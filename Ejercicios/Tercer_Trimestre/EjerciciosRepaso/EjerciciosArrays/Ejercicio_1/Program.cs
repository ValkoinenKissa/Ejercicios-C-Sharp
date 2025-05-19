/*
Ejercicio 1: Números mayores a diez
Crea un array con cinco números ingresados por el usuario y 
muestra cuáles son
mayores a diez.

Ejemplo:
Entrada del array: ``
Salida: "15, 23"
*/

int [] arrayEnteros = new int [5];

Console.WriteLine("Usuario, introduce 5 numeros y se mostraran los maayores de 10");

for (int i = 0; i < arrayEnteros.Length; i++)
{
    Console.WriteLine($"Introduce el numero {i + 1}: ");
    arrayEnteros[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Mostrando los numeros mayores de 10: ");
foreach (var item in arrayEnteros)
{
    if (item > 10)
    {
        Console.Write(item + " ");
    }
}

