﻿using Characters.Physical;
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
        public override int GetHashCode() => _name.GetHashCode();
        public bool MatchesName(IAttributeName attributeName) => attributeName.Equals(_name);
        public AttributeScore Score() => BaseScore() + (AttributeScore)_racialAttributeAdjustment;
        private AttributeScore BaseScore() => (AttributeScore)_value;
        public void ApplyRacialBonus(CharacterRace race) => _racialAttributeAdjustment = race.RacialAttributeAdjustment(this);
        public void Set(AttributeScore score) => _value = score;
        public AttributeScore Bonus() => new AttributeScore(Score().Bonus());
        public HitPoints BonusHitPoints() => new HitPoints(Score().Bonus());
    }
}
