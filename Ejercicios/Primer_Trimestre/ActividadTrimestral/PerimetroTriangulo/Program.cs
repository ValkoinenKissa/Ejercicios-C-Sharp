/*
Hacer un programa para calcular el perímetro de un triángulo.
Solicita al usuario que introduzca las longitudes de los tres lados de un triángulo.
El programa debe calcular el perímetro del triángulo sumando las tres longitudes
(lado1 + lado2 + lado3) y mostrar el resultado en la consola
 */
//Declaración de variables
double lado1, lado2, lado3, perimetro;

Console.WriteLine("Bienvenido al programa para calcular el perimetro del triangulo. A continuación ingrese las" +
                  "  tres longitudes de sus lados para mostrar el perimetro\n");

Console.WriteLine("Introduce el lado 1 del triangulo: ");
lado1 = double.Parse(Console.ReadLine());
Console.WriteLine("Introduce el lado 2 del triangulo: ");
lado2 = double.Parse(Console.ReadLine());
Console.WriteLine("Introduce el lado 3 del triangulo: ");
lado3 = double.Parse(Console.ReadLine());

perimetro = lado1 + lado2 + lado3;

Console.WriteLine("El perimetro según los lados que has introducido es: " + perimetro);