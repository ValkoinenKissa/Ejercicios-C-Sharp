/*
Crea un juego en el que el programa elija aleatoriamente un
número entre 1 y 10.
El usuario debe adivinarlo.
Usa un bucle do-while para permitir intentos hasta que
acierte. Usa la clase Random para generar el número aleatorio,
no la hemos dado
en clase, pero investiga.
*/

Random rd = new Random();

int numAleatorio = rd.Next(10) + 1;
int numIntroducido;
bool stop = false;

Console.WriteLine("Bienvenido al adivinador, debes de acertar el numero que ha generado el ordenador" +
                  " si deseas abandonar el programa \n");
Console.WriteLine("El numero a adivinar esta entre el 1 y el 10");

do
{
    Console.WriteLine("Ingresa el numero: ");
    numIntroducido = Convert.ToInt32(Console.ReadLine());
    if (numIntroducido == numAleatorio)
    {
        Console.WriteLine($"El numero introducido: {numIntroducido} es el correcto");
        stop = true;
    }
    else
    {
        Console.WriteLine("El numero introducido no es el correcto, sigue intentandolo");
    }
} while (!stop);