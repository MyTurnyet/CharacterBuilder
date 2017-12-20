using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class Shortbow : ProficiencyBase, IProficiency, IEquateableProficiency
    {
        public Shortbow():base(new TextObj("Shortbow")){}

        public ITextObj Name() => ProficiencyName;
    }
}