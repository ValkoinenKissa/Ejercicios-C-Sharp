/*
Ejercicio 5: Fecha actual con DateTime
Usa la librería System.DateTime para mostrar la fecha actual en formato completo
("dd/MM/yyyy HH:mm:ss"). Luego crea una función
llamada MostrarFechaActual() que encapsule esta funcionalidad.
*/

namespace Ejercicio_5
{
    class Ejercicio5
    {
        public static void Main()
        {
            MostrarFechaActual();
        }

        static void MostrarFechaActual()
        {
            DateTime fechaActual = DateTime.Now;
            Console.WriteLine($"El fecha de actual: {fechaActual}");
        }
    }
}