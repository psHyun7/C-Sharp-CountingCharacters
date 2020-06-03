using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                "Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. " +
                "Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, " +
                "non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. " +
                "Donec nec velit non ligula efficitur luctus.";

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            Console.WriteLine("Enter a string you want the number of characters to be counted: ");
            text = Console.ReadLine();
            text = Regex.Replace(text, "[^A-Za-z0-9]", "");
            text = text.ToUpper();

            foreach (char c in text)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c] += 1;
                } else
                {
                    charCount[c] = 1;
                }
            }
            
            foreach (KeyValuePair<char, int> chars in charCount) {
                Console.WriteLine($"{chars.Key}: {chars.Value}");
            }
        }
    }
}
