using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraningCodeWars.Licao
{
    public class KataDivisors
    {
        //Minha solução
        //public static int[] Divisors(int n)
        //{
        //    List<int> dividersList = new List<int>();
        //    for (int i = 2; i < n; i++)
        //    {
        //        if ( n % i == 0)
        //        {
        //            dividersList.Add(i);
        //        }
        //    }

        //    return dividersList.ToArray();
        //}

        //Melhor solucção que achei no site
        public static int[] Divisors(int n)
        {
            List<int> sample = new List<int>() { };
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    sample.Add(i);
                    sample.Add(n / i);
                }
            }
            sample = sample.OrderBy(x => x).ToList();
            return sample.Count() > 0 ? sample.Distinct().ToArray() : null;
        }
    }
}
