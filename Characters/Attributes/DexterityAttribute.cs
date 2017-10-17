namespace Characters.Attributes
{
    public class DexterityAttribute : CharacterAttribute
    {
        public DexterityAttribute() : this(new AttributeScore(0)) { }

        public DexterityAttribute(IAttributeScore value) : base(CharacterAttributeName.Dexterity, value) { }
    }

}
