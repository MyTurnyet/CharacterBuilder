using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class SleightOfHand : SkillBase, ISkill
    {
        public SleightOfHand() : base(new TextObj("Sleight Of Hand"), new DexterityAttribute()) { }
    }
}
