/*
 Ejercicio 1
Hacer un programa para calcular el área de un rectángulo.
Solicita al usuario que introduzca el ancho y la altura de un rectángulo.
Luego, utilizando operadores aritméticos, el programa debe calcular el área del
rectángulo (fórmula: ancho * altura) y mostrar el resultado en la 
*/


//Declaración de variables
double ancho, altura, area;

Console.WriteLine("Bienvenido al programa para calcular el area del rectangulo. A continuación ingrese el" +
                  " ancho y la altura del rectangulo para así calcular su area \n");

Console.WriteLine("Ingrese ancho del rectangulo: ");
ancho = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la altura del rectangulo: ");
altura = double.Parse(Console.ReadLine());

area = ancho * altura;

Console.WriteLine("El area del rectangulo es:  " + area);