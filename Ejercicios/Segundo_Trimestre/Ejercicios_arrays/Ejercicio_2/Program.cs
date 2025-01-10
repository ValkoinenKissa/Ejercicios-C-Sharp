/*
 * Escribe un programa que calcule la suma de todos los valores que tiene un array.
*/

int [] arrayNumeros = new int [5];

int numeroAleatorio, sumaNumeros=0;

Random random = new Random();

for (int i = 0; i < arrayNumeros.Length; i++)
{
    numeroAleatorio = random.Next (1, 100);
    arrayNumeros[i] = numeroAleatorio;
}

Console.WriteLine ("Imprimiendo array de numeros aleatorios de 5 posiciones...");

for (int i = 0; i < arrayNumeros.Length; i++)
{
    Console.Write(arrayNumeros[i]);
    Console.Write(" ");
    sumaNumeros += arrayNumeros[i];
}

Console.WriteLine ("\nLa suma de todos los numeros generados es: " + sumaNumeros);