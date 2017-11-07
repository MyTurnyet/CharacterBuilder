using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class History : SkillBase, ISkill
    {
        public History() :this(new IntellegenceAttribute()) { }
        public History(IntellegenceAttribute intellegenceAttribute, bool activateSkill = false) : base(new TextObj("History"), intellegenceAttribute,activateSkill) { }
    }
}
