using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class AnimalHandling : SkillBase, ISkill
    {
        public AnimalHandling() : this(new WisdomAttribute()) { }
        public AnimalHandling(WisdomAttribute wisdomAttribute) : base(new TextObj("Animal Handling"), wisdomAttribute) { }
    }
}