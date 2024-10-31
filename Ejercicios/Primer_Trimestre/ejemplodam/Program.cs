// Programa de la clase de DAM

Console.WriteLine("Clase de fundamentos");
//Declaracion de variables
int num1, num2, suma, resta, multi;
double division, resto;
//Entrada de valores desde el teclado
Console.WriteLine("Ingresa el nunero 1: ");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresa el nunero 2: ");
num2 = int.Parse(Console.ReadLine());
//Operaciones
suma=num1 + num2;
resta=num1 - num2;
multi=num1 * num2;
division=num1 / num2;
resto=num1 % num2;
//Salida del resultado
Console.WriteLine("El resultado de la suma es: " + suma);
Console.WriteLine("El resultado de la resta es: " + resta);
Console.WriteLine("El resultado de la multi es: " + multi);
Console.WriteLine("El resultado de la division es: " + division);
Console.WriteLine("El resultado de la resto es: " + resto);