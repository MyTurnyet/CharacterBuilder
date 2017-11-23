namespace Characters.Display
{
    public class TextObjBase : ITextObj

    {
        protected readonly string Text;
        protected TextObjBase(string text)
        {
            Text = text;
        }
        public override bool Equals(object obj) => Equals((TextObjBase)obj);
        private bool Equals(TextObjBase other) => Equals(Text.GetHashCode(), other.Text.GetHashCode());
        public override int GetHashCode() => Text.GetHashCode();
        public ITextObj Append(ITextObj textObjAppend) => new TextObjBase(Text + ((TextObjBase)textObjAppend).Text);
        
    }
}