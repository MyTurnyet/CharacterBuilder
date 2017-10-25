using System.Text;
using Characters.Display;
using Characters.Physical;
using Characters.Races;

namespace Characters.Attributes
{
    public class CharacterAttribute : ICharacterAttribute
    {
        private readonly IAttributeName _name;
        private IAttributeScore _value;
        private IAttributeScore _racialAttributeAdjustment = new AttributeScore(0);

        public CharacterAttribute(IAttributeName name, IAttributeScore value)
        {
            _name = name;
            _value = value;
        }

        public override bool Equals(object obj) => (CharacterAttribute)obj != null && ((CharacterAttribute)obj)._name == _name;
        public bool MatchesName(IAttributeName attributeName) => attributeName.Equals(_name);
        public IAttributeScore Score() => (AttributeScore)BaseScore().Add(_racialAttributeAdjustment);
        public void ApplyRacialBonus(ICharacterRace race) => _racialAttributeAdjustment = race.RacialAttributeAdjustment(this);
        public void Set(IAttributeScore expectedScore) => _value = expectedScore;
        private IAttributeScore BaseScore() => (AttributeScore)_value;
        public IAttributeScore Bonus() => new AttributeScore(Score().Bonus());
        public IHitPoints BonusHitPoints() => new HitPoints(Score().Bonus());

        public ITextObj DisplayText()
        {
            StringBuilder stringBuilder = new StringBuilder();
            _name.Name().AddToStringBuilder(stringBuilder);
            stringBuilder.Append(": ");
            Score().AsText().AddToStringBuilder(stringBuilder);
            return new TextObj(stringBuilder);
        }
    }
}
