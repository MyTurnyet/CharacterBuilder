using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class Medicine : SkillBase, ISkill
    {
        public Medicine() : base(new TextOf("Medicine"),new WisdomAttribute()) { }
    }
}
