using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modulo3
{
    public static int modulo(int x)
    {
        return x % 3;
    }

    public static int[] modulos(int[] xs)
    {
        int[] result = new int[xs.Length];
        for (int i = 0; i < xs.Length; i++)
        {
            result[i] = modulo(xs[i]);
        }

        return result;
    }
}
