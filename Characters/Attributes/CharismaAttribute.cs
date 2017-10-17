namespace Characters.Attributes
{
    public class CharismaAttribute : CharacterAttribute
    {
        public CharismaAttribute() : this(new AttributeScore(0)) { }

        public CharismaAttribute(IAttributeScore value) : base(CharacterAttributeName.Charisma, value) { }
    }

}
