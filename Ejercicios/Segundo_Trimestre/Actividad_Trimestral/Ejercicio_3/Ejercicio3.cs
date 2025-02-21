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
        //Declaracion de array dinamico
        List<double> lista = new List<double>();
        //Lamada al metodo donde ingresar las calificaciones
        IngresarCalificaciones(lista);
        //Declaracion variable para almacenar el retorno del metodo CalcularMediaCalificaciones
        double resultadoFinal = CalcularMediaCalificaciones(lista);
        //Se muestra la nota media total del alumnado
        Console.WriteLine($"La media de la nota de los alumnos es: {resultadoFinal}");

    }

    static void IngresarCalificaciones(List<double> lista)
    {
        //Declaracion de variables
        string decision;
        double calificacion;
        int contador = 1;
        Console.WriteLine("Ingresa las calificaciones de tus alumnos, para continuar introduce 'Y' y para parar " +
                          " introduce 'N' ");
        //Bucle do-while para solicitar calificaciones según un total variable de alumnos
        do
        {
            Console.WriteLine($"Ingresa la calificación del alumno {contador}");
            calificacion = Convert.ToDouble(Console.ReadLine());
            //Validacion de calificacion, entre 0 y 10
            if (calificacion < 0 || calificacion > 10)
            {
                Console.WriteLine("La calificacion introducida es incorrecta, debe de estar entre 0 y 10");
                Console.WriteLine("¿Quieres continuar? (Y or N) ");
                //Control de bucle para salir del programa si el usuario así lo desea
                decision = Console.ReadLine()?.ToUpper() ?? "N"; // Si es null, usa "N" como default
            }
            else
            {
                //Se añade la calificacion verificada a la lista
                lista.Add(calificacion);
                Console.WriteLine("Calificación registrada correctamente");
                Console.WriteLine("¿Quieres continuar? (Y or N) ");
                //Control de bucle para salir del programa si el usuario así lo desea
                decision = Console.ReadLine()?.ToUpper() ?? "N"; // Si es null, usa "N" como default
                contador++;
            }
            
            //El bucle continua siempre que la decision equivalga a 'Y'

        } while (decision.Equals("Y"));
       //Mensaje de informacion 
        Console.WriteLine("Procesando la media de las calificaciones obtenidas...");
    }

    static double CalcularMediaCalificaciones(List<double> lista)
    {
        //Acumulador donde se almacenan las notas
        double acumulador = 0;
        //Contador de elementos introducidos en la lista mediante el metodo .Count
        int contadorElementos = lista.Count;
        //Se recorre la lista para sumar todos sus valores en la variable contador
        foreach (double valores in lista)
        {
            
            acumulador += valores;
            
        }
        //Se divide el acumulador entre el numero de elementos y se retorna el valor final
        double mediaFinal = acumulador / contadorElementos;
        return mediaFinal;
    }
    
}

