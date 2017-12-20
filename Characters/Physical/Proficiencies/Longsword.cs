using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class Longsword : ProficiencyBase, IProficiency, IEquateableProficiency
    {
        public Longsword():base(new TextObj("Longsword")){}

        public ITextObj Name() => ProficiencyName;
    }
}