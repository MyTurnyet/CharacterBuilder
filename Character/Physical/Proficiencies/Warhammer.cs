using Character.Display;

namespace Character.Physical.Proficiencies
{
    public class Warhammer : ProficiencyBase, IProficiency, IEquateableProficiency
    {
        public Warhammer() : base(new TextObj("Warhammer")){}

        public ITextObj Name() => ProficiencyName;
    }
}