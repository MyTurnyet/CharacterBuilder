using System.Text;

namespace Characters.Display
{
    public interface ITextOf
    {
        void AddToStringBuilder(StringBuilder stringBuilder);
        bool Equals(object obj);
    }
}