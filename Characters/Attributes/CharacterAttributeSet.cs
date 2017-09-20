using System.Collections.Generic;
using System.Linq;

namespace Characters.Attributes
{
    public class CharacterAttributeSet : ICharacterAttributeSet
    {
        public CharacterAttributeSet()
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
        public ICharacterAttribute MatchesName(ICharacterAttributeName attributeName) => GetAttributeFromName(attributeName);
        private ICharacterAttribute GetAttributeFromName(ICharacterAttributeName name) => _attributes.First(arrib => arrib.MatchesName(name));
        private ICharacterAttribute CharacterDefaultAttribute(ICharacterAttributeName attributeName) => new CharacterAttribute(attributeName, new CharacterAttributeScore(0));

    }
}
