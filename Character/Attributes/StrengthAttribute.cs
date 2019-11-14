namespace Character.Attributes
{
    public class StrengthAttribute: CharacterAttribute
    {
        public StrengthAttribute():this(new AttributeScore(0)){}
        public StrengthAttribute( IAttributeScore value) : base(CharacterAttributeName.Strength, value){}
    }

}
