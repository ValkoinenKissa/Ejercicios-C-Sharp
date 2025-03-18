namespace StringUtils;

public class EjecutableLocal
{
    static void Main()
    {
        int contadorLetras = UtilidadesCadenas.ContarLetrasString("HOLA");
        Console.WriteLine($"La palabra HOLA tiene: {contadorLetras} letras");
    }
}