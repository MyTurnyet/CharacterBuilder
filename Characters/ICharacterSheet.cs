using System.Collections.Generic;
using Characters.Attributes;
using Characters.Physical;

namespace Characters
{
    public interface ICharacterSheet
    {
        ICharacterAttribute Attribute(IAttributeName attributeName);
        HitPoints HitPoints();
        List<Proficiency> Proficiencies();
        TextOf StatsList();
    }
}