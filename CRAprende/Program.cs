// Calculadora simple

using CRAprende;

Console.WriteLine("Esta es una calculadora simple.");

Calculadora calculadora = new Calculadora();

bool continuar = true;
while (continuar)
{
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
        continue;
    }

    Console.WriteLine($"El resultado de la operación es: {resultado}.");

    Console.Write("Desea realizar otra operación? (S, N): ");
    string respuesta = Console.ReadLine().ToUpper();

    if (respuesta != "S")
    {
        continuar = false;
    }
}
