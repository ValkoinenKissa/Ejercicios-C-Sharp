namespace EjerciciosBasicos
{
    class EjerciciosBasicos
    {
        public static void Main()
        {
            //Declaracion y relleno de vector
            string[] dias1 = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            string[] dias2 = new string[7];
            dias2[0] = "Monday";
            dias2[1] = "Tuesday";
            dias2[2] = "Wednesday";
            dias2[3] = "Thursday";
            dias2[4] = "Friday";
            dias2[5] = "Saturday";
            dias2[6] = "Sunday";

            Console.WriteLine(dias1[5]);
            Console.WriteLine(dias2[3]);
            
            /////////////////////////////////////////////////////////////

            string[] nombres = { "Ana", "Carlos", "Elena", "David", "Sofía" };

            // Recorrer el array con un bucle for
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("Conozco a alguien llamado " + nombres[i]);
            }
            
            //////////////////////////////////////////////////////////////

            int[] myList = { 1, 9, 3, 8, 5, 7 };

            // Recorrer la lista e imprimir el doble de cada número
            for (int i = 0; i < myList.Length; i++)
            {
                Console.WriteLine(myList[i] * 2);
            }
        }
    }
}