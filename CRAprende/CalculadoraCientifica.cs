using System;

namespace CRAprende;

public class CalculadoraCientifica : Calculadora
{
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

    public double Combinaciones(uint n, uint r)
    {
        if (r > n)
        {
            throw new ArgumentOutOfRangeException(nameof(r), r, "r debe ser menor o igual a n.");
        }

        return Factorial(n) / (Factorial(r) * Factorial(n - r));
    }
}
