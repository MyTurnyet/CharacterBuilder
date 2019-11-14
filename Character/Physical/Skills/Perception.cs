using Character.Attributes;
using Character.Display;

namespace Character.Physical.Skills
{
    public class Perception : SkillBase, ISkill
    {
        public Perception() : this( new WisdomAttribute()) { }
        public Perception(WisdomAttribute wisdomAttribute, bool activateSkill = false) : base(new TextObj("Perception"), wisdomAttribute,activateSkill) { }
    }
}
