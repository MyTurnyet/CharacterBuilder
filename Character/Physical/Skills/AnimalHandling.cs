using Character.Attributes;
using Character.Display;

namespace Character.Physical.Skills
{
    public class AnimalHandling : SkillBase, ISkill
    {
        public AnimalHandling() : this(new WisdomAttribute()) { }
        public AnimalHandling(WisdomAttribute wisdomAttribute, bool activateSkill = false) : base(new TextObj("Animal Handling"), wisdomAttribute,activateSkill) { }
    }
}