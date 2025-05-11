namespace Ejercicio_2;
/*
 * Además, crea dos clases derivadas de la clase Animal:
1.	Perro: La clase Perro debe tener un atributo adicional llamado Raza (string) y sobrescribir el método Hablar()
para que muestre "El perro dice: Guau".
2.	Gato: La clase Gato debe tener un atributo adicional llamado Color (string) y sobrescribir el método Hablar()
para que muestre "El gato dice: Miau".
 */
public class Perro : Animal
{
    private string Raza {get; set;}

    public Perro(string nombreAnimal, int edad, string especie, string raza) : base(nombreAnimal, edad, especie)
    {
        Raza = raza;
    }

    public override void Hablar(string sonido)
    {
        Console.WriteLine($"El  {NombreAnimal} dice  {sonido}");
    }

    public override string MostrarInformacion()
    {
        return base.MostrarInformacion() + $", Raza perro {this.Raza}";
    }
}