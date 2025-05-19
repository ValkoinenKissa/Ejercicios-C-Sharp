/*
Ejercicio 4: Contar números pares
Escribe un programa que cuente cuántos números pares hay entre
dos números
dados por el usuario (incluyendo ambos). Usa un bucle for.
Ejemplo:
Entrada: 2, 10
Salida: "Hay 5 números pares."
*/

Console.WriteLine("Usuario, introduce dos numero para ver cuantos numeros pares hay entre ambos");
int num1, num2, contadorPares = 0;
Console.WriteLine("Introduce el numero 1");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Introduce el numero 2");
num2 = Convert.ToInt32(Console.ReadLine());

// Asegurar que num1 sea el menor y num2 el mayor (por si el usuario los introduce al revés)
if (num1 > num2)
{
    int temp = num1;
    num1 = num2;
    num2 = temp;
}

for (int i = num1; i <= num2; i++)
{
    if (i % 2 == 0)
    {
        contadorPares++;
    }
}

Console.WriteLine($"Los numeros pares entre {num1} y entre {num2} son: {contadorPares}");