﻿using System.Collections.Generic;
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
        public override bool Equals(object obj) => (CharacterClass)obj != null && ((CharacterClass)obj)._className == _className;
        protected bool Equals(CharacterClass other) => string.Equals(_className, other._className);
        public override int GetHashCode() => (_className != null ? _className.GetHashCode() : 0);
        public abstract IHitDie HitDie();
        public abstract List<Proficiency> Proficiencies();
        public abstract List<SavingThrowAttribute> SavingThrows();
        public abstract List<Skill> Skills();
        public static bool operator ==(CharacterClass left, CharacterClass right) => Equals(left, right);
        public static bool operator !=(CharacterClass left, CharacterClass right) => !Equals(left, right);
        
    }
}
