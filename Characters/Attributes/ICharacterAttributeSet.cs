namespace Characters.Attributes
{
    public interface ICharacterAttributeSet
    {
        ICharacterAttribute Dexterity();
        ICharacterAttribute Strength();
        ICharacterAttribute Constitution();
        ICharacterAttribute Intellegence();
        ICharacterAttribute Wisdom();
        ICharacterAttribute Charisma();
        ICharacterAttribute MatchesName(ICharacterAttributeName attributeName);
    }
}