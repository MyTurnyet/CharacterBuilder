using System.Collections.Generic;
using System.Linq;

namespace Characters.Attributes
{
    public class AttributeSet : IAttributeSet
    {
        public AttributeSet()
        {
            _attributes.Add(new StrengthAttribute());
            _attributes.Add(new DexterityAttribute());
            _attributes.Add(new ConstitutionAttribute());
            _attributes.Add(new IntellegenceAttribute());
            _attributes.Add(new WisdomAttribute());
            _attributes.Add(new CharismaAttribute());

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

    }
}
