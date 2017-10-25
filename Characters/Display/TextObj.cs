using System.Text;

namespace Characters.Display
{
    public class TextObj : TextObjBase, ITextObjAppendable
    {
        public TextObj(int value) : this(value.ToString()) { }
        public TextObj(StringBuilder stringBuilder) : this(stringBuilder.ToString()){ }
        public TextObj(TextObj textObjToCopy) : this(textObjToCopy.Text){ }
        public TextObj() : this(string.Empty) { }
        public TextObj(string text) : base(text) { }
        public ITextObj Append(ITextObj textObjAppend) => AppendTextObject((TextObjBase)textObjAppend);
        public ITextObj Append(ITextObjAppendable textObjAppend) => AppendTextObject((TextObjBase)textObjAppend);
        private TextObj AppendTextObject(ITextObj textObjAppend) => new TextObj(Text + ((TextObj)textObjAppend).Text);
    }
}
