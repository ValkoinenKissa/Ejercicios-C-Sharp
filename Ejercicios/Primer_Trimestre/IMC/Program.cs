// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information

double altura, peso, imc;

Console.WriteLine("Bienvenido al programa para calcular tu IMC \n");

Console.WriteLine("Ingrese una altura en metros (se permiten decimales): ");
altura = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese un peso en KG: ");
peso = double.Parse(Console.ReadLine());

imc = peso / (altura * altura);

if (imc >= 18.5 && imc <=24.9)
    
{
    Console.WriteLine("Tu IMC esta en un rango normal: " + "("+ imc + ")");
}
else if (imc < 18.5)
{
    Console.WriteLine("Tu peso es deficiente IMC: " + "("+ imc + ")");
}
else
{
    Console.WriteLine("Tienes sobrepeso IMC: " + "("+ imc + ")");
}