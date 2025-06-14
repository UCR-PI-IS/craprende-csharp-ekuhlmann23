using CRAprende;

// Calculadora simple
CalculadoraCientifica calculadora = new CalculadoraCientifica();
DummyLecturaEscritura dummyLecturaEscritura = new();
ServicioLecturaEscritura servicioLecturaEscritura = new();
IServicioEscritura servicioEscritura = servicioLecturaEscritura;
IServicioLectura servicioLectura = servicioLecturaEscritura;

servicioEscritura.EscribirLinea("Esta es una calculadora simple.");

bool continuar = true;
// Ciclos (ciclo while)
while (continuar)
{
    servicioEscritura.Escribir("Por favor digite el primer número: ");
    double? numero1 = servicioLectura.LeerDecimal();
    if (numero1 is null)
    {
        servicioEscritura.EscribirLinea("El formato del número digitado es inválido. Por favor, intente de nuevo.");
        continue;
    }

    servicioEscritura.Escribir("Por favor digite el segundo número: ");
    double? numero2 = servicioLectura.LeerDecimal();
    if (numero2 is null)
    {
        servicioEscritura.EscribirLinea("El formato del número digitado es inválido. Por favor, intente de nuevo.");
        continue;
    }

    // Control de flujo
    servicioEscritura.Escribir("Por favor seleccione una operación (+, -, *, /, !, C): ");
    string operacion = servicioLectura.LeerTexto();
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
        servicioEscritura.EscribirLinea($"Operación {operacion} es inválida.");
        continue;
    }

    servicioEscritura.EscribirLinea($"El resultado de la operación es: {resultado}.");

    servicioEscritura.Escribir("Desea realizar otra operación? (S, N): ");
    string respuesta = servicioLectura.LeerTexto().ToUpper();

    if (respuesta != "S")
    {
        continuar = false;
    }
}
