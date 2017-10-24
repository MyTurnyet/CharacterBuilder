using System.Text;

namespace Characters.Display
{
    public interface ITextObj
    {
        bool Equals(object obj);
      
    }

    public interface ITextObjAppendable
    {
        ITextObjAppendable Append(ITextObj textObjAppend);
        ITextObjAppendable Append(ITextObjAppendable textObjAppend);
    }
}