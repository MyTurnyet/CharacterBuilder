using Character.Display;

namespace Character.Physical.Proficiencies
{
    public class BrewersSupplies : ProficiencyBase, IProficiency, IEquateableProficiency
    {
        public BrewersSupplies():base(new TextObj("Brewer's Supplies")){}

        public ITextObj Name() => ProficiencyName;
    }
}