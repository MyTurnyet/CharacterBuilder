using Character.Display;

namespace Character.Physical.Proficiencies
{
    public class Darts : ProficiencyBase, IProficiency, IEquateableProficiency
    {
        public Darts():base(new TextObj("Darts")){}

        public ITextObj Name() => ProficiencyName;
    }
}