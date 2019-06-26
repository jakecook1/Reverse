using System;

namespace Reverse.Helpers
{
    public static class MyExtensions
    {
        public static void Print(this string str)
        {
            Console.WriteLine(string.Format("Original: \"{0}\"", str));
        }

        public static void Reverse(this string str)
        {
            var charactors = str.ToCharArray();
            var reversed = string.Empty;
            
            for (var i = charactors.Length - 1; i >= 0; i--)
            {
                reversed += charactors[i];
            }

            Console.WriteLine(string.Format("Reversed: \"{0}\"", reversed));
        }
    }
}