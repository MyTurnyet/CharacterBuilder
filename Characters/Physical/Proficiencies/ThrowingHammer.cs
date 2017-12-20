using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class ThrowingHammer : ProficiencyBase, IProficiency, IEquateableProficiency
    {
        public ThrowingHammer():base(new TextObj("Throwing Hammer")){}

        public ITextObj Name() => ProficiencyName;
    }
}