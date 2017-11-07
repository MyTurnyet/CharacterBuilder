using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class Survival : SkillBase, ISkill
    {
        public Survival() : this(new WisdomAttribute()) { }
        public Survival(WisdomAttribute wisdomAttribute, bool activateSkill = false) : base(new TextObj("Survival"), wisdomAttribute,activateSkill) { }
    }
}