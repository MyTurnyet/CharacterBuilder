using Characters.Physical;
using Characters.Races;

namespace Characters.Attributes
{
    public interface ICharacterAttribute
    {
        bool Equals(object obj);
        bool MatchesName(IAttributeName attributeName);
        AttributeScore Score();
        void ApplyRacialBonus(CharacterRace race);
        void Set(AttributeScore expectedScore);
        AttributeScore Bonus();
        HitPoints BonusHitPoints();
    }
}