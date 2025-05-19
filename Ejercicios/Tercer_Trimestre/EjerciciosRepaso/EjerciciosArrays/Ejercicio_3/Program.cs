/*
Ejercicio 3: Número más grande
Haz un programa que pida cinco números al usuario y determine cuál es el mayor
de todos. Usa una lista para almacenar los datos.
Ejemplo:
Entrada del array: [12, -5, 34, -2, -8]
Salida: "El número más grande es: 34"
*/


List<int> listaEnteros = new List<int>();

Console.WriteLine("Usuario, introduce 5 numeros y se mostrara el mayor");

for (int i = 0; i < listaEnteros.Count; i++)
{
    Console.WriteLine($"Introduce el numero {i + 1}: ");
    int numero = Convert.ToInt32(Console.ReadLine());
    listaEnteros.Add(numero);
    
}

listaEnteros.Sort();

int numeroMasGrande = listaEnteros.IndexOf(listaEnteros.Count -1);

Console.WriteLine($"El numero mas grande es: {numeroMasGrande}");




