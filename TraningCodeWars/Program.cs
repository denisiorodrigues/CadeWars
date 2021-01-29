using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraningCodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultado = Kata.UniqueInOrder("AAAABBBCCDAABBB");
            var resultado2 = Kata.UniqueInOrder("ABBCcAD");
            int [] arrayNumeros = { 1, 2, 3, 3};
            var resultado3 = Kata.UniqueInOrder(arrayNumeros);
        }
    }
}
