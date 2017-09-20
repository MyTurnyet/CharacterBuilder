using Characters.Attributes;

namespace Characters.Races
{
    public interface ICharacterRace
    {
        bool Equals(object obj);
        int GetHashCode();
        ICharacterAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute);
        Speed Speed();
    }
}