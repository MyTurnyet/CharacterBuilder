using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class BrewersSupplies : EquatableProficiency, IProficiency
    {
        public BrewersSupplies():base(new TextObj("Brewer's Supplies"))
        {
            
        }
        public ITextObj Name =>ProficiencyName;
    }
}