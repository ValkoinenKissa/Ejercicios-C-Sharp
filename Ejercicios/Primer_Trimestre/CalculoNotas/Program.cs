// See https://aka.ms/new-console-template for more information

int nota1, nota2, media;

Console.WriteLine("Dime tu nota de base de datos");

nota1 = int.Parse(Console.ReadLine());
Console.WriteLine("Dime tu nota de programación");

nota2 = int.Parse(Console.ReadLine());

media = (nota1 + nota2) / 2;
Console.WriteLine("La media es: " + media);

if (media >= 5)
{
    Console.WriteLine("Aprobado");
}
else
{
    Console.WriteLine("Suspenso");
}