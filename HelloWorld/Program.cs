using System;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            var name = Console.ReadLine();

            Console.WriteLine($"How you doing {name}.");

            Console.WriteLine("What is your favorite color?");
            var favColor = Console.ReadLine().ToLower();

            var rand = new Random();
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

            var i = rand.Next(animals.Length);
            var chosenAnimal = animals[i];

            Console.WriteLine($"Would you like to have a {favColor} {chosenAnimal}?");

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

            ConsoleKeyInfo enteredKey;

            do
            {
                enteredKey = Console.ReadKey();
                Console.WriteLine(@$"
                You pressed the {enteredKey.Key.ToString()} key");

            } while (enteredKey.Key != ConsoleKey.Escape);

            string sentence;

            do
            {
                Console.WriteLine("Type in a sentence. Press enter when done.");
                sentence = Console.ReadLine();
                Console.WriteLine($"You entered the sentence: {sentence}");

            } while (sentence != "quit");

            Console.ReadKey();
        }
    }
}
