using Characters.Display;

namespace Characters.Attributes
{
#pragma warning disable 659
    public class CharacterAttributeName : IAttributeName
    {
        public static readonly IAttributeName Strength = new CharacterAttributeName(new TextObj("STR"));
        public static readonly IAttributeName Dexterity = new CharacterAttributeName(new TextObj("DEX"));
        public static readonly IAttributeName Constitution = new CharacterAttributeName(new TextObj("CON"));
        public static readonly IAttributeName Wisdom = new CharacterAttributeName(new TextObj("WIS"));
        public static readonly IAttributeName Intelligence = new CharacterAttributeName(new TextObj("INT"));
        public static readonly IAttributeName Charisma = new CharacterAttributeName(new TextObj("CHR"));

        private readonly TextObj _name;

        private CharacterAttributeName(TextObj name)
        {
            _name = name;
        }
        public override bool Equals(object obj) => (CharacterAttributeName)obj != null && ((CharacterAttributeName)obj)._name == _name;
        public TextObj Name() => new TextObj(_name);
    }
#pragma warning restore 659
}