using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class Athletics : SkillBase, ISkill
    {
        public Athletics() : base(new TextObj("Athletics"), new StrengthAttribute()) { }
    }
}
