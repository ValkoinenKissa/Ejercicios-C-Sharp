namespace Actividad_Trimestral_3;

public class Ejecutable
{
    static void Main()
    {
        string rutaArchivo = "ficheros/empleados.txt";
        List<Empleados> listaEmpleados = new List<Empleados>();
        try
        {
            if (!File.Exists(rutaArchivo))
            {
                Console.WriteLine("El archivo empleados.txt no existe");
            }
            else
            {
                Console.WriteLine("Bienvenido a la aplicacion, estas son las opciones disponibles: \n");
                int opcion;
                do
                {
                    Console.WriteLine("1. Leer el contenido del fichero y almacenar los datos en una lista de objetos.");
                    Console.WriteLine("2. Mostrar por consola todos los empleados con su información formateada.");
                    Console.WriteLine("3. Calcular y mostrar el salario promedio de todos los empleados.");
                    Console.WriteLine("4. Filtrar y mostrar los empleados cuyo salario sea mayor al promedio.");
                    Console.WriteLine("5. Salir de la aplicacion. \n");
                    Console.WriteLine("Introduce la opcion que quieras ejecutar:");
                    opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            LeerFicheroYCrearObjeto(listaEmpleados, rutaArchivo);
                            break;
                        case 2:
                            MostrarDatosFormateados(listaEmpleados);
                            break;
                        case 3:
                            decimal salaioMedi0 = MostrarSalarioPromedio(listaEmpleados);
                            if (salaioMedi0 > 0)
                            {
                                Console.WriteLine("El salario medio de todos los empleados es: " + salaioMedi0);
                                Console.WriteLine();
                            }
                            break;
                        case 4:
                            MostrarEmpleadosSalarioMayor(listaEmpleados);
                            break;
                        case 5:
                            Console.WriteLine("Abandonando el programa");
                            break;
                        default:
                            Console.WriteLine("La opcion introducida es incorrecta");
                            break;
                    }
                } while (opcion != 5);
            }
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine("El archivo empleados.txt no existe: " + e.Message);
        }

        catch (FormatException)
        {
            Console.WriteLine("El archivo contiene datos inválidos.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió un error: {ex.Message}");
        }
    }

    //1. Leer el contenido del fichero y almacenar los datos en una lista de objetos.
    static void LeerFicheroYCrearObjeto(List<Empleados> listaEmpleados, string rutaArchivo)
    {
        foreach (string linea in File.ReadLines(rutaArchivo))
        {
            string[] campos = linea.Split(':');
            if (campos.Length == 5)
            {
                Empleados emp = new Empleados(Convert.ToInt32(campos[0]),
                    campos[1],
                    Convert.ToInt32(campos[2]),
                    campos[3],
                    Convert.ToDecimal(campos[4])
                );

                listaEmpleados.Add(emp);
            }
        }

        Console.WriteLine("Se ha leido correctamente el fichero y los objetos se han almacenado correctamnete en" +
                          " la lista de empleados. \n");
    }

    static void MostrarDatosFormateados(List<Empleados> listaEmpleados)
    {
        if (listaEmpleados.Count == 0)
        {
            Console.WriteLine("No se puede mostar nada por que la lista esta vacia \n");
        }
        else
        {
            foreach (Empleados empleado in listaEmpleados)
            {
                Console.WriteLine(empleado);
            }

            Console.WriteLine();
        }
    }

    //Calcular y mostrar el salario promedio de todos los empleados.

    static decimal MostrarSalarioPromedio(List<Empleados> listaEmpleados)
    {
        decimal resultado = 0;
        if (!listaEmpleados.Any())
        {
            Console.WriteLine("No se puede mostar nada por que la lista esta vacia \n");
        }
        else
        {
            decimal acumSalario = 0;
            int numEmpleados = listaEmpleados.Count;

            foreach (Empleados empleado in listaEmpleados)
            {
                acumSalario += empleado.Salario;
            }

            resultado = acumSalario / numEmpleados;
        }

        return resultado;
    }

    //4. Filtrar y mostrar los empleados cuyo salario sea mayor al promedio."

    static void MostrarEmpleadosSalarioMayor(List<Empleados> listaEmpleados)
    {
        if (!listaEmpleados.Any())
        {
            Console.WriteLine("No se puede mostar nada por que la lista esta vacia \n");
        }
        else
        {
            decimal salarioPromedio = MostrarSalarioPromedio(listaEmpleados);
            Console.WriteLine("Mostrando los empleados con salarios superiores a la media: ");
            foreach (Empleados empleado in listaEmpleados)
            {
                if (empleado.Salario > salarioPromedio)
                {
                    Console.WriteLine(empleado);
                    Console.WriteLine();
                }
            }
        }
    }
}