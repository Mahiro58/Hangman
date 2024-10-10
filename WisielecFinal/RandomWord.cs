using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WisielecFinal
{
    internal class RandomWord
    {
        public string GetRandomWord()
        {
            List<string> words = new List<string>()
            {
                "WROCŁAW", "LUBLIN", "WARSZAWA", "RZESZÓW", "POZNAŃ", "SZCZECIN", "GDAŃSK", "KRAKÓW", "BYDGOSZCZ", "TORUŃ", "SOSNOWIEC", "KATOWICE", "SOPOT"
            };

            Random random = new Random();
            int id = random.Next(words.Count);
            string randomWord = words[id];

            return randomWord;
        }
    }
}
