using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    ////To find given word is anagram or not
    //public class Anagram
    //{
    //    public bool Are_Anagram(string str1,string str2)
    //    {
    //        if(str1 .Length!=str2.Length)
    //        {
    //            return false;
    //        }
    //        char[] charstr1 = str1.ToLower() .ToCharArray();
    //        char[] charstr2 = str2.ToLower() .ToCharArray();
    //        Array.Sort(charstr1);
    //        Array.Sort(charstr2);
    //        for(int i=0; i < charstr1.Length; i++)
    //        {
    //            if(charstr1[i].ToString()!=charstr2[i].ToString())
    //            {
    //                return false;
    //            }
    //        }
    //        return true;
    //    }
    //}
    //internal class Program
    //{

    //    static void Main(string[] args)
    //    {
    //        string str1, str2;
    //        Console.WriteLine("Enter the First String");
    //        str1=Convert.ToString(Console.ReadLine());
    //        Console.WriteLine("Enter the Second String");
    //        str2 = Convert.ToString(Console.ReadLine());
    //        Anagram anagram = new Anagram();
    //        if(anagram.Are_Anagram(str1,str2)==true)
    //        {
    //            Console.WriteLine("Both String are Anagram");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Both Strin are not Anagram");
    //        }

    //    }
    //}
}
