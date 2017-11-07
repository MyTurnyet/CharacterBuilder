using System.Collections.Generic;
using Characters.Attributes;
using Characters.Display;
using Characters.Physical;
using Characters.Physical.Proficiencies;
using Characters.Physical.Skills;

namespace Characters
{
    public interface ICharacterSheet
    {
        ICharacterAttribute Attribute(IAttributeName attributeName);
        IHitPoints HitPoints();
        List<IProficiency> Proficiencies();
        ITextObj StatsList();
        List<ISkill> Skills();
        void ActivateSkill(ISkill skill);
    }
}