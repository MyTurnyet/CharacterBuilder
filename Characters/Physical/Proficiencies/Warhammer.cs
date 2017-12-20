using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class Warhammer : ProficiencyBase, IProficiency, IEquateableProficiency
    {
        public Warhammer() : base(new TextObj("Warhammer")){}

        public ITextObj Name() => ProficiencyName;
    }
}