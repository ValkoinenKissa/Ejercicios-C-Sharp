/*
 * 2.-Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y luego calcule
 * y emita por pantalla la media final(sumar las 3 y dividir entre 3)
 */

Console.WriteLine("Bienvenido a la calculadora de notas, a continuacón introduce las notas de los examenes para" +
                  " calcular la media final");

double nota1, nota2, nota3, notaMedia;

Console.WriteLine("Introduce la nota del primer examen: ");
nota1 = double.Parse(Console.ReadLine());
Console.WriteLine("Introduce la nota del segundo examen: ");
nota2 = double.Parse(Console.ReadLine());
Console.WriteLine("Introduce la nota del tercer examen: ");
nota3 = double.Parse(Console.ReadLine());

notaMedia = (nota1 + nota2 + nota3) / 3;

Console.WriteLine("La nota media final del alumno es: " + notaMedia);