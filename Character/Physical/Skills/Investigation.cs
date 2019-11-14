using Character.Attributes;
using Character.Display;

namespace Character.Physical.Skills
{
    public class Investigation : SkillBase, ISkill
    {
        public Investigation() : this( new IntellegenceAttribute()) { }
        public Investigation(IntellegenceAttribute intellegenceAttribute, bool activateSkill = false) : base(new TextObj("Investigation"), intellegenceAttribute,activateSkill) { }
    }
}
