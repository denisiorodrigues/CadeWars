using System;
using System.Linq;

namespace TraningCodeWars.SolucaoCodeWars
{
    public class DnaStrand
    {
        public static string MakeComplement(string dna)
        {
            return string.Concat(dna.Select(GetComplement));
        }

        public static char GetComplement(char symbol)
        {
            switch (symbol)
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
