/*
Ejercicio 2: Suma de elementos
Escribe un programa que tome como entrada una lista de cinco números y
calcule su suma total. Usa un bucle para recorrer el array.
Ejemplo:
Entrada del array: ``
Salida: "La suma total es: 30"
*/

int [] arrayEnteros = new int [5];
int acumuladorNumeros = 0;

Console.WriteLine("Usuario, introduce 5 numeros y se mostrara su suma total");

for (int i = 0; i < arrayEnteros.Length; i++)
{
    Console.WriteLine($"Introduce el numero {i + 1}: ");
    arrayEnteros[i] = Convert.ToInt32(Console.ReadLine());
    acumuladorNumeros += arrayEnteros[i];
}


Console.WriteLine($"La suma total del contenido del array es: {acumuladorNumeros} ");
