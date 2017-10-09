using System.Collections.Generic;
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

        public CharacterSheet() : this(new Fighter(), new Human(), new AttributeSet()) { }

        public ICharacterAttribute Attribute(IAttributeName attributeName)
        {
            ICharacterAttribute attribute = _attributeSet.MatchesName(attributeName);
            attribute.ApplyRacialBonus((CharacterRace)_race);
            return attribute;
        }
        public HitPoints HitPoints() => _characterClass.HitDie().MaxHitPoints() + _attributeSet.Constitution().BonusHitPoints() + _race.BonusHitPoints();
        public List<Proficiency> Proficiencies()
        {
            List<Proficiency> proficiencies = new List<Proficiency>();
            proficiencies.AddRange(_characterClass.Proficiencies());
            proficiencies.AddRange(_race.Proficiencies());
            return proficiencies;
        }
    }
}
