using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    public class ToAnagram
    {
        public void To_find_anagram(string first, string second)
        {
            if (first.Length != second.Length)
            {
                Console.WriteLine("Both string are not anagram");
            }
            char[] first1 = first.ToLower().ToCharArray();
            char[] second1 = second.ToLower().ToCharArray();
            Array.Sort(first1);
            Array.Sort(second1);
            for (int i = 0; i < first1.Length; i++)
            {
                if (first1[i].ToString() != second1[i].ToString())
                {
                    Console.WriteLine("Both string are not anagram");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Both string are anagram\n{first}  {second}");
        }

    }
    public class Program
    {
        static void Main()
        {
            string firststring, secondstring;
            Console.WriteLine("Enter the first string");
            firststring = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the second string");
            secondstring = Convert.ToString(Console.ReadLine());
            ToAnagram anagram = new ToAnagram();
            anagram.To_find_anagram(firststring, secondstring);

        }
    }
}



