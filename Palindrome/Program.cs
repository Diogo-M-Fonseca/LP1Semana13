using System;
using System.Runtime.CompilerServices;

namespace Palindrome
{
    public class Program
    {
        private static void Main(string[] args)
        {

        }
        private bool IsPalindrome(string s)
            {
                if (s == null)
                {
                    throw new ArgumentNullException(nameof(s));
                }

                if (s.Length < 2)
                {
                    return true;
                }
            
            }
    }
}
