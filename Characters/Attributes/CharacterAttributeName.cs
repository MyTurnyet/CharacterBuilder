namespace Characters.Attributes
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
#pragma warning disable 659
        public override bool Equals(object obj) => (CharacterAttributeName)obj != null && ((CharacterAttributeName)obj)._name == _name;
#pragma warning restore 659
    }
}