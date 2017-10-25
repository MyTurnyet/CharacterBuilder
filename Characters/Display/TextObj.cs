using System.Text;

namespace Characters.Display
{
    public class TextObj : TextObjBase
    {
        public TextObj(int value) : this(value.ToString()) { }
        public TextObj(StringBuilder stringBuilder) : this(stringBuilder.ToString()){ }
        public TextObj(TextObj textObjToCopy) : this(textObjToCopy._text){ }
        public TextObj() : this(string.Empty) { }
        public TextObj(string text) : base(text) { }
    }
}
