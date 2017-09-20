using System.Collections.Generic;
using System.Linq;
using Characters.Attributes;
using Characters.Classes;
using Characters.Races;

namespace Characters
{
    public class CharacterSheet : ICharacterSheet
    {
        private readonly ICharacterClass _characterClass;
        private readonly ICharacterRace _race;
        private readonly List<ICharacterAttribute> _attributes = new List<ICharacterAttribute>();
        private readonly IAttributeSet _attributeSet;

        public CharacterSheet(ICharacterClass characterClass, ICharacterRace race, IAttributeSet attributeSet)
        {
            _characterClass = characterClass;
            _race = race;
            _attributeSet = attributeSet;
            
        }

        public void AddAttribute(ICharacterAttribute attribute)
        {
            RemoveExistingAttribute(attribute);
            _attributes.Add(attribute);

        }
        public ICharacterAttribute Attribute(IAttributeName attributeName)
        {
            ICharacterAttribute attribute = _attributeSet.MatchesName(attributeName);
            attribute.ApplyRacialBonus((CharacterRace)_race);
            return attribute;
        }

        private void RemoveExistingAttribute(ICharacterAttribute attribute)
        {
            if (!_attributes.Any(attr => attr.Equals(attribute))) return;
            _attributes.Remove(_attributes.First(attr => attr.Equals(attribute)));
        }

    }
}
