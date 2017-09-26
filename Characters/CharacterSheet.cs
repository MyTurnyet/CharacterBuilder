using Characters.Attributes;
using Characters.Classes;
using Characters.Physical;
using Characters.Races;

namespace Characters
{
    public class CharacterSheet : ICharacterSheet
    {
        private readonly ICharacterClass _characterClass;
        private readonly ICharacterRace _race;
        private readonly IAttributeSet _attributeSet;

        public CharacterSheet(ICharacterClass characterClass, ICharacterRace race, IAttributeSet attributeSet)
        {
            _characterClass = characterClass;
            _race = race;
            _attributeSet = attributeSet;
            
        }
        public ICharacterAttribute Attribute(IAttributeName attributeName)
        {
            ICharacterAttribute attribute = _attributeSet.MatchesName(attributeName);
            attribute.ApplyRacialBonus((CharacterRace)_race);
            return attribute;
        }
        public HitPoints HitPoints() => _characterClass.HitDie().MaxHitPoints() + _attributeSet.Constitution().BonusHitPoints();
    }
}
