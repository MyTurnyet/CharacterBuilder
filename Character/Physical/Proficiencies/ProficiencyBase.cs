using System.Text;
using Character.Display;

namespace Character.Physical.Proficiencies
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