﻿using System.Collections.Generic;
using Characters.Attributes;
using Characters.Classes;
using Characters.Physical;
using Characters.Physical.Proficiencies;
using Characters.Races;

namespace Characters
{
    public class CharacterSheet : ICharacterSheet
    {
        private readonly ICharacterClass _characterClass;
        private readonly ICharacterRace _race;
        private readonly IAttributeSet _attributeSet;
        public CharacterSheet() : this(new Fighter(), new Human(), new AttributeSet()) { }
        public CharacterSheet(ICharacterClass characterClass, ICharacterRace race) : this(characterClass, race, new AttributeSet()) { }
        
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
        public IHitPoints HitPoints()
        {
            return (HitPoints)_characterClass.HitDie().MaxHitPoints() + (HitPoints)_attributeSet.Constitution().BonusHitPoints() + (HitPoints)_race.BonusHitPoints();
        }

        public List<IProficiency> Proficiencies()
        {
            List<IProficiency> proficiencies = new List<IProficiency>();
            proficiencies.AddRange(_characterClass.Proficiencies());
            proficiencies.AddRange(_race.Proficiencies());
            return proficiencies;
        }

        public ITextOf StatsList()
        {
            return new TextOf("Test Stats");
        }
    }
}
