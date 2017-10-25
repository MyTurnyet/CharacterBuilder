using System.Text;

namespace Characters.Display
{
    public class TextObjBase : ITextObj

    {
        protected readonly string _text;
        protected TextObjBase(string text)
        {
            _text = text;
        }
        public override bool Equals(object obj) => Equals((TextObjBase)obj);
        private bool Equals(TextObjBase other) => Equals(_text.GetHashCode(), other._text.GetHashCode());
        public override int GetHashCode() => _text.GetHashCode();
        public ITextObj Append(ITextObj textObjAppend) => new TextObjBase(_text + ((TextObjBase)textObjAppend)._text);
        public void AddToStringBuilder(StringBuilder stringBuilder) => stringBuilder.Append(_text);
    }
}