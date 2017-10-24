using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class Survival : SkillBase, ISkill
    {
        public Survival() : base(new TextOf("Survival"),new WisdomAttribute()) { }
    }
}