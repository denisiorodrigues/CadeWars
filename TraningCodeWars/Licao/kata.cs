using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
    {
        var array = iterable.ToArray();
        string resultado = string.Empty;
        List<T> lista = new List<T>();

        for (var item = 0; item < array.Length; item++)
        {
            if (item > 0 && array[item].Equals(array[item - 1]))
                continue;

            lista.Add(array[item]);
        }

        return lista.AsEnumerable<T>();
    }
}