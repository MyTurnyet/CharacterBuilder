using Characters.Physical;
using Characters.Races;

namespace Characters.Attributes
{
    public interface ICharacterAttribute
    {
        bool Equals(object obj);
        bool MatchesName(IAttributeName attributeName);
        IAttributeScore Score();
        void ApplyRacialBonus(ICharacterRace race);
        void Set(IAttributeScore expectedScore);
        IAttributeScore Bonus();
        IHitPoints BonusHitPoints();
    }
}