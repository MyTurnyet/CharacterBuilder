using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class Performance : SkillBase, ISkill
    {
        public Performance() : this(new CharismaAttribute()) { }
        public Performance(CharismaAttribute charismaAttribute, bool activateSkill = false) : base(new TextObj("Performance"), charismaAttribute,activateSkill) { }
    }
}
