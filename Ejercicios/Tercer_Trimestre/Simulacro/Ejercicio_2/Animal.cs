namespace Ejercicio_2;
/*
 * •	Atributos:
o	Nombre (string): El nombre del animal.
o	Edad (int): La edad del animal.
o	Especie (string): La especie a la que pertenece el animal.
•	Métodos:
o	Hablar(): Este método debe mostrar por consola un mensaje que indique qué sonido hace el animal
 (por ejemplo, "El perro dice: Guau", "El gato dice: Miau").
o	MostrarInformacion(): Este método debe mostrar en consola el nombre, edad y especie del animal.
 */
public class Animal
{
    protected string NombreAnimal {get; set;}
    private int Edad {get; set;}
    private string Especie {get; set;}

    public Animal(string nombreAnimal, int edad, string especie)
    {
        this.NombreAnimal = nombreAnimal;
        this.Edad = edad;
        this.Especie = especie;
    }

    public virtual void Hablar(string sonido)
    {
        Console.WriteLine($"El  {NombreAnimal} dice  {sonido}");
    }

    public virtual string MostrarInformacion()
    {
        return ($" Nombre animal: {NombreAnimal}, edad: {Edad}, Especie: {Especie}");
    }
}