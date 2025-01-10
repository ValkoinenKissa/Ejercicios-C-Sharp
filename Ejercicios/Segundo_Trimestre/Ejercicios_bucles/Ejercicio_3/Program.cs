/*Solicitar al usuario que introduzca un número entero positivo. Utilizando un bucle while,
el programa debe contar cuántos dígitos tiene el número introducido.*/
int numero, digitos=0, numeroIntroducido =0;
Console.WriteLine("Usuario, introduce un numero entero positivo para contar cuantos digitos tiene el numero " +
                  " introducido");

numero = int.Parse(Console.ReadLine());
if (numero < 0)
{
    Console.WriteLine("El numero no puede ser negativo");
}
else
{
    numeroIntroducido = numero;
    while (numero != 0)
    {
        numero /= 10;
        digitos++;
    }
}

Console.WriteLine("El numero de digitos del numero " + numeroIntroducido + " es " + digitos);