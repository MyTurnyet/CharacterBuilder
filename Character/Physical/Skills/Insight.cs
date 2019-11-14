using Character.Attributes;
using Character.Display;

namespace Character.Physical.Skills
{
    public class Insight : SkillBase, ISkill
    {
        public Insight() : this(new WisdomAttribute()) { }
        public Insight(WisdomAttribute wisdomAttribute, bool activateSkill = false) : base(new TextObj("Insight"), wisdomAttribute,activateSkill) { }
    }
}
