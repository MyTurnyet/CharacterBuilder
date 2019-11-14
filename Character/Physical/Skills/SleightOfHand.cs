using Character.Attributes;
using Character.Display;

namespace Character.Physical.Skills
{
    public class SleightOfHand : SkillBase, ISkill
    {
        public SleightOfHand() : this(new DexterityAttribute()) { }
        public SleightOfHand(DexterityAttribute dexterityAttribute, bool activateSkill = false) : base(new TextObj("Sleight Of Hand"), dexterityAttribute, activateSkill) { }
    }
}
