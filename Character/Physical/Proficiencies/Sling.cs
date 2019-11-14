using Character.Display;

namespace Character.Physical.Proficiencies
{
    public class Sling : ProficiencyBase, IProficiency, IEquateableProficiency
    {
        public Sling():base(new TextObj("Sling")){}

        public ITextObj Name() => ProficiencyName;
    }
}