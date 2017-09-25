using Characters.Attributes;
using Characters.Physical;

namespace Characters
{
    public interface ICharacterSheet
    {
        ICharacterAttribute Attribute(IAttributeName attributeName);
        HitPoints HitPoints();
    }
}