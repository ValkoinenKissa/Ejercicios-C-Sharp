/*
 * 1.-Hacer un programa que permita ingresar los kilómetros existentes  entre dos ciudades y la velocidad promedio de un vehículo. 
 * Calcular y emitir por pantalla el tiempo aproximado que demandará  llegar de un punto a otro.
 * La formula es :    tiempo = kilometros / velocidad
 */

Console.WriteLine("Introduce el kilometraje entre ciudad A y ciudad B: ");

double kilometraje = double.Parse(Console.ReadLine());

Console.WriteLine("Introduce la velocidad promedia a la que crees que vas a conducir durante todo el trayecto: ");
int velocidad = int.Parse(Console.ReadLine());

double tiempo = kilometraje / velocidad;

Console.WriteLine("El tiempo de trayecto aproximado es de: " + tiempo + " horas");