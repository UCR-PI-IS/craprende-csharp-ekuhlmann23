// Calculadora simple

using CRAprende;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ModelContextProtocol.Server;
using System.ComponentModel;

var builder = Host.CreateApplicationBuilder(args);
builder.Logging.AddConsole(consoleLogOptions =>
{
    // Configure all logs to go to stderr
    consoleLogOptions.LogToStandardErrorThreshold = LogLevel.Trace;
});

builder.Services.AddSingleton<CalculadoraCientifica>();
builder.Services.AddSingleton<ServicioDirectorioProfesores>(); // Registrar ServicioDirectorioProfesores
builder.Services
    .AddMcpServer()
    .WithStdioServerTransport()
    .WithToolsFromAssembly();

await builder.Build().RunAsync();

Console.WriteLine("Esta es una calculadora simple.");

CalculadoraCientifica calculadora = new CalculadoraCientifica();
ServicioLecturaEscritura lecturaEscritura = new();

bool continuar = true;
// Ciclos (ciclo while)
while (continuar)
{
    lecturaEscritura.ImprimirEnPantalla("Por favor digite el primer número: ");
    double? numero1 = lecturaEscritura.LeerDecimalDePantalla();
    if (numero1 is null)
    {
        lecturaEscritura.ImprimirLineaEnPantalla("El formato del número digitado es inválido. Por favor, intente de nuevo.");
        continue;
    }

    lecturaEscritura.ImprimirEnPantalla("Por favor digite el segundo número: ");
    double? numero2 = lecturaEscritura.LeerDecimalDePantalla();
    if (numero2 is null)
    {
        lecturaEscritura.ImprimirLineaEnPantalla("El formato del número digitado es inválido. Por favor, intente de nuevo.");
        continue;
    }

    // Control de flujo
    lecturaEscritura.ImprimirEnPantalla("Por favor seleccione una operación (+, -, *, /, !, C): ");
    string operacion = lecturaEscritura.LeerTextoDePantalla();
    // Condicional
    double resultado = 0;
    if (operacion == "+")
    {
        resultado = calculadora.Sumar(numero1.Value, numero2.Value);
    }
    else if (operacion == "-")
    {
        resultado = calculadora.Restar(numero1.Value, numero2.Value);
    }
    else if (operacion == "*")
    {
        resultado = calculadora.Multiplicar(numero1.Value, numero2.Value);
    }
    else if (operacion == "/")
    {
        resultado = calculadora.Dividir(numero1.Value, numero2.Value); ;
    }
    else if (operacion == "!")
    {
        resultado = calculadora.Factorial((uint)numero1.Value);
    }
    else if (operacion == "C")
    {
        resultado = calculadora.Combinaciones((uint)numero1.Value, (uint)numero2.Value);
    }
    else
    {
        lecturaEscritura.ImprimirLineaEnPantalla($"Operación {operacion} es inválida.");
        continue;
    }

    lecturaEscritura.ImprimirLineaEnPantalla($"El resultado de la operación es: {resultado}.");

    Console.Write("Desea realizar otra operación? (S, N): ");
    string respuesta = lecturaEscritura.LeerTextoDePantalla().ToUpper();

    if (respuesta != "S")
    {
        continuar = false;
    }
}
