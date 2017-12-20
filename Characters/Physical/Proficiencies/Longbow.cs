using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class Longbow : ProficiencyBase, IProficiency, IEquateableProficiency
    {
        public Longbow():base(new TextObj("Longbow")){}

        public ITextObj Name() => ProficiencyName;
    }
}