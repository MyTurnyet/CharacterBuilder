using Character.Display;

namespace Character.Physical.Proficiencies
{
    public class MediumArmor : ProficiencyBase, IProficiency, IEquateableProficiency
    {
        public MediumArmor():base(new TextObj("Medium Armor")){}

        public ITextObj Name() => ProficiencyName;
    }
}