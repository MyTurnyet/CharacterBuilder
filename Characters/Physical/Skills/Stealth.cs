using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class Stealth : SkillBase, ISkill
    {
        public Stealth() : this(new DexterityAttribute()) { }
        public Stealth(DexterityAttribute dexterityAttribute, bool activateSkill = false) : base(new TextObj("Stealth"), dexterityAttribute, activateSkill) { }
    }
}
