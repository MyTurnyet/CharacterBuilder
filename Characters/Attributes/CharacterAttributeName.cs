﻿namespace Characters.Attributes
{
    public class CharacterAttributeName : IAttributeName
    {
        public static readonly IAttributeName Strength = new CharacterAttributeName("STR");
        public static readonly IAttributeName Dexterity = new CharacterAttributeName("DEX");
        public static readonly IAttributeName Constitution = new CharacterAttributeName("CON");
        public static readonly IAttributeName Wisdom = new CharacterAttributeName("WIS");
        public static readonly IAttributeName Intelligence = new CharacterAttributeName("INT");
        public static readonly IAttributeName Charisma = new CharacterAttributeName("CHR");

        private readonly string _name;

        private CharacterAttributeName(string name)
        {
            _name = name;
        }
        public override bool Equals(object obj) => (CharacterAttributeName)obj != null && ((CharacterAttributeName)obj)._name == _name;
        public override int GetHashCode() => _name.GetHashCode();
        protected bool Equals(CharacterAttributeName other) => string.Equals(_name, other._name);
        public static bool operator ==(CharacterAttributeName left, CharacterAttributeName right) => Equals(left, right);
        public static bool operator !=(CharacterAttributeName left, CharacterAttributeName right) => !Equals(left, right);
    }
}
