using System;

namespace CRAprende;

/// <summary>
/// Esta clase extiende la funcionalidad de la clase <see cref="Calculadora"/> para incluir operaciones científicas
/// como el cálculo de factoriales y combinaciones.
/// </summary>
public class CalculadoraCientifica : Calculadora
{
    /// <summary>
    /// Calcula el factorial de un número entero no negativo.
    /// </summary>
    /// <param name="n">Número al cual se le calcula el factorial.</param>
    /// <returns>Retorna el factorial de <paramref name="n"/>.</returns>
    public double Factorial(uint n)
    {
        // n! = (n-1)! * n
        // 0! = 1

        // factorial(n) = factorial(n - 1) * n
        // factorial(0) = 1

        // factorial(5) = factorial(4) * 5 = 1 * 2 * 3 * 4 * 5
        // factorial(4) = factorial(3) * 4 = 1 * 2 * 3 * 4
        // factorial(3) = factorial(2) * 3
        // factorial(2) = factorial(1) * 2
        // factorial(1) = factorial(0) * 1
        // factorial(0) = 1

        // Sustituir:
        // factorial(1) = 1 * 1 = 1
        // factorial(2) = 1 * 2 = 2
        // factorial(3) = 2 * 3 = 6

        // Ciclo for
        double resultado = 1;
        for (uint i = 1; i <= n; i++)
        {
            resultado = resultado * i;
        }

        return resultado;
    }

    /// <summary>
    /// Calcula el número de combinaciones posibles de n elementos tomados r a la vez.
    /// La fórmula es: C(n, r) = n! / (r! * (n - r)!).
    /// </summary>
    /// <param name="n">El tamaño total del conjunto de elementos.</param>
    /// <param name="r">Cantidad de elementos tomados a la vez.</param>
    /// <returns>Combinaciones posibles <paramref name="n"/> elementos tomados <paramref name="r"/> a la vez.</returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public double Combinaciones(uint n, uint r)
    {
        if (r > n)
        {
            throw new ArgumentOutOfRangeException(nameof(r), r, "r debe ser menor o igual a n.");
        }

        return Factorial(n) / (Factorial(r) * Factorial(n - r));
    }
}
