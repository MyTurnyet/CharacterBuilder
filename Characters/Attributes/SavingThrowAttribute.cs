namespace Characters.Attributes
{
    public class SavingThrowAttribute : ISavingThrowAttribute
    {
        private readonly IAttributeName _attributeName;

        public static readonly SavingThrowAttribute Strength = new SavingThrowAttribute(CharacterAttributeName.Strength);
        public static readonly SavingThrowAttribute Dexterity = new SavingThrowAttribute(CharacterAttributeName.Dexterity);
        public static readonly SavingThrowAttribute Constitution = new SavingThrowAttribute(CharacterAttributeName.Constitution);
        public static readonly SavingThrowAttribute Wisdom = new SavingThrowAttribute(CharacterAttributeName.Wisdom);
        public static readonly SavingThrowAttribute Intellegence = new SavingThrowAttribute(CharacterAttributeName.Intelligence);
        public static readonly SavingThrowAttribute Charisma = new SavingThrowAttribute(CharacterAttributeName.Charisma);

        private SavingThrowAttribute(IAttributeName attributeName)
        {
            _attributeName = attributeName;
        }
#pragma warning disable 659
        public override bool Equals(object obj) => Equals((SavingThrowAttribute)obj);
#pragma warning restore 659
        private bool Equals(SavingThrowAttribute other) => Equals(_attributeName, other._attributeName);
    }
}
