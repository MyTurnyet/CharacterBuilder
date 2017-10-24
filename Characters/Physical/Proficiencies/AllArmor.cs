using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class AllArmor : EquatableProficiency, IProficiency
    {
        public AllArmor():base(new TextObj("All Armor")){}
        public ITextObj Name => ProficiencyName;
    }
}