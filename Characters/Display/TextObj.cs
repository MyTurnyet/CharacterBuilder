using System.Text;

namespace Characters.Display
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public class TextObjBase : ITextObj

    {
        protected readonly string _text;
        protected TextObjBase(string text)
        {
            _text = text;
        }
        public override bool Equals(object obj) => Equals((TextObj)obj);
        public ITextObjAppendable Append(ITextObj textObjAppend)
        {
            return new TextObj(_text + ((TextObj)textObjAppend)._text);
        }

        public ITextObjAppendable Append(ITextObjAppendable textObjAppend)
        {
            return new TextObj(_text + ((TextObj)textObjAppend)._text);
        }

        private bool Equals(TextObj other) => other._text == _text;
        public void AddToStringBuilder(StringBuilder stringBuilder) => stringBuilder.Append(_text);
    }

    public class TextObj : TextObjBase, ITextObjAppendable
    {
        public TextObj(int value) : this(value.ToString()) { }
        public TextObj(StringBuilder stringBuilder) : this(stringBuilder.ToString()){ }
        public TextObj(TextObj textObjToCopy) : this(textObjToCopy._text){ }
        public TextObj() : this(string.Empty) { }
        public TextObj(string text) : base(text) { }
    }
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
}
