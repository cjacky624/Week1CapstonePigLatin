using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_18_19Week1CapstonePigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Please enter any word");
                string word = Console.ReadLine().ToLower();
                int vowelIndex = word.IndexOfAny(new char[] { 'a', 'e', 'i', 'o', 'u' });
                Console.WriteLine(ToPigLatin(word, vowelIndex));
                //Console.WriteLine("Would you like to translate another word? Yes or No");

                run = Continue();
            }
        }

        public static bool Continue()
        {
            //Console.WriteLine("Do you wish to continue? (yes/no)");
            Console.WriteLine("Would you like to translate another word? (Yes/No)");
            string userInput = Console.ReadLine().ToLower();
            bool goOn;
            if (userInput == "yes")
            {
                goOn = true;
            }
            else if (userInput == "no")
            {
                Console.WriteLine("Okay, bye! Thanks for playing.");
                goOn = false;
            }
            else
            {
                Console.WriteLine("Invalid input, please try again.");
                goOn = Continue();
            }
            return goOn;
        }


        private static string ToPigLatin(string word, int vowelIndex)
        {
            string vowels = "aeiou";

            int i = 0;
            if (word[0] == vowels[0] || word[0] == vowels[1] || word[0] == vowels[2] || word[0] == vowels[3] || word[0] == vowels[4])
            {
                word = word + "way";
            }
            else if (word[0] != vowels[0] && word[0] != vowels[1] && word[0] != vowels[2] && word[0] != vowels[3] && word[0] != vowels[4])
            {
                for (; i < vowelIndex; i++)
                {
                    word = word + word[i];
                }
                word = word.Substring(i);
                word = word + "ay";
            }
            return word;
        }
    }
}