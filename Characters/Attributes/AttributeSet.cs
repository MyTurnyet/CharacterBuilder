using System.Collections.Generic;
using System.Linq;

namespace Characters.Attributes
{
    public class AttributeSet : IAttributeSet
    {
        public AttributeSet()
        {
            _attributes.Add(CharacterDefaultAttribute(CharacterAttributeName.Strength));
            _attributes.Add(CharacterDefaultAttribute(CharacterAttributeName.Dexterity));
            _attributes.Add(CharacterDefaultAttribute(CharacterAttributeName.Constitution));
            _attributes.Add(CharacterDefaultAttribute(CharacterAttributeName.Intelligence));
            _attributes.Add(CharacterDefaultAttribute(CharacterAttributeName.Wisdom));
            _attributes.Add(CharacterDefaultAttribute(CharacterAttributeName.Charisma));

        }
        private readonly List<ICharacterAttribute> _attributes = new List<ICharacterAttribute>();
        public ICharacterAttribute Dexterity() => GetAttributeFromName(CharacterAttributeName.Dexterity);
        public ICharacterAttribute Strength() => GetAttributeFromName(CharacterAttributeName.Strength);
        public ICharacterAttribute Constitution() => GetAttributeFromName(CharacterAttributeName.Constitution);
        public ICharacterAttribute Intellegence() => GetAttributeFromName(CharacterAttributeName.Intelligence);
        public ICharacterAttribute Wisdom() => GetAttributeFromName(CharacterAttributeName.Wisdom);
        public ICharacterAttribute Charisma() => GetAttributeFromName(CharacterAttributeName.Charisma);
        public ICharacterAttribute MatchesName(IAttributeName attributeName) => GetAttributeFromName(attributeName);
        private ICharacterAttribute GetAttributeFromName(IAttributeName name) => _attributes.First(arrib => arrib.MatchesName(name));
        private ICharacterAttribute CharacterDefaultAttribute(IAttributeName attributeName) => new CharacterAttribute(attributeName, new AttributeScore(0));

    }
}
