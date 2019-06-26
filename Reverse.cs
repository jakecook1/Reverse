using System;
using Reverse.Helpers;

namespace Reverse
{
    public class Reverse
    {
        string _text;

        public Reverse(string text)
        {
            _text = text;
        }

        public void Start()
        {
            _text.Print();
            _text.Reverse();
        }
    }
}