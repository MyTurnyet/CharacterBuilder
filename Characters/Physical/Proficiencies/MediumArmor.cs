using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class MediumArmor : EquatableProficiency, IProficiency
    {
        public MediumArmor():base(new TextObj("Medium Armor"))
        {
            
        }
        public ITextObj Name =>ProficiencyName;
    }
}