using Character.Display;

namespace Character.Physical.Proficiencies
{
    public class Longsword : ProficiencyBase, IProficiency, IEquateableProficiency
    {
        public Longsword():base(new TextObj("Longsword")){}

        public ITextObj Name() => ProficiencyName;
    }
}