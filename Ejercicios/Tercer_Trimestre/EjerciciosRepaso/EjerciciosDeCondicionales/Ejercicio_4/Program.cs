/*
Escribe un programa que pida una calificación numérica 
(0 a 100) e indique si el
estudiante aprobó o no (mínimo 60 para aprobar).
Ejemplo:
Entrada: 75
Salida: "Aprobado."
*/

Console.WriteLine("Introduce una calificacion (0 a 100) para" +
                  " determinar si el alumno ha aprobado o suspendido: ");

int calificacion = Convert.ToInt32(Console.ReadLine());

if (calificacion > 100 || calificacion < 0)
{
    Console.WriteLine("Calificacion no valida, la calificacion debe de estar entre (0 a 100)");
}else if (calificacion >= 60)
{
    Console.WriteLine("El alumno ha aprobado :)");
}
else
{
    Console.WriteLine("El alumno ha suspendido :(");
}