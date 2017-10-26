using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class Persuasion : SkillBase, ISkill
    {
        public Persuasion() : this(new CharismaAttribute()) { }
        public Persuasion(CharismaAttribute charismaAttribute) : base(new TextObj("Persuasion"), charismaAttribute) { }
    }
}
