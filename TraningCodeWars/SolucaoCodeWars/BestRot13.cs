using System;
using System.Linq;

namespace TraningCodeWars.SolucaoCodeWars
{
    public class BestRot13
    {
        public static string Transform(string message)
        {
            return String.Join("", message.Select(x => char.IsLetter(x) ? (x >= 65 && x <= 77) || (x >= 97 && x <= 109) ? (char)(x + 13) : (char)(x - 13) : x));
        } 
    }
}
