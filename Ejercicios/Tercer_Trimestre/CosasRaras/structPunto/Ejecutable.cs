namespace @struct;

public class Ejecutable
{
    public static void Main()
    {
        // Crear un punto con el constructor
        Punto p1 = new Punto(3, 4);
        p1.Mostrar();  // Muestra: (3, 4)

        // Crear un punto sin usar el constructor (valores por defecto: 0)
        Punto p2;
        p2.X = 10;
        p2.Y = 20;
        p2.Mostrar();  // Muestra: (10, 20)

        // Copia por valor
        Punto p3 = p1;
        p3.X = 100;
        p3.Mostrar();  // Muestra: (100, 4)
        p1.Mostrar();  // Muestra: (3, 4) → p1 no se vio afectado
    }
}