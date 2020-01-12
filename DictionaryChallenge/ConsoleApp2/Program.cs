using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) what's the signature
            var dictionary = new Dictionary<int, string>();
            //2) what's adding the values look like (don't overcomplicate it, just 1-9)
            dictionary.Add(1, "one");
            dictionary.Add(2, "two");
            dictionary.Add(3, "three");
            dictionary.Add(4, "four");
            dictionary.Add(5, "five");
            dictionary.Add(6, "six");
            dictionary.Add(7, "seven");
            dictionary.Add(8, "eight");
            dictionary.Add(9, "nine");
            //3) what's checking for 5 look like?
            //and
            //4) what's the text for 5?
            if (dictionary.ContainsKey(5))
            {
                Console.WriteLine(dictionary[5]);
            }
            else Console.WriteLine("Not found");
            //5) what's checking for 13 look like?
            //and
            //6) what's the text for 13?
            if (dictionary.ContainsKey(13))
            {
                Console.WriteLine(dictionary[13]);
            }
            else Console.WriteLine("Not found");
            //7) how do you set 9 to NEIN
            dictionary[9] = "NEIN";
            //8) how do you remove 5?
            dictionary.Remove(5);

            Console.ReadLine();
        }


    }
}
