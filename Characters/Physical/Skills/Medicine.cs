using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class Medicine : SkillBase, ISkill
    {
        public Medicine() : this( new WisdomAttribute()) { }
        public Medicine(WisdomAttribute wisdomAttribute) : base(new TextObj("Medicine"),wisdomAttribute) { }
    }
}
