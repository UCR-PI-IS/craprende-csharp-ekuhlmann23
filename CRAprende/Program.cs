// Calculadora simple

using CRAprende;

Calculadora calculadora = new Calculadora();

Console.WriteLine("Esta es una calculadora simple.");
Console.Write("Por favor digite el primer número: ");
string entrada1 = Console.ReadLine();
double numero1 = double.Parse(entrada1);

Console.Write("Por favor digite el segundo número: ");
string entrada2 = Console.ReadLine();
double numero2 = double.Parse(entrada2);

// Control de flujo
Console.Write("Por favor seleccione una operación (+, -, *, /): ");
string operacion = Console.ReadLine();
// Condicional
double resultado = 0;
if (operacion == "+")
{
    resultado = calculadora.Sumar(numero1, numero2);
}
else if (operacion == "-")
{
    resultado = calculadora.Restar(numero1, numero2);
}
else if (operacion == "*")
{
    resultado = calculadora.Multiplicar(numero1, numero2);
}
else if (operacion == "/")
{
    resultado = calculadora.Dividir(numero1, numero2); ;
}
else
{
    Console.WriteLine($"Operación {operacion} es inválida.");
}

Console.WriteLine($"El resultado de la operación es: {resultado}.");

