using Characters.Races;

namespace Characters.Attributes
{
    public interface ICharacterAttribute
    {
        bool Equals(object obj);
        int GetHashCode();
        bool MatchesName(IAttributeName attributeName);
        AttributeScore Score();
        void ApplyRacialBonus(CharacterRace human);
        void Set(AttributeScore expectedScore);
    }
}