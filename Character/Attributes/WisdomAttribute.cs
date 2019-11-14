namespace Character.Attributes
{
    public class WisdomAttribute : CharacterAttribute
    {
        public WisdomAttribute() : this(new AttributeScore(0)) { }
        public WisdomAttribute(IAttributeScore value) : base(CharacterAttributeName.Wisdom, value) { }
    }

}
