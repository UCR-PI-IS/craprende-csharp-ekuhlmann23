using System.ComponentModel;
using ModelContextProtocol.Server;
using System.Collections.Generic; // Añadir para List<Profesor>

namespace CRAprende;

[McpServerToolType]
public static class Herramientas
{
    [McpServerTool, Description("Calcula el factorial de un número.")]
    public static double Factorial(
        CalculadoraCientifica calculadoraCientifica,
        [Description("Número para calcular el factorial.")] uint número)
    {
        return calculadoraCientifica.Factorial(número);
    }

    [McpServerTool, Description("Calcula el número de combinaciones posibles de n elementos tomados r a la vez.")]
    public static double Combinaciones(
        CalculadoraCientifica calculadoraCientifica,
        [Description("Número total de elementos.")] uint n,
        [Description("Número de elementos a tomar.")] uint r)
    {
        return calculadoraCientifica.Combinaciones(n, r);
    }

    [McpServerTool, Description("Obtiene el directorio de profesores.")]
    public static List<Profesor> ObtenerDirectorioProfesores(
        ServicioDirectorioProfesores servicioDirectorio)
    {
        return servicioDirectorio.ObtenerTodosLosProfesores();
    }
}
