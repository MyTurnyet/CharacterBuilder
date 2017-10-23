using System.Text;

namespace Characters.Display
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public class TextOf : ITextOf

    {
        private readonly string _text;

        public TextOf() : this(string.Empty) { }
        public TextOf(int value) : this(value.ToString()) { }
        public TextOf(StringBuilder stringBuilder) : this(stringBuilder.ToString()){}
        public TextOf(TextOf textOfToCopy) : this(textOfToCopy._text){}
        public TextOf(string text)
        {
            _text = text;
        }
        public override bool Equals(object obj) => Equals((TextOf)obj);
        private bool Equals(TextOf other) => other._text == _text;
        public void AddToStringBuilder(StringBuilder stringBuilder) => stringBuilder.Append(_text);
    }
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
}
