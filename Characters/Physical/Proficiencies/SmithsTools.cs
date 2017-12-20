using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class SmithsTools : ProficiencyBase, IProficiency, IEquateableProficiency
    {
        public SmithsTools():base(new TextObj("Smith's Tools")){}

        public ITextObj Name() => ProficiencyName;
    }
}