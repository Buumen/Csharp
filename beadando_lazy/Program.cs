using System;
using System.Text.RegularExpressions;


namespace beadando_lazy
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchText = "";
            string searchInText = "";
            Lazy<RegexClass> lazyRegexObject = new Lazy<RegexClass>(() => new RegexClass(searchText, searchInText));

            Console.WriteLine("IsValueCreated = {0}", lazyRegexObject.IsValueCreated);

            Console.WriteLine("Adjon meg egy tetszőleges szöveget:\n");
             searchInText = Console.ReadLine();
            Console.WriteLine("Keresendő szöveg:\n");
             searchText = Console.ReadLine();


            lazyRegexObject.Value.keres();
            Console.WriteLine("IsValueCreated = {0}", lazyRegexObject.IsValueCreated);

           
            




        }
    }
}
