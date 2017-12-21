using System.Text;
using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public interface IProficiency
    {
        ITextObj Name();
        //void AddJsonToStringbuilder(StringBuilder stringBuilder);
        void AddJsonToStringbuilder(StringBuilder stringBuilder);
    }
}