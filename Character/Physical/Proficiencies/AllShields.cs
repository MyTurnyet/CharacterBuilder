using Character.Display;

namespace Character.Physical.Proficiencies
{
    public class AllShields : ProficiencyBase, IProficiency, IEquateableProficiency
    {
        public AllShields():base(new TextObj("All Shields")){}

        public ITextObj Name() => ProficiencyName;
    }
}