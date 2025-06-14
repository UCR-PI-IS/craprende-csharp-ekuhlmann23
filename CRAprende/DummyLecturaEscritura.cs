using System;

namespace CRAprende;

public class DummyLecturaEscritura : IServicioLectura, IServicioEscritura
{
    public void Escribir(string mensaje)
    {
    }

    public void EscribirLinea(string mensaje)
    {
    }

    public double? LeerDecimal()
    {
        return 2.3;
    }

    public string LeerTexto()
    {
        return "+";
    }
}
