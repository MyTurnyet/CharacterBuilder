using System.Text;
using Character.Display;

namespace Character.Physical.Proficiencies
{
    public interface IProficiency
    {
        ITextObj Name();
        //void AddJsonToStringbuilder(StringBuilder stringBuilder);
        void AddJsonToStringbuilder(StringBuilder stringBuilder);
    }
}