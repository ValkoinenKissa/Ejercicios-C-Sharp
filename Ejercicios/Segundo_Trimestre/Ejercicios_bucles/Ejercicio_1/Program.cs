/*
 * Solicitar al usuario que introduzca 5 números.
 * El programa debe contar cuántos de esos números son positivos
 * (mayores que 0) utilizando un bucle for y condicionales if.
*/
int numeros, contador =0, contadorPositivos =0, contadorNegativos = 0;
Console.WriteLine("Usuario, introduce 5 numeros:");

for (int i = 0; i <5; i++)
{
    Console.WriteLine("Introduce el numero: " + contador);
    numeros = int.Parse(Console.ReadLine());
    contador++;
    if (numeros > 0)
    {
        contadorPositivos++;
    }
    else
    {
        contadorNegativos++;
    }
}

Console.WriteLine("De los numeros que has introducido son positivos: " + contadorPositivos);
Console.WriteLine("De los numeros que has introducido son negativos: " + contadorNegativos);


