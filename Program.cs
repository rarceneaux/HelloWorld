using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*HelloWorld*/
            Console.WriteLine("Howdy Y'all");
            Console.ReadKey();

            /*Animals */
            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

            //foreach (var animal in animals)
            //{
            //    Console.WriteLine(animal);
            //    Console.ReadKey();
            //}
            /*2 or more syllables*/
            var vowels = new [] {'a','e','i','o','u','y'};

            foreach (var animal in animals)
            {
                var numberOfVowels = 0;
                foreach (var animalLetters in animal)
                {
                    foreach (var vowel in vowels)
                    {
                        if (vowel == animalLetters)
                        {
                            numberOfVowels++;
                        }
                    }
                }
                if (numberOfVowels >= 2)
                {
                    Console.WriteLine(animal);
                    Console.ReadKey();
                }
            }
        }
    }
}
