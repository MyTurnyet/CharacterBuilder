using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class BrewersSupplies : EquatableProficiency, IProficiency
    {
        public BrewersSupplies():base(new TextOf("Brewer's Supplies"))
        {
            
        }
        public ITextOf Name =>ProficiencyName;
    }
}