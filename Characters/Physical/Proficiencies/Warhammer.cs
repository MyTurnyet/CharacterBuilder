using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class Warhammer : EquatableProficiency,IProficiency
    {
        public Warhammer() : base(new TextObj("Warhammer")){}
        public ITextObj Name => ProficiencyName;
    }
}