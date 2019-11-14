using Character.Attributes;
using Character.Display;

namespace Character.Physical.Skills
{
    public class Intimidation : SkillBase, ISkill
    {
        public Intimidation() : this(new CharismaAttribute()) { }
        public Intimidation(CharismaAttribute charismaAttribute, bool activateSkill = false) : base(new TextObj("Intimidation"), charismaAttribute,activateSkill) { }
    }
}
