using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class AllArmor : ProficiencyBase, IProficiency, IEquateableProficiency
    {
        public AllArmor():base(new TextObj("All Armor")){}

        public ITextObj Name()
        {
            return ProficiencyName;
        }
    }
}