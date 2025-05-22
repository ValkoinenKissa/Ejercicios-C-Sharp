namespace Ejercicio_4
{

class Programa
{
    static void Main()
    {
        try
        {
            int numerador = 10;
            int denominador = 0;

            // Lanzamos la excepción si el denominador es 0
            if (denominador == 0)
            {
                throw new DivideByZeroException("No se puede dividir entre cero.");
            }

            int resultado = numerador / denominador;
            Console.WriteLine("Resultado: " + resultado);
        }
        catch (DivideByZeroException ex)
        {
            // Tratamos la excepción específica
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            // Tratamos cualquier otra excepción no prevista
            Console.WriteLine("Ocurrió un error inesperado: " + ex.Message);
        }
        finally
        {
            // Código que siempre se ejecuta, ocurra o no una excepción
            Console.WriteLine("Finalizando el programa.");
        }
    }
}

}