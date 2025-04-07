namespace Ejercicio_libros;

// Definimos la clase Libro para representar cada entrada del fichero
class Libro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Anio { get; set; }

    public override string ToString()
    {
        return $"{Titulo} por {Autor} ({Anio})";
    }
}

class Program
{
    static void Main(string[] args)
    {
        string rutaArchivo = "libros.txt";
        List<Libro> libros = new List<Libro>();

        try
        {
            // Leemos el fichero y creamos objetos Libro
            foreach (string linea in File.ReadLines(rutaArchivo))
            {
                string[] campos = linea.Split(':');
                if (campos.Length == 3)
                {
                    libros.Add(new Libro
                    {
                        Titulo = campos[0],
                        Autor = campos[1],
                        Anio = int.Parse(campos[2])
                    });
                }
            }

            // Mostramos todos los libros
            Console.WriteLine("Lista de libros:");
            foreach (var libro in libros)
            {
                Console.WriteLine(libro);
            }

            // Calculamos y mostramos el año promedio de publicación
            double anioPromedio = libros.Average(l => l.Anio);
            Console.WriteLine($"\nAño promedio de publicación: {anioPromedio:F2}");

            // Encontramos y mostramos el libro más antiguo
            Libro libroMasAntiguo = libros.OrderBy(l => l.Anio).First();
            Console.WriteLine($"\nLibro más antiguo: {libroMasAntiguo.Titulo} ({libroMasAntiguo.Anio})");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("El archivo no se encuentra.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió un error: {ex.Message}");
        }
    }
}
