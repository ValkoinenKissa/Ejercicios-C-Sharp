/*
Crea un programa que solicite un número entero 
y determine si es par o impar.
Ejemplo:
Entrada: 8
Salida: "El número es par."

*/

Console.WriteLine("Introduce un numero para verificar si es par u impar");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine("El numero es par");
}
else
{
    Console.WriteLine("El numero es impar");
}