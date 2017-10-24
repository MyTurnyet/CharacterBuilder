using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class History : SkillBase, ISkill
    {
        public History() : base(new TextObj("History"), new IntellegenceAttribute()) { }
    }
}
