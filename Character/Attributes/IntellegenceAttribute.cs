namespace Character.Attributes
{

    public class IntellegenceAttribute : CharacterAttribute
    {
        public IntellegenceAttribute() : this(new AttributeScore(0)) { }

        public IntellegenceAttribute(IAttributeScore value) : base(CharacterAttributeName.Intelligence, value) { }
    }

}
