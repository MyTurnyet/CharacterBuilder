using System.Collections.Generic;
using Characters.Attributes;
using Characters.Dice;
using Characters.Physical;

namespace Characters.Classes
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public abstract class CharacterClass : ICharacterClass
    {
        private readonly ITextOf _className;
        public static readonly ICharacterClass Fighter = new Fighter();
        public static readonly ICharacterClass Wizard = new Wizard();

        protected CharacterClass(ITextOf className)
        {
            _className = className;
        }
        public override bool Equals(object obj) => (CharacterClass)obj != null && Equals((CharacterClass)obj);
        private bool Equals(CharacterClass other) => Equals(_className, other._className);
        public abstract IHitDie HitDie();
        public abstract List<IProficiency> Proficiencies();
        public abstract List<ISavingThrowAttribute> SavingThrows();
        public abstract List<ISkill> Skills();
        public ITextOf Name() => _className;
    }
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
}
