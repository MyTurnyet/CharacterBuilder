using Characters.Attributes;
using Characters.Display;
using Characters.Physical;
using Characters.Races;

namespace CharacterTests
{
    public class FakeAttribute : ICharacterAttribute
    {
        public FakeAttribute()
        {
        }

        public bool MatchesName(IAttributeName attributeName) => true;
        public IAttributeScore Score() => new AttributeScore(10);
        public void ApplyRacialBonus(ICharacterRace race){}
        public void Set(IAttributeScore expectedScore){}
        public IAttributeScore Bonus() => new AttributeScore(0);
        public IHitPoints BonusHitPoints() => new HitPoints(0);
        public ITextObj DisplayText() => new TextObj("Fake");
    }
}