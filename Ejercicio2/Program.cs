/*
2.- Vamos Calcular el precio total con descuento según la edad. 
Solicitar al usuario que introduzca su edad y el precio de un producto. 
Si la edad es menor de 18 o mayor de 60, se aplica un descuento del 15% al precio del producto. 
Si no, se paga el precio completo. 
El programa debe mostrar el precio final.
*/

int edad;
double precioProducto, precioFinal;
const double DESCUENTO_QUINCE = 0.15;

Console.WriteLine("Usuario, introduce tu edad y el precio del producto para calcular su descuento: ");

Console.WriteLine("Introduce la edad: ");
edad = int.Parse(Console.ReadLine());
Console.WriteLine("Introduce el precio de produto: ");
precioProducto = double.Parse(Console.ReadLine());

if (edad < 18 || edad > 60)
{
    
    precioFinal = precioProducto -  DESCUENTO_QUINCE * precioProducto;
    Console.WriteLine("El precio del producto es: " + precioFinal + " se ha aplicado un descuento del " +
                      " " + DESCUENTO_QUINCE * 100 + "%");
    
}
else
{
    precioFinal = precioProducto;
    Console.WriteLine("El precio del producto es: " + precioFinal);
    Console.WriteLine("No se ha aplicado ningun descuento");
}