using System.Collections.Generic;
using Characters.Attributes;

namespace Characters.Physical.Skills
{
    public class BaseSkillSet
    {
        private readonly IAttributeSet _attributeSet;
        public BaseSkillSet(IAttributeSet attributeSet)
        {
            _attributeSet = attributeSet;
        }
        public List<ISkill> Skills() => new List<ISkill>()
        {
            new Acrobatics((DexterityAttribute) _attributeSet.MatchesName(CharacterAttributeName.Dexterity)),
            new SleightOfHand((DexterityAttribute) _attributeSet.MatchesName(CharacterAttributeName.Dexterity)),
            new Stealth((DexterityAttribute) _attributeSet.MatchesName(CharacterAttributeName.Dexterity)),
            new Deception((CharismaAttribute) _attributeSet.MatchesName(CharacterAttributeName.Charisma)),
            new Intimidation((CharismaAttribute) _attributeSet.MatchesName(CharacterAttributeName.Charisma)),
            new Performance((CharismaAttribute) _attributeSet.MatchesName(CharacterAttributeName.Charisma)),
            new Persuasion((CharismaAttribute) _attributeSet.MatchesName(CharacterAttributeName.Charisma)),
            new Arcana((IntellegenceAttribute) _attributeSet.MatchesName(CharacterAttributeName.Intelligence)),
            new History((IntellegenceAttribute) _attributeSet.MatchesName(CharacterAttributeName.Intelligence)),
            new Religion((IntellegenceAttribute) _attributeSet.MatchesName(CharacterAttributeName.Intelligence)),
            new Investigation((IntellegenceAttribute) _attributeSet.MatchesName(CharacterAttributeName.Intelligence)),
            new Nature((IntellegenceAttribute) _attributeSet.MatchesName(CharacterAttributeName.Intelligence)),
            new Athletics((StrengthAttribute) _attributeSet.MatchesName(CharacterAttributeName.Strength)),
            new AnimalHandling((WisdomAttribute) _attributeSet.MatchesName(CharacterAttributeName.Wisdom)),
            new Insight((WisdomAttribute) _attributeSet.MatchesName(CharacterAttributeName.Wisdom)),
            new Medicine((WisdomAttribute) _attributeSet.MatchesName(CharacterAttributeName.Wisdom)),
            new Perception((WisdomAttribute) _attributeSet.MatchesName(CharacterAttributeName.Wisdom)),
            new Survival((WisdomAttribute) _attributeSet.MatchesName(CharacterAttributeName.Wisdom))
        };
    }
}
