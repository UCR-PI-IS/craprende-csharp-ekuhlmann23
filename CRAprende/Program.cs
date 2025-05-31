// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World - CR Aprende!");

int numeroEntero = 10;

Console.WriteLine($"El valor del número entero es: {numeroEntero} {{numeroEntero}}.");

numeroEntero = 20;

Console.WriteLine($"El valor del número entero es: {numeroEntero} {{numeroEntero}}.");

// Variable: Memoria para almacenar un valor. Tiene un tipo de dato y un identificador.
string miVariableDeTexto = "Hola Mundo";
double unMedio = 0.5;
bool christianDiceLaVerdad = true;
char letra = 'a';
char símbolo = '?';

// Operadores / Operaciones
// Entero
int número1 = 5;
int número2 = 3;

int suma = número1 + número2; // 8
int resta = número1 - número2; // 2
int multiplicación = número1 * número2; // 15
int división = número1 / número2; // 1

Console.WriteLine($"Resultados: Suma = {suma}, Resta = {resta}, Multiplicación = {multiplicación}, División = {división}");

// Double (decimal)
double decimal1 = 5.2;
double decimal2 = 2.7;

double sumaDecimal = decimal1 + decimal2;
double restaDecimal = decimal1 - decimal2;
double multiplicaciónDecimal = decimal1 * decimal2;
double divisiónDecimal = decimal1 / decimal2;

Console.WriteLine($"Resultados Decimales: Suma = {sumaDecimal}, Resta = {restaDecimal}, Multiplicación = {multiplicaciónDecimal}, División = {divisiónDecimal}");

// String (texto)
string saludo = "Hola";
string nombre = "Erik";

string mensaje = saludo + " " + nombre; // Concatenación

Console.WriteLine($"Mensaje: {mensaje}.");
Console.WriteLine("Mensaje: " + mensaje + ".");

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

