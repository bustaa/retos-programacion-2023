using System;

bool EsPrimo(int n)
{
    if (n == 0 || n == 1) return false;
    for (int i = 2; i < n; i++)
    {
        if (n % i == 0 && n != 2) return false;
    }
    return true;
}

void ImprimirPrimos(int limInferior, int limSuperior)
{
    for (int i = limInferior; i < limSuperior; i++)
    {
        if (EsPrimo(i)) Console.WriteLine(i);
    }
}

ImprimirPrimos(1, 100)