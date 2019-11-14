using Character.Display;

namespace Character.Physical.Proficiencies
{
    public class Handaxe : ProficiencyBase, IProficiency, IEquateableProficiency
    {
        public Handaxe():base(new TextObj("Handaxe")){}

        public ITextObj Name() => ProficiencyName;
    }
}