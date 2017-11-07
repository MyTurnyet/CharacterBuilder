using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class Nature : SkillBase, ISkill
    {
        public Nature() : this(new IntellegenceAttribute()) { }
        public Nature(IntellegenceAttribute intellegenceAttribute, bool activateSkill = false) : base(new TextObj("Nature"), intellegenceAttribute,activateSkill) { }
    }
}
