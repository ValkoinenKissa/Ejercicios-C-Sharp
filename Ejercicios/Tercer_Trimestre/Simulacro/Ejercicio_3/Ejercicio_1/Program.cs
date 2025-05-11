/*
 Escribe un programa en C# que solicite al usuario las calificaciones de 10 alumnos y las almacene en un vector.
 El programa debe realizar las siguientes operaciones:


1.	Contar cuántos alumnos han aprobado y cuántos han suspendido:
o	Se considera aprobado si la nota es mayor o igual a 6.
o	Se considera suspendido si la nota es menor a 6.
2.	Calcular la media de las calificaciones introducidas:
o	La media se calcula sumando todas las notas y dividiendo el resultado entre el número total de alumnos.
Finalmente, el programa debe mostrar:
•	La cantidad de aprobados.
•	La cantidad de suspendidos.
•	La media de las calificaciones.

 */

namespace Ejercicio_1
{
    class Ejercicio1
    {
        public static void Main()
        {
            double[] vectorCalificaciones = new double[10];
            int alumnosAprobados = 0, alumnosSuspendidos = 0, contador = 0;
            double notaMedia, acumulador = 0;
            Console.WriteLine("Bienvenido al programa de calificaciones, introduce a continuacion las notas" +
                              " de cada alumno: ");
            for (var i = 0; i < vectorCalificaciones.Length; i++)
            {
                Console.WriteLine($"Ingresa la calificacion del alumno: {i+1}");
                vectorCalificaciones[i] = Convert.ToDouble(Console.ReadLine());
            }


            foreach (int i in vectorCalificaciones)
            {
                contador++;
                acumulador += i;
                if (i >= 6)
                {
                    alumnosAprobados++;
                }
                else
                {
                    alumnosSuspendidos++;
                }
            }

            notaMedia = (acumulador / contador);

            Console.WriteLine($"$La nota media de los alumnos introducidos es de: {notaMedia}");
            Console.WriteLine($"La cantidad de alumnos suspendidos es de: {alumnosSuspendidos}");
            Console.WriteLine(($"La cantidad de los alumnos aprobados es de: {alumnosAprobados} "));
        }
    }
}