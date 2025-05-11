namespace Ejercicio_2
{
    
    /*
     * Además, crea dos clases derivadas de la clase Animal:
1.	Perro: La clase Perro debe tener un atributo adicional llamado Raza (string) y sobrescribir el método Hablar() 
para que muestre "El perro dice: Guau".
2.	Gato: La clase Gato debe tener un atributo adicional llamado Color (string) y sobrescribir el método Hablar() 
para que muestre "El gato dice: Miau".
     */
    class Gato : Animal
    {
        private string Color {get; set;}

        public Gato(string nombreAnimal, int edad, string especie, string color) : base(nombreAnimal, edad, especie)
        {
            Color = color;
        }

        public override void Hablar(string sonido)
        {
            Console.WriteLine($"El  {NombreAnimal} dice  {sonido}");
        }

        public override string MostrarInformacion()
        {
            return base.MostrarInformacion() + $", Color michi {this.Color}";
        }
    }
}

