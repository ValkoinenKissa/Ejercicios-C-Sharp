// Ejemplo de AND

Console.WriteLine("Introduce una nota");
int numero = int.Parse(Console.ReadLine());

if (numero >= 5 && numero <= 10)
{
    Console.WriteLine("Aprobado");
}
else
{
    Console.WriteLine("Suspenso o nota erronea");
}