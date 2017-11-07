using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class Deception : SkillBase, ISkill
    {
        public Deception() : this(new CharismaAttribute(), false) { }
        public Deception(CharismaAttribute charismaAttribute, bool activateSkill = false) : base(new TextObj("Deception"), charismaAttribute, activateSkill) { }
    }
}
