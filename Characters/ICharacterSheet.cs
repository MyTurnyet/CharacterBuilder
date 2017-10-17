using System.Collections.Generic;
using Characters.Attributes;
using Characters.Physical;

namespace Characters
{
    public interface ICharacterSheet
    {
        ICharacterAttribute Attribute(IAttributeName attributeName);
        IHitPoints HitPoints();
        List<IProficiency> Proficiencies();
        ITextOf StatsList();
    }
}