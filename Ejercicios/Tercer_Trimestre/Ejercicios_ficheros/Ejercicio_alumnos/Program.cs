namespace Ejercicio_alumnos
{
    class Notas
    {
        static void Main()
        {
            string rutaArchivo = "estudiantes.txt";

            try
            {
                if (!File.Exists(rutaArchivo))
                {
                    Console.WriteLine("El archivo no existe.");
                    return;
                }

                int totalCalificaciones = 0;
                int contadorEstudiantes = 0;
                int calificacionMaxima = int.MinValue;
                string estudianteMejorCalificacion = "";

                Console.WriteLine("Información de estudiantes:");

                foreach (string linea in File.ReadLines(rutaArchivo))
                {
                    string[] campos = linea.Split(':');
                    if (campos.Length == 2)
                    {
                        string nombre = campos[0];
                        int calificacion = int.Parse(campos[1]);

                        Console.WriteLine($"{nombre}: {calificacion}");

                        totalCalificaciones += calificacion;
                        contadorEstudiantes++;

                        if (calificacion > calificacionMaxima)
                        {
                            calificacionMaxima = calificacion;
                            estudianteMejorCalificacion = nombre;
                        }
                    }
                }

                if (contadorEstudiantes > 0)
                {
                    double promedio = (double)totalCalificaciones / contadorEstudiantes;
                    Console.WriteLine($"\nPromedio de calificaciones: {promedio:F2}");
                    Console.WriteLine(
                        $"Estudiante con la calificación más alta: {estudianteMejorCalificacion} ({calificacionMaxima})");
                }
                else
                {
                    Console.WriteLine("\nNo se encontraron datos de estudiantes en el archivo.");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("El archivo no se encuentra.");
            }
            catch (FormatException)
            {
                Console.WriteLine("El archivo contiene datos inválidos.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error: {ex.Message}");
            }
        }
    }
}