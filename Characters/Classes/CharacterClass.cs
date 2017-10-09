using System.Collections.Generic;
using Characters.Attributes;
using Characters.Dice;
using Characters.Physical;

namespace Characters.Classes
{
    public abstract class CharacterClass : ICharacterClass
    {
        private readonly string _className;
        public static readonly ICharacterClass Fighter = new Fighter();
        public static readonly ICharacterClass Wizard = new Wizard();

        protected CharacterClass(string className)
        {
            _className = className;
        }
#pragma warning disable 659
        public override bool Equals(object obj) => (CharacterClass)obj != null && Equals((CharacterClass)obj);
#pragma warning restore 659
        private bool Equals(CharacterClass other) => string.Equals(_className, other._className);
        public abstract IHitDie HitDie();
        public abstract List<Proficiency> Proficiencies();
        public abstract List<SavingThrowAttribute> SavingThrows();
        public abstract List<Skill> Skills();
    }
}
