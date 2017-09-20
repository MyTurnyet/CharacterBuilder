namespace Characters.Classes
{
    public class CharacterClass : ICharacterClass
    {
        private readonly string _className;
        public static readonly CharacterClass Fighter = new CharacterClass("Fighter");
        public static readonly CharacterClass Wizard = new CharacterClass("Wizard");

        private CharacterClass(string className)
        {
            _className = className;
        }
        public override bool Equals(object obj) => (CharacterClass)obj != null && ((CharacterClass)obj)._className == _className;
        protected bool Equals(CharacterClass other) => string.Equals(_className, other._className);
        public override int GetHashCode() => (_className != null ? _className.GetHashCode() : 0);
        public static bool operator ==(CharacterClass left, CharacterClass right) => Equals(left, right);
        public static bool operator !=(CharacterClass left, CharacterClass right) => !Equals(left, right);
    }
}
