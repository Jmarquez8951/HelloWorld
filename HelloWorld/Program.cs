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

            Console.WriteLine("Choose a greeting: Cool, Formal, Yorkshire");
            var userInput = Console.ReadLine().ToLower();

            if (userInput.Contains("cool"))
            {

                Console.WriteLine("Yo what is up!");

            } else if (userInput.Contains("formal"))
            {

                Console.WriteLine("How do you do.");

            } else if (userInput.Contains("yorkshire"))
            {

                Console.WriteLine("Ey up!");

            } else
            {
                Console.WriteLine("Howdy Y'all!!");
            }

            Console.ReadKey();
        }
    }
}
