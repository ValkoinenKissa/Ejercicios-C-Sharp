/*
Crea un programa que solicite al usuario un número y 
muestre su tabla de
multiplicar del 1 al 10 usando un bucle.
Ejemplo:
Entrada: 3
Salida:
text
3 x 1 = 3
3 x 2 = 6
...
3 x 10 = 30
*/

Console.WriteLine("Usuario, introduce un numero para calcular su tabla de multiplicar");
int numero = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{numero} X {i} = {numero * i}");
}