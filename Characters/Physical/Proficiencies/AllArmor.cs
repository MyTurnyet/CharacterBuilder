using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class AllArmor : EquatableProficiency, IProficiency
    {
        public AllArmor():base(new TextOf("All Armor")){}
        public ITextOf Name => ProficiencyName;
    }
}