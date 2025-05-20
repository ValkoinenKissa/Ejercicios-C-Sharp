/*
Ejercicio 4: Invertir elementos
Solicita al usuario cinco palabras y guárdalas en una lista. Luego muestra la lista
en orden inverso.
Ejemplo:
Entrada del array (en orden): [manzana, pera, uva, mango, fresa]
Salida (invertido): [fresa, mango, uva, pera, manzana]
*/

List<string> listaPalabras = new List<string>();

Console.WriteLine("Usuario, introduce 5 palabras, para imprimirlas en orden inverso");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Introduce la plabra {i + 1} :");
    listaPalabras.Add(Console.ReadLine() ?? "");
}

listaPalabras.Reverse();

foreach (var item in listaPalabras)
{
    Console.Write(item + ",");
}