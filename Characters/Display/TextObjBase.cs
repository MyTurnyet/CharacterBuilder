using System.Text;

namespace Characters.Display
{
    public abstract class TextObjBase : ITextObj

    {
        protected readonly string Text;
        protected TextObjBase(string text)
        {
            Text = text;
        }
        public override bool Equals(object obj) => Equals((TextObj)obj);
        protected bool Equals(TextObjBase other) => string.Equals(Text, other.Text);
        public override int GetHashCode() => (Text != null ? Text.GetHashCode() : 0);
        private bool Equals(TextObj other) => other.Text == Text;
        public void AddToStringBuilder(StringBuilder stringBuilder) => stringBuilder.Append(Text);
    }
}