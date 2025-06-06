using System;

namespace CRAprende;

public class ServicioLecturaEscritura
{
    public void ImprimirLineaEnPantalla(string mensaje)
    {
        Console.WriteLine(mensaje);
    }

    public void ImprimirEnPantalla(string mensaje)
    {
        Console.Write(mensaje);
    }

    public double? LeerDecimalDePantalla()
    {
        string entrada = Console.ReadLine()
            ?? string.Empty;
        try
        {
            double numeroDecimal = double.Parse(entrada);
            return numeroDecimal;
        }
        catch (FormatException)
        {
            return null;
        }
    }

    public string LeerTextoDePantalla()
    {
        return Console.ReadLine() ?? string.Empty;
    }
}
