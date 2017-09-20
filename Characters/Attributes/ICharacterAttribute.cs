using Characters.Races;

namespace Characters.Attributes
{
    public interface ICharacterAttribute
    {
        bool Equals(object obj);
        int GetHashCode();
        bool MatchesName(ICharacterAttributeName attributeName);
        CharacterAttributeScore Score();
        void ApplyRacialBonus(CharacterRace human);
        void Set(CharacterAttributeScore expectedScore);
    }
}