using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class Religion : SkillBase, ISkill
    {
        public Religion() : base(new TextObj("Religion"), new IntellegenceAttribute()) { }
    }
}
