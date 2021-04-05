using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace beadando_lazy
{
    class RegexClass
    {
        public string SearchString { get; set; }
        public string SearchIn { get; set; }

        public RegexClass(string searchString, string searchIn)
        {
            
            SearchString = searchString;
            SearchIn = searchIn;
        }

        
       
        public void keres()
        {
            
            var minta1 = @"\b" + SearchString + "\b";
            Regex rx = new Regex(minta1);

            Console.WriteLine("Szöveg:\n {0}", SearchIn);
            Console.WriteLine("Keresendő szöveg: {0}", SearchString);

            MatchCollection matches = Regex.Matches(SearchIn, @"\b" + SearchString + @"\b");


            Console.WriteLine("Találatok száma: {0}\n",
                              matches.Count
                              );

            // Report on each match.
            foreach (Match match in matches)
            {
                Console.WriteLine("Pozíció:" + match.Index);
            }
        }
    }
}
