using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class AnimalHandling : SkillBase, ISkill
    {
        public AnimalHandling() : base(new TextObj("Animal Handling"), new WisdomAttribute()) { }
    }
}