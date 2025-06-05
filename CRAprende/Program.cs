// Calculadora simple
Console.WriteLine("Esta es una calculadora simple.");
Console.Write("Por favor digite el primer número: ");
string entrada1 = Console.ReadLine();
long numero1 = long.Parse(entrada1);

Console.Write("Por favor digite el segundo número: ");
string entrada2 = Console.ReadLine();
long numero2 = long.Parse(entrada2);

// Control de flujo
Console.Write("Por favor seleccione una operación (+, -, *, /): ");
string operacion = Console.ReadLine();
// Condicional
double resultado = 0;
if (operacion == "+")
{
    resultado = numero1 + numero2;
}
else if (operacion == "-")
{
    resultado = numero1 - numero2;
}
else if (operacion == "*")
{
    resultado = numero1 * numero2;
}
else if (operacion == "/")
{
    resultado = (double)numero1 / numero2;
}
else
{
    Console.WriteLine($"Operación {operacion} es inválida.");
}

Console.WriteLine($"El resultado de la operación es: {resultado}.");

