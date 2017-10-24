using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class History : SkillBase, ISkill
    {
        public History() : base(new TextOf("History"), new IntellegenceAttribute()) { }
    }
}
