/*
Ejercicio 5: Buscar elemento en una lista
Pide al usuario cinco nombres y guárdalos en una lista.
Luego solicita otro nombre
e indica si está en la lista o no. Usa el método .Contains().
Ejemplo:
Lista inicial: [Juan, Ana, Pedro, Luis, María]
Nombre buscado: Luis
Salida esperada: "Luis está en la lista."
*/

List<string> listaNombres = new List<string>();

Console.WriteLine("Usuario, introduce 5 nombres, para guardarlos");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Introduce el nombre {i + 1}:");
    listaNombres.Add(Console.ReadLine()?.ToLower() ?? "");
}


Console.WriteLine("Ahora puedes buscar el nombre en la lista, para combrobar si esta: ");

string nombreABuscar = Console.ReadLine()?.ToLower() ?? "";

bool contiene = listaNombres.Contains(nombreABuscar);

if (contiene)
{
    Console.WriteLine($"{nombreABuscar} está en la lista.");
}
else
{
    Console.WriteLine($"El nombre {nombreABuscar} no se ha encontrado en la lista.");
}