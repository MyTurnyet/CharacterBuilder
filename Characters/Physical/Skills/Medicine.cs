using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class Medicine : SkillBase, ISkill
    {
        public Medicine() : this( new WisdomAttribute()) { }
        public Medicine(WisdomAttribute wisdomAttribute, bool activateSkill = false) : base(new TextObj("Medicine"),wisdomAttribute,activateSkill) { }
    }
}
