using System;
using System.Collections.Generic;


bool EsAnagrama(string palabra1, string palabra2)
{
    if (palabra1 == palabra2 || palabra1.Length != palabra2.Length) return false;

    List<char> letras1 = new List<char>();
    List<char> letras2 = new List<char>();
    for (int i = 0; i < palabra1.Length; i++)
    {
        letras1.Add(palabra1[i]);
        letras2.Add(palabra2[i]);
    }

    foreach (char letra in letras1)
    {
        if (!letras2.Contains(letra)) return false;
    }

    foreach (char letra in letras2)
    {
        if (!letras1.Contains(letra)) return false;
    }
    
    return true;
}

Console.WriteLine(EsAnagrama("hola", "holl"));
Console.WriteLine(EsAnagrama("casa", "sacaa"));
