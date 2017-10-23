using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class LightArmor : EquatableProficiency, IProficiency
    {
        public LightArmor():base(new TextOf("Light Armor"))
        {
            
        }
        public ITextOf Name => ProficiencyName;
    }
}