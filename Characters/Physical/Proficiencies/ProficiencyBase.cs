using System.Text;
using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class ProficiencyBase: EquatableProficiency
    {
        protected ProficiencyBase(ITextObj name) : base(name){}
        public void AddJsonToStringbuilder(StringBuilder stringBuilder)
        {
            ProficiencyName.AddToStringBuilder(stringBuilder);
        }

    }
}