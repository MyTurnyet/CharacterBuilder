using Character.Display;

namespace Character.Physical.Proficiencies
{
    public class Battleaxe : ProficiencyBase, IProficiency, IEquateableProficiency
    {
        public Battleaxe():base(new TextObj("Battleaxe")){}

        public ITextObj Name() => ProficiencyName;
    }
}