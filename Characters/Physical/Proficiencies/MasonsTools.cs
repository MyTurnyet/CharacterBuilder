using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class MasonsTools : ProficiencyBase, IProficiency, IEquateableProficiency
    {
        public MasonsTools():base(new TextObj("Mason's Tools")){}

        public ITextObj Name() => ProficiencyName;
    }
}