namespace Characters.Attributes
{
    public class ConstitutionAttribute : CharacterAttribute
    {
        public ConstitutionAttribute() : this(new AttributeScore(0)) { }

        public ConstitutionAttribute(IAttributeScore value) : base(CharacterAttributeName.Constitution, value) { }
    }

}
