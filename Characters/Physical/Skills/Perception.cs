using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class Perception : SkillBase, ISkill
    {
        public Perception() : base(new TextOf("Perception"), new WisdomAttribute()) { }
    }
}
