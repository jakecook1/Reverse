using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = args.Length > 0 ? args[0] : "No args passed";
            new Reverse(text).Start();
        }
    }
}
