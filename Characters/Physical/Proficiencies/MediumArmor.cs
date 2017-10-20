namespace Characters.Physical.Proficiencies
{
    public class MediumArmor : EquatableProficiency, IProficiency
    {
        public MediumArmor():base(new TextOf("Medium Armor"))
        {
            
        }
        public ITextOf Name =>ProficiencyName;
    }
}