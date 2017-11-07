using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class Athletics : SkillBase, ISkill
    {
        public Athletics() : this(new StrengthAttribute()) { }
        public Athletics(StrengthAttribute strengthAttribute, bool activateSkill = false) : base(new TextObj("Athletics"), strengthAttribute,activateSkill) { }
    }
}
