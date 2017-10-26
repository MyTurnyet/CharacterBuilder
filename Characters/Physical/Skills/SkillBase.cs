using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public class SkillBase
    {
        private readonly ITextObj _skillName;
        private readonly ICharacterAttribute _baseAttribute;

        protected SkillBase(ITextObj skillName, ICharacterAttribute baseAttribute)
        {
            _skillName = skillName;
            _baseAttribute = baseAttribute;
        }

        public override bool Equals(object obj) => Equals((SkillBase)obj);
        private bool Equals(SkillBase other) => string.Equals(_skillName, other._skillName);
        public ITextObj Name() => _skillName;
        public ICharacterAttribute BaseAttribute()
        {
            return _baseAttribute;
        }
        public IAttributeScore SkillBonus()
        {
            return _baseAttribute.Bonus();
        }

    }
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
}
