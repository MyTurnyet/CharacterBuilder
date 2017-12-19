using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        private readonly List<ISkill> _activatedSkills = new List<ISkill>();
        
        public CharacterSheet(ICharacterClass characterClass, ICharacterRace race, IAttributeSet attributeSet)
        {
            _characterClass = characterClass;
            _race = race;
            _attributeSet = attributeSet;
        }

        public ICharacterAttribute Attribute(IAttributeName attributeName)
        {
            _attributeSet.MatchesName(attributeName).ApplyRacialBonus(_race);
            return _attributeSet.MatchesName(attributeName);
        }
        public IHitPoints HitPoints() => (HitPoints)_characterClass.HitDie().MaxHitPoints().Add((HitPoints)_attributeSet.MatchesName(CharacterAttributeName.Constitution).BonusHitPoints()).Add((HitPoints)_race.BonusHitPoints());
        public List<IProficiency> Proficiencies()
        {
            List<IProficiency> proficiencies = new List<IProficiency>();
            proficiencies.AddRange(_characterClass.Proficiencies());
            proficiencies.AddRange(_race.Proficiencies());
            return proficiencies;
        }
        public ITextObj StatsList() => _attributeSet.DisplayText();
        public List<ISkill> Skills()
        {
            foreach (ISkill skill in new BaseSkillSet(_attributeSet).Skills().Where(s=> !_activatedSkills.Contains(s)))
            {
                _activatedSkills.Add(skill);
            }
            return _activatedSkills;
        }

        public void ActivateSkill(ISkill skill) => _activatedSkills.Add(skill);
        public void AddJsonToStringbuilder(StringBuilder stringbuilder)
        {
            stringbuilder.Append("{characterSheet:{");
            _race.AddJsonToStringbuilder(stringbuilder);
            stringbuilder.Append(",");
            _characterClass.AddJsonToStringbuilder(stringbuilder);
            stringbuilder.Append(",");
            _attributeSet.AddJsonToStringbuilder(stringbuilder);
            stringbuilder.Append("}}");
        }
    }
}
