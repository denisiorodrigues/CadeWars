using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraningCodeWars.Licao
{
    public class DnaStrand
    { 
        public static string MakeComplement(string dna)
        {
            return string.Concat(dna.Select(TrocarLetra));
        }

        private static char TrocarLetra(char letra)
        {
            switch (letra)
            {
                case 'A':
                    return 'T';
                case 'T':
                    return 'A';
                case 'C':
                    return 'G';
                case 'G':
                    return 'C';
                default:
                    throw new ArgumentException();
            }
        }
    }
}
