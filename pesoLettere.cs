using System;
using System.Collections.Generic;

public static class PesoLettere
{
    public static int Pesa(string input)
    {
        //            a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q,  r, s, t, u, v, w, x, y, z
        int[] pesi = {1, 3, 3, 2, 1, 4, 2, 4, 1, 8, 5, 1, 3, 1, 1, 3, 10, 1, 1, 1, 1, 4, 4, 8, 4, 10 };
        int peso = 0;

        foreach (char c in input.ToLower()) peso += pesi[(int) c - 97];

        return peso;
    }
}