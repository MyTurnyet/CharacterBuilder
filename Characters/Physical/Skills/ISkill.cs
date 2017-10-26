using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public interface ISkill
    {
        bool Equals(object obj);
        ITextObj Name();
        ICharacterAttribute BaseAttribute();
        IAttributeScore SkillBonus();
    }
}