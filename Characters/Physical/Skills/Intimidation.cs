using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class Intimidation : SkillBase, ISkill
    {
        public Intimidation() : this(new CharismaAttribute()) { }
        public Intimidation(CharismaAttribute charismaAttribute) : base(new TextObj("Intimidation"), charismaAttribute) { }
    }
}
