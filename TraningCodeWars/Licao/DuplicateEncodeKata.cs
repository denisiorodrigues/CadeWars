using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraningCodeWars.Licao
{
    public class DuplicateEncodeKata
    {
        public static string DuplicateEncode(string word)
        {
            var newWord = string.Empty;
            foreach (var item in word.ToLower())
            {
                if (MoreOneCharacter(item, word.ToLower()))
                {
                    newWord += ")";
                }
                else
                {
                    newWord += "(";
                }
            }


            return newWord;
        }

        public static bool MoreOneCharacter(char character, string word)
        {
            return word.Count(x => x.Equals(character)) > 1;
        }

        //Melhor solução do site
        public static string DuplicateEncode2(string word)
        {
            return new string(word.ToLower()
                .Select(
                            ch => word.ToLower()
                            .Count(innerCh => ch == innerCh) == 1 ? '(' : ')').ToArray()
                        );
        }
    }
}
