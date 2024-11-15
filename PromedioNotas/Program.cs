// See https://aka.ms/new-console-template for more information

double nota1, nota2, nota3, notaTotal;
bool stop;
Console.WriteLine("Usuario, introduce tres notas para calcular la nota media y " +
                  " saber si el alumno aprueba a suspende : \n");

Console.Write("Introduce la nota 1: ");
nota1 = double.Parse(Console.ReadLine());
if (nota1 < 0 || nota1 > 10)
{
    stop = true;
    while (stop)
    {
        Console.WriteLine("El nota debe de estar entre 0 y 10. Prueba de nuevo");
        Console.Write("Introduce la nota 1: ");
        nota1 = double.Parse(Console.ReadLine());
        if (nota1 < 0 || nota1 > 10)
        {
            stop = true;
        }
        else
        {
            stop = false;
            Console.WriteLine("Nota guardada correctamente");
        }
    }
}
else
{
    Console.WriteLine("Nota guardada correctamente");
}

Console.Write("Introduce la nota 2: ");
nota2 = double.Parse(Console.ReadLine());
if (nota2 < 0 || nota2 > 10)
{
    stop = true;
    while (stop)
    {
        Console.WriteLine("El nota debe de estar entre 0 y 10. Prueba de nuevo");
        Console.Write("Introduce la nota 2: ");
        nota2 = double.Parse(Console.ReadLine());
        if (nota2 < 0 || nota2 > 10)
        {
            stop = true;
        }
        else
        {
            stop = false;
            Console.WriteLine("Nota guardada correctamente");
        }
    }
}
else
{
    Console.WriteLine("Nota guardada correctamente");
}


Console.Write("Introduce la nota 3: ");
nota3 = double.Parse(Console.ReadLine());
if (nota3 < 0 || nota3 > 10)
{
    stop = true;
    while (stop)
    {
        Console.WriteLine("El nota debe de estar entre 0 y 10. Prueba de nuevo");
        Console.Write("Introduce la nota 3: ");
        nota3 = double.Parse(Console.ReadLine());
        if (nota3 < 0 || nota3 > 10)
        {
            stop = true;
        }
        else
        {
            stop = false;
            Console.WriteLine("Nota guardada correctamente");
        }
    }
}
else
{
    Console.WriteLine("Nota guardada correctamente");
}


notaTotal = (nota1 + nota2 + nota3) / 3;

Console.WriteLine("La nota final es: " + notaTotal);

if (notaTotal < 5)
{
    Console.WriteLine("El alumno ha suspendido");
}

else
{
    Console.WriteLine("El alumno ha aprobado");
}