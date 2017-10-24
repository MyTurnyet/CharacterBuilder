using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class SleightOfHand : SkillBase, ISkill
    {
        public SleightOfHand() : base(new TextOf("Sleight Of Hand"), new DexterityAttribute()) { }
    }
}
