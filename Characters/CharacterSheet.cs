using System.Collections.Generic;
using Characters.Attributes;
using Characters.Classes;
using Characters.Display;
using Characters.Physical;
using Characters.Physical.Proficiencies;
using Characters.Physical.Skills;
using Characters.Races;

namespace Characters
{
    public class CharacterSheet : ICharacterSheet
    {
        private readonly ICharacterClass _characterClass;
        private readonly ICharacterRace _race;
        private readonly IAttributeSet _attributeSet;
        private List<ISkill> _allSkills = new List<ISkill>();
        private readonly List<ISkill> _activatedSkills = new List<ISkill>();
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
        public IHitPoints HitPoints() => (HitPoints)_characterClass.HitDie().MaxHitPoints().Add((HitPoints)_attributeSet.MatchesName(CharacterAttributeName.Constitution).BonusHitPoints()).Add((HitPoints)_race.BonusHitPoints());
        public List<IProficiency> Proficiencies()
        {
            List<IProficiency> proficiencies = new List<IProficiency>();
            proficiencies.AddRange(_characterClass.Proficiencies());
            proficiencies.AddRange(_race.Proficiencies());
            return proficiencies;
        }
        public ITextObj StatsList()
        {
            return _attributeSet.DisplayText();
        }

        public List<ISkill> Skills()
        {
            FillAllSkills();
            foreach (ISkill skill in _allSkills)
            {
                if (_activatedSkills.Contains(skill)) continue;
                _activatedSkills.Add(skill);
            }
            return _activatedSkills;
        }

        private void FillAllSkills()
        {
            _allSkills.Clear();
            _allSkills.Add(new Acrobatics((DexterityAttribute)_attributeSet.MatchesName(CharacterAttributeName.Dexterity)));
            _allSkills.Add(new SleightOfHand((DexterityAttribute)_attributeSet.MatchesName(CharacterAttributeName.Dexterity)));
            _allSkills.Add(new Stealth((DexterityAttribute)_attributeSet.MatchesName(CharacterAttributeName.Dexterity)));
            _allSkills.Add(new Deception((CharismaAttribute)_attributeSet.MatchesName(CharacterAttributeName.Charisma)));
            _allSkills.Add(new Intimidation((CharismaAttribute)_attributeSet.MatchesName(CharacterAttributeName.Charisma)));
            _allSkills.Add(new Performance((CharismaAttribute)_attributeSet.MatchesName(CharacterAttributeName.Charisma)));
            _allSkills.Add(new Persuasion((CharismaAttribute)_attributeSet.MatchesName(CharacterAttributeName.Charisma)));
            _allSkills.Add(new Arcana((IntellegenceAttribute)_attributeSet.MatchesName(CharacterAttributeName.Intelligence)));
            _allSkills.Add(new History((IntellegenceAttribute)_attributeSet.MatchesName(CharacterAttributeName.Intelligence)));
            _allSkills.Add(new Religion((IntellegenceAttribute)_attributeSet.MatchesName(CharacterAttributeName.Intelligence)));
            _allSkills.Add(new Investigation((IntellegenceAttribute)_attributeSet.MatchesName(CharacterAttributeName.Intelligence)));
            _allSkills.Add(new Nature((IntellegenceAttribute)_attributeSet.MatchesName(CharacterAttributeName.Intelligence)));
            _allSkills.Add(new Athletics((StrengthAttribute)_attributeSet.MatchesName(CharacterAttributeName.Strength)));
            _allSkills.Add(new AnimalHandling((WisdomAttribute)_attributeSet.MatchesName(CharacterAttributeName.Wisdom)));
            _allSkills.Add(new Insight((WisdomAttribute)_attributeSet.MatchesName(CharacterAttributeName.Wisdom)));
            _allSkills.Add(new Medicine((WisdomAttribute)_attributeSet.MatchesName(CharacterAttributeName.Wisdom)));
            _allSkills.Add(new Perception((WisdomAttribute)_attributeSet.MatchesName(CharacterAttributeName.Wisdom)));
            _allSkills.Add(new Survival((WisdomAttribute)_attributeSet.MatchesName(CharacterAttributeName.Wisdom)));
        }
        public void ActivateSkill(ISkill skill) => _activatedSkills.Add(skill);
    }
}
