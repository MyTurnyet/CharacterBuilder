using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class Persuasion : SkillBase, ISkill
    {
        public Persuasion() : base(new TextOf("Persuasion"), new CharismaAttribute()) { }
    }
}
