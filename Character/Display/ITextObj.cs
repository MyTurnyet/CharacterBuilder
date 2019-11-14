using System.Text;

namespace Character.Display
{
    public interface ITextObj
    {
        bool Equals(object obj);
      ITextObj Append(ITextObj textObjAppend);
        void AddToStringBuilder(StringBuilder stringBuilder);
    }
}