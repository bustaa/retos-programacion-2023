using System;
using System.Collections.Generic;

void Fibonacci(int n)
{
    List<long> listaNums = new List<long>();

    for (int i = 0; i <= n; i++)
    {
        if (i < 2)
        {
            listaNums.Add(i);
        }
        else
        {
            int ultimaPos = listaNums.Count - 1;
            listaNums.Add(listaNums[ultimaPos] + listaNums[ultimaPos - 1]);
        }
    }

    foreach (long num in listaNums)
    {
        Console.WriteLine(num);
    }
}

Fibonacci(50);