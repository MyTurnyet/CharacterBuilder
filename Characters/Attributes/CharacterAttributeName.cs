namespace Characters.Attributes
{
#pragma warning disable 659
    public class CharacterAttributeName : IAttributeName
    {
        public static readonly IAttributeName Strength = new CharacterAttributeName(new TextOf("STR"));
        public static readonly IAttributeName Dexterity = new CharacterAttributeName(new TextOf("DEX"));
        public static readonly IAttributeName Constitution = new CharacterAttributeName(new TextOf("CON"));
        public static readonly IAttributeName Wisdom = new CharacterAttributeName(new TextOf("WIS"));
        public static readonly IAttributeName Intelligence = new CharacterAttributeName(new TextOf("INT"));
        public static readonly IAttributeName Charisma = new CharacterAttributeName(new TextOf("CHR"));

        private readonly TextOf _name;

        private CharacterAttributeName(TextOf name)
        {
            _name = name;
        }

        public override bool Equals(object obj) => (CharacterAttributeName)obj != null && ((CharacterAttributeName)obj)._name == _name;
        public TextOf Name() => _name;
    }
#pragma warning restore 659
}