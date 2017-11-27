using System.Text;

namespace Characters.Display
{
    public interface ITextObj
    {
        bool Equals(object obj);
      ITextObj Append(ITextObj textObjAppend);
        void AddToStringBuilder(StringBuilder stringBuilder);
    }
}