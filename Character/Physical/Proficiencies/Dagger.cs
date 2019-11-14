using Character.Display;

namespace Character.Physical.Proficiencies
{
    public class Dagger : ProficiencyBase, IProficiency, IEquateableProficiency
    {
        public Dagger():base(new TextObj("Dagger")){}

        public ITextObj Name() => ProficiencyName;
    }
}