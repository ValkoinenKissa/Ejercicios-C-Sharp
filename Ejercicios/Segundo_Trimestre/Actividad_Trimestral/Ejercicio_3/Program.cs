/*
Desarrolla un programa que permita al usuario crear una lista de calificaciones. El
programa debe:
• Permitir ingresar calificaciones
• Calcular el promedio de las calificaciones
*/

namespace Ejercicio_3;

class Ejercicio3
{
    static void Main()
    {

        List<double> lista = new List<double>();
        IngresarCalificaciones(lista);
        double resultadoFinal = CalcularMediaCalificaciones(lista);
        Console.WriteLine($"La media de la nota de los alumnos es: {resultadoFinal}");

    }

    static void IngresarCalificaciones(List<double> lista)
    {
        string decision;
        double calificacion;
        int contador = 1;
        Console.WriteLine("Ingresa las calificaciones de tus alumnos, para continuar introduce 'Y' y para parar " +
                          " introduce 'N' ");

        do
        {
            Console.WriteLine($"Ingresa la calificación del alumno {contador}");
            calificacion = Convert.ToDouble(Console.ReadLine());
            if (calificacion < 0 || calificacion > 10)
            {
                Console.WriteLine("La calificacion introducida es incorrecta, debe de estar entre 0 y 10");
                Console.WriteLine("¿Quieres continuar? (Y or N) ");
                decision = Console.ReadLine()?.ToUpper() ?? "N"; // Si es null, usa "N" como default
            }
            else
            {
                lista.Add(calificacion);
                Console.WriteLine("Calificación registrada correctamente");
                Console.WriteLine("¿Quieres continuar? (Y or N) ");
                decision = Console.ReadLine()?.ToUpper() ?? "N"; // Si es null, usa "N" como default
                contador++;
            }

        } while (decision.Equals("Y"));
        
        Console.WriteLine("Procesando la media de las calificaciones obtenidas...");
    }

    static double CalcularMediaCalificaciones(List<double> lista)
    {
        double acumulador = 0;
        int contadorElementos = lista.Count;
        foreach (double valores in lista)
        {
            
            acumulador += valores;
            
        }
        
        double mediaFinal = acumulador / contadorElementos;
        return mediaFinal;
    }
    
}

