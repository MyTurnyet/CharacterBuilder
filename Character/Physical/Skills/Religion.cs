using Character.Attributes;
using Character.Display;

namespace Character.Physical.Skills
{
    public class Religion : SkillBase, ISkill
    {
        public Religion() : this(new IntellegenceAttribute()) { }
        public Religion(IntellegenceAttribute intellegenceAttribute, bool activateSkill = false) : base(new TextObj("Religion"), intellegenceAttribute,activateSkill) { }
    }
}
