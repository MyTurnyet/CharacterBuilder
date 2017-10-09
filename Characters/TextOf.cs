using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public class TextOf

    {
        private readonly string _text;

        public TextOf(string text)
        {
            _text = text;
        }

        public override bool Equals(object obj) => Equals((TextOf)obj);

        private bool Equals(TextOf other) => other._text == _text;
    }
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
}
