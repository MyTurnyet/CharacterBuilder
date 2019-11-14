using Character.Display;

namespace Character.Physical.Proficiencies
{
    public class LightArmor : ProficiencyBase, IProficiency, IEquateableProficiency
    {
        public LightArmor():base(new TextObj("Light Armor")){}

        public ITextObj Name() => ProficiencyName;
    }
}