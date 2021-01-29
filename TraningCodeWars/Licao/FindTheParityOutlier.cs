using System;
using System.Collections.Generic;
using System.Linq;

namespace TraningCodeWars.Licao
{
    public class FindTheParityOutlier
    {
        public static int Find(int[] integers)
        {
            if (integers.Length < 3) return 0;
            
            var pares = integers.Where(x => x % 2 == 0).ToList();
            if (pares.Count == 1) return pares.FirstOrDefault();
            
            var impares = integers.Where(x => x % 2 != 0).ToList();
            if (impares.Count == 1) return impares.FirstOrDefault();
            
            return 0;
        }
    }
}
