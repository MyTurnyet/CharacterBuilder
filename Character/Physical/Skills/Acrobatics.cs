using Character.Attributes;
using Character.Display;

namespace Character.Physical.Skills
{
    public class Acrobatics:SkillBase,ISkill
    {
        public Acrobatics():this(new DexterityAttribute()){}
        public Acrobatics(DexterityAttribute dexterityAttribute, bool activateSkill = false) :base(new TextObj("Acrobatics"),dexterityAttribute,activateSkill){}
    }
}
