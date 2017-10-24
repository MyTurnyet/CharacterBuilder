using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class Nature : SkillBase, ISkill
    {
        public Nature() : base(new TextObj("Nature"), new IntellegenceAttribute()) { }
    }
}
