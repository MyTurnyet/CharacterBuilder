using Character.Display;

namespace Character.Physical.Proficiencies
{
    public class Shortsword : ProficiencyBase, IProficiency, IEquateableProficiency
    {
        public Shortsword():base(new TextObj("Shortsword")){}

        public ITextObj Name() => ProficiencyName;
    }
}