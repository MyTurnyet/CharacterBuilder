using Characters.Attributes;

namespace Characters
{
    public interface ICharacterSheet
    {
        ICharacterAttribute Attribute(ICharacterAttributeName attributeName);
    }
}