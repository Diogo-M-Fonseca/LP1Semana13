using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Palindrome
{
    public class Program
    {
        private static void Main(string[] args)
        {
             foreach (string word in args)
            {
                Console.WriteLine($"{word} -> {IsPalindrome(word)}");
            }
        }
        private static bool IsPalindrome(string s)
        {
            bool Palindrome(string sp)
            {
                char[] array = sp.ToCharArray();
                Array.Reverse(array);
                string reversed = new string(array);

                if (sp == reversed)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }


            if (s.Length < 2)
            {
                return true;
            }
            else
            {
                return Palindrome(s);
            }
                
            
            }
    }
}
