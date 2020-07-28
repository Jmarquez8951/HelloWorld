using System;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan", "Bird", "Dog" };

            static int SyllableCount(string word)
            {
                word = word.ToLower().Trim();
                bool lastWasVowel = true;
                char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
                int count = 0;

                //a string is an IEnumerable<char>; convenient.
                foreach (var c in word)
                {
                    if (vowels.Contains(c))
                    {
                        if (!lastWasVowel)
                            count++;
                        lastWasVowel = true;
                    }
                    else
                        lastWasVowel = false;
                }

                if ((word.EndsWith("e") || (word.EndsWith("es") || word.EndsWith("ed")))
                      && !word.EndsWith("le"))
                    count--;

                return count;
            }

            foreach (var animal in animals)
            {
                if (SyllableCount(animal) >= 2)
                {
                    Console.WriteLine(animal);
                }
            }

            // Make this have options
            Console.WriteLine("Howdy Y'all!!");
            Console.ReadKey();
        }
    }
}
