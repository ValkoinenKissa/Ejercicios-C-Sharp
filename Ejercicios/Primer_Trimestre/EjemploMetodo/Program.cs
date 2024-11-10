// See https://aka.ms/new-console-template for more information

namespace EjemploMetodo
{
    class EjemploMetodo
    {
        static public void Main(String[] args)
        {
            realizarSuma(1, 7);
            Console.WriteLine("El resultado de la multiplicación es {0}", realizarMultiplicacion(8, 2));
        }

        static public void realizarSuma(int op1, int op2)
        {
            Console.WriteLine("El resultado de la suma es {0}", op1 + op2);
        }

        static public int realizarMultiplicacion(int op1, int op2)
        {
            return op1 * op2;
        }
    }
}