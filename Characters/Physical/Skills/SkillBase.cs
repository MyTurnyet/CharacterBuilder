using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public class SkillBase
    {
        private readonly ITextObj _skillName;
        private readonly ICharacterAttribute _baseAttribute;
        private readonly bool _activateSkill;

        protected SkillBase(ITextObj skillName, ICharacterAttribute baseAttribute, bool activateSkill)
        {
            _skillName = skillName;
            _baseAttribute = baseAttribute;
            _activateSkill = activateSkill;
        }

        public override bool Equals(object obj) => Equals((SkillBase)obj);
        private bool Equals(SkillBase other) => string.Equals(_skillName, other._skillName);
        public ITextObj Name() => _skillName;
        public ICharacterAttribute BaseAttribute() => _baseAttribute;
        public IAttributeScore SkillBonus()
        {
            IAttributeScore score = _baseAttribute.Bonus();
            if (_activateSkill)
            {
                score = score.Add(new AttributeScore(2));
            }
            return score;
        }
    }
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
}
