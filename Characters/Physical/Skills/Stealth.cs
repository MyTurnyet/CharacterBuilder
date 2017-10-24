using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class Stealth : SkillBase, ISkill
    {
        public Stealth() : base(new TextObj("Stealth"), new DexterityAttribute()) { }
    }
}
