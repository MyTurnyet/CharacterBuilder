using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class Perception : SkillBase, ISkill
    {
        public Perception() : base(new TextObj("Perception"), new WisdomAttribute()) { }
    }
}
