using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class Deception : SkillBase, ISkill
    {
        public Deception() : this(new CharismaAttribute()) { }
        public Deception(CharismaAttribute charismaAttribute) : base(new TextObj("Deception"), charismaAttribute) { }
    }
}
