using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class Intimidation : SkillBase, ISkill
    {
        public Intimidation() : base(new TextOf("Intimidation"), new CharismaAttribute()) { }
    }
}
