using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class LightArmor : EquatableProficiency, IProficiency
    {
        public LightArmor():base(new TextObj("Light Armor"))
        {
            
        }
        public ITextObj Name => ProficiencyName;
    }
}