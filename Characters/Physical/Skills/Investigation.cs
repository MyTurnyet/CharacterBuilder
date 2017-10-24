using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class Investigation : SkillBase, ISkill
    {
        public Investigation() : base(new TextOf("Investigation"), new IntellegenceAttribute()) { }
    }
}
