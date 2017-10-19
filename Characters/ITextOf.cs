using System.Text;

namespace Characters
{
    public interface ITextOf
    {
        void AddToStringBuilder(StringBuilder stringBuilder);
        bool Equals(object obj);
    }
}