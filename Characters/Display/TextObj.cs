namespace Characters.Display
{
    public class TextObj : TextObjBase
    {
        public TextObj(int value) : this(value.ToString()) { }
        public TextObj(TextObj textObjToCopy) : this(textObjToCopy.Text){ }
        public TextObj() : this(string.Empty) { }
        public TextObj(string text) : base(text) { }

       
    }
}
