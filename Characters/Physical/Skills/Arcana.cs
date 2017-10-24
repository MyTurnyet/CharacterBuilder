using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class Arcana : SkillBase, ISkill
    {
        public Arcana() : base(new TextOf("Arcana"), new IntellegenceAttribute()) { }
    }
}
