using Characters.Display;

namespace Characters.Physical.Skills
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public class SkillBase
    {
        private readonly TextOf _skillName;
        protected SkillBase(TextOf skillName) => _skillName = skillName;
        public override bool Equals(object obj) => Equals((SkillBase)obj);
        private bool Equals(SkillBase other) => string.Equals(_skillName, other._skillName);
        public TextOf Name() => _skillName;
    }
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
}
