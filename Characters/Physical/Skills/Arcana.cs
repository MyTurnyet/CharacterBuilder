using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class Arcana : SkillBase, ISkill
    {
        public Arcana() : base(new TextObj("Arcana"), new IntellegenceAttribute()) { }
    }
}
