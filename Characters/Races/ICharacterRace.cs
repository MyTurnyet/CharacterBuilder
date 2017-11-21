using System.Collections.Generic;
using Characters.Attributes;
using Characters.Display;
using Characters.Physical;
using Characters.Physical.Proficiencies;
using Characters.Physical.Sizes;

namespace Characters.Races
{
    public interface ICharacterRace
    {
        bool Equals(object obj);
        int GetHashCode();
        IAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute);
        ISpeed Speed();
        IHitPoints BonusHitPoints();
        List<IProficiency> Proficiencies();
        ITextObj Name();
        ISize Size();
    }
}