using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class Deception : SkillBase, ISkill
    {
        public Deception() : base(new TextObj("Deception"),new CharismaAttribute()) { }
    }
}
