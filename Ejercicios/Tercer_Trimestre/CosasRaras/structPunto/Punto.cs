namespace @struct
{
    /*
     * ¿Qué es un struct en C#?
     * -------------------------
     * Un 'struct' (estructura) es un tipo de valor que permite agrupar datos relacionados.
     * Se almacena en la pila (stack) y su copia crea una nueva instancia con los mismos valores.
     *
     * Principales diferencias entre struct y class:
     * ---------------------------------------------
     * - struct es un tipo de VALOR → se copia completamente al asignar o pasar por parámetro.
     * - class es un tipo de REFERENCIA → se copia la referencia (apuntan al mismo objeto).
     * - struct se almacena en la PILA (stack); class, en el MONTÓN (heap).
     * - struct NO permite herencia (pero sí interfaces); class SÍ.
     * - struct tiene un constructor sin parámetros implícito obligatorio.
     *
     * ¿Cuándo usar struct?
     * ---------------------
     * ✅ Para datos pequeños, simples, inmutables (como coordenadas, colores, fechas...).
     * ❌ Evitar si necesitas herencia, mutabilidad compleja o referencias compartidas.
     */

    public struct Punto
    {
        public int X;
        public int Y;

        public Punto(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Mostrar()
        {
            Console.WriteLine($"({X}, {Y})");
        }
    }
}