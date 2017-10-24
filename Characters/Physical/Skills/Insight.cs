using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class Insight : SkillBase, ISkill
    {
        public Insight() : base(new TextObj("Insight"), new WisdomAttribute()) { }
    }
}
