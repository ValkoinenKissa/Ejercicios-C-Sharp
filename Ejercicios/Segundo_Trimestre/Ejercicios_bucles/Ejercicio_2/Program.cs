/*Solicitar al usuario que introduzca un número entero positivo N.
El programa debe sumar todos los números pares desde 1
hasta N utilizando un bucle for y condicionales if.*/

int numeroN, acumulador=0;

Console.WriteLine("Usuario, introduce un numero cualquera para sumar todos sus pares desde el 1");

numeroN = int.Parse(Console.ReadLine());

if (numeroN < 0)
{
    Console.WriteLine("El numero introducido es negativo, introduce un numero positivo");
}
else
{
    for (int i = 1; i <= numeroN; i++)
    {
        if (i % 2 == 0)
        {
            acumulador += i;
        }
    }
}

Console.WriteLine("La suma de todos los numeros pares desde 1 hasta " + numeroN + " es " + acumulador);