using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class Warhammer : EquatableProficiency,IProficiency
    {
        public Warhammer() : base(new TextOf("Warhammer")){}
        public ITextOf Name => ProficiencyName;
    }
}