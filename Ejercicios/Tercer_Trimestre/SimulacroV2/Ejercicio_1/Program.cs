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
            double[] arrayCalificaciones = new double[10];
            int alumnosAprobados = 0;
            int alumnosSuspensos = 0;
            double acumulador = 0, notaMedia = 0;


            for (int i = 0; i < arrayCalificaciones.Length; i++)
            {
                Console.WriteLine($"Introduce la nota del alumno {i + 1}: ");
                arrayCalificaciones[i] = Convert.ToDouble(Console.ReadLine());

                if (arrayCalificaciones[i] >= 6)
                {
                    alumnosAprobados++;
                }
                else if (arrayCalificaciones[i] < 6)
                {
                    alumnosSuspensos++;
                }
            }

            int longitudArray = arrayCalificaciones.Length;


            foreach (var num in arrayCalificaciones)
            {
                acumulador += num;
            }

            notaMedia = (acumulador / longitudArray);


            Console.WriteLine($"Han aprobado: {alumnosAprobados} alumnos");
            Console.WriteLine($"Han suspendido: {alumnosSuspensos} alumnos");
            Console.WriteLine($"La nota media es: {notaMedia}");

        }
    }
}