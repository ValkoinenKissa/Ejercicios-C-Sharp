/*
Crea un programa en C# que permita al usuario ingresar 5 calificaciones
numéricas en un array. El programa debe calcular y mostrar la media de esas
calificaciones.
*/

double [] arrayCalificaciones = new double[5];
double calificacion, acumulador =0, resultado = 0;
for (int i = 0; i < arrayCalificaciones.Length; i++)
{
    Console.WriteLine($"Introduce la nota del alumno: {i + 1}");
    calificacion = Convert.ToDouble(Console.ReadLine());

    do
    {
        if (calificacion > 10 || calificacion <0)
        {
            Console.WriteLine($"La nota del alumno {i + 1} es invalida, no puede ser mayor que 10 ni menor que 0");
            Console.WriteLine($"Introduce la nota del alumno: {i + 1}");
            calificacion = Convert.ToDouble(Console.ReadLine());
        }
        else
        {
            arrayCalificaciones[i] = calificacion;
        }
    }while (calificacion > 10 || calificacion <0);
    
    }

for (int i = 0; i < arrayCalificaciones.Length; i++)
{
    acumulador += arrayCalificaciones[i];
    
    resultado = acumulador / arrayCalificaciones.Length;
}

Console.WriteLine($"La nota media del total de calificaciones registrasas es: {resultado}");