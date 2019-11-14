using System.Text;
using Character.Attributes;
using Character.Display;
using Character.Physical;
using Character.Races;

namespace Character.Tests
{
    public class FakeAttribute : ICharacterAttribute
    {
        public bool MatchesName(IAttributeName attributeName) => true;
        public IAttributeScore Score() => new AttributeScore(10);
        public void ApplyRacialBonus(ICharacterRace race){}
        public void Set(IAttributeScore expectedScore){}
        public IAttributeScore Bonus() => new AttributeScore(0);
        public IHitPoints BonusHitPoints() => new HitPoints(0);
        public ITextObj DisplayText() => new TextObj("Fake");
        public void AddJsonToStringbuilder(StringBuilder stringBuilder)
        {
            stringBuilder.Append("{Strength:10}");
        }
    }
}