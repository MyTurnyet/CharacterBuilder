namespace Characters.Attributes
{
    public interface IAttributeSet
    {
        //ICharacterAttribute Dexterity();
        //ICharacterAttribute Strength();
        //ICharacterAttribute Constitution();
        //ICharacterAttribute Intellegence();
        //ICharacterAttribute Wisdom();
        //ICharacterAttribute Charisma();
        ICharacterAttribute MatchesName(IAttributeName attributeName);
        TextOf DisplayText();
        void SetAttribute(IAttributeName attName, IAttributeScore attributeScore);
    }
}