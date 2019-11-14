using Character.Attributes;
using Character.Display;

namespace Character.Physical.Skills
{
    public class Arcana : SkillBase, ISkill
    {
        public Arcana() : this( new IntellegenceAttribute()) { }
        public Arcana(IntellegenceAttribute intellegenceAttribute, bool activateSkill = false) : base(new TextObj("Arcana"), intellegenceAttribute,activateSkill) { }
    }
}
