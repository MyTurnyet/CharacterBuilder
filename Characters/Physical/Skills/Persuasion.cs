using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class Persuasion : SkillBase, ISkill
    {
        public Persuasion() : base(new TextObj("Persuasion"), new CharismaAttribute()) { }
    }
}
