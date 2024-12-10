/*
1.- Solicitar al usuario que introduzca tres calificaciones de un estudiante.
El programa debe calcular el promedio de las tres calificaciones.
Si el promedio es mayor o igual a 5 y todas las calificaciones son mayores o iguales a 5, indicar que
el estudiante aprueba; de lo contrario, indicar que suspende.
*/
double calificacion1, calificacion2, calificacion3, promedio;
Console.WriteLine("Usuario, introduce tres calificaciones para calcular el promedio");

Console.WriteLine("Introduce la primera calificacion: ");
calificacion1 = double.Parse(Console.ReadLine());
Console.WriteLine("Introduce la segunda calificacion: ");
calificacion2 = double.Parse(Console.ReadLine());
Console.WriteLine("Introduce la tercera calificacion: ");
calificacion3 = double.Parse(Console.ReadLine());

promedio = (calificacion1 + calificacion2 + calificacion3) / 3;

if (promedio >= 5 && calificacion1 >= 5 && calificacion2 >= 5 && calificacion3 >= 5)
{
    Console.WriteLine("El alumno ha conseguido aprobar");
}
else
{
    Console.WriteLine("El alumno no ha aprobado");
}