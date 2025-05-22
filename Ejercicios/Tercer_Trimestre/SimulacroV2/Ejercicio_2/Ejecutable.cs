/*
Imagina que estás creando un programa para gestionar información sobre diferentes animales en un zoológico. 
Debes implementar una clase llamada Animal que tenga los siguientes atributos y métodos:
•	Atributos:
o	Nombre (string): El nombre del animal.
o	Edad (int): La edad del animal.
o	Especie (string): La especie a la que pertenece el animal.
•	Métodos:
o	Hablar(): Este método debe mostrar por consola un mensaje que indique qué sonido hace el animal 
(por ejemplo, "El perro dice: Guau", "El gato dice: Miau").
o	MostrarInformacion(): Este método debe mostrar en consola el nombre, edad y especie del animal.
Además, crea dos clases derivadas de la clase Animal:
1.	Perro: La clase Perro debe tener un atributo adicional llamado Raza (string) y 
sobrescribir el método Hablar() para que muestre "El perro dice: Guau".
2.	Gato: La clase Gato debe tener un atributo adicional llamado Color (string) y
 sobrescribir el método Hablar() para que muestre "El gato dice: Miau".


Instrucciones:
1.	Crea los objetos de tipo Perro y Gato con valores de ejemplo.
2.	Llama al método MostrarInformacion() para cada uno de los objetos.
3.	Llama al método Hablar() para cada uno de los objetos y muestra su sonido característico.
Este ejercicio debe permitirte practicar la creación de clases, la herencia, la sobrescritura de métodos y el uso de objetos en C#.

*/

namespace Ejercicio_2
{

    public class Ejecutable
    {
        public static void Main()
        {

            Gato g = new Gato("Mufi", 12, "Michi", "Blanco");
            Perro p = new Perro("Fido", 5, "Perro", "Terrier");

            g.MostrarInformacion();
            g.Hablar();


            p.MostrarInformacion();
            p.Hablar();

        }
    }

}