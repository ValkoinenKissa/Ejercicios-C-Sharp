namespace Ejercicio_alumnos_write
{
    class Notas
    {
        static void Main()
        {
            string rutaArchivo = "estudiantes.txt";

            try
            {
                Console.WriteLine("=== Registro de calificaciones ===");
                Console.Write("¿Cuántos estudiantes vas a registrar? ");
                if (!int.TryParse(Console.ReadLine(), out int numeroEstudiantes) || numeroEstudiantes <= 0)
                {
                    Console.WriteLine("Número inválido. Saliendo del programa.");
                    return;
                }

                // Usamos StreamWriter para escribir, sobrescribiendo si ya existe
                using (StreamWriter escritor = new StreamWriter(rutaArchivo, false))
                {
                    for (int i = 1; i <= numeroEstudiantes; i++)
                    {
                        Console.Write($"\nNombre del estudiante #{i}: ");
                        string nombre = Console.ReadLine()?.Trim() ?? "";
                        if (string.IsNullOrEmpty(nombre))
                        {
                            Console.WriteLine("Nombre no puede estar vacío. Intenta de nuevo.");
                            i--;
                            continue;
                        }

                        Console.Write($"Calificación de {nombre}: ");
                        if (!int.TryParse(Console.ReadLine(), out int calificacion) || calificacion < 0 || calificacion > 10)
                        {
                            Console.WriteLine("Calificación inválida (0–10). Intenta de nuevo.");
                            i--;
                            continue;
                        }

                        // Escribimos en el fichero con el formato nombre:calificación
                        escritor.WriteLine($"{nombre}:{calificacion}");
                        Console.WriteLine("✔ Registrado correctamente.");
                    }
                }

                Console.WriteLine($"\nDatos guardados en '{rutaArchivo}' con éxito. 🎉");
                Console.WriteLine("Ya puedes consultar el fichero para ver los resultados.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("No tienes permiso para escribir en este directorio.");
            }
            catch (IOException ioEx)
            {
                Console.WriteLine($"Error de E/S al escribir el archivo: {ioEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
            }
        }
    }
}
