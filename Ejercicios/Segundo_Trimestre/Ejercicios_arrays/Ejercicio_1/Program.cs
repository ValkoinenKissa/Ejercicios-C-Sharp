/*
 * Problema1.-Muestra el array en orden inverso.
*/

int [] arrayCutre = {15, 20, 35, 60, 90};

Console.WriteLine("Imprimiendo el array en orden normal...");
for (int i = 0; i < arrayCutre.Length; i++)
{
    Console.Write(arrayCutre[i]);
    Console.Write(" ");
    
}

Console.WriteLine("\nImprimiendo el array en orden inverso...");


int[] arrayReverso;

arrayReverso = arrayCutre.Reverse().ToArray();

foreach (int numero in arrayReverso)
{
    Console.Write(numero + " ");
}

