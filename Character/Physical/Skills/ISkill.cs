using Character.Attributes;
using Character.Display;

namespace Character.Physical.Skills
{
    public interface ISkill
    {
        bool Equals(object obj);
        ITextObj Name();
        ICharacterAttribute BaseAttribute();
        IAttributeScore SkillBonus();
    }
}