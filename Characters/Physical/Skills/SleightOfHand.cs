using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class SleightOfHand : SkillBase, ISkill
    {
        public SleightOfHand() : this(new DexterityAttribute()) { }
        public SleightOfHand(DexterityAttribute dexterityAttribute) : base(new TextObj("Sleight Of Hand"), dexterityAttribute) { }
    }
}
