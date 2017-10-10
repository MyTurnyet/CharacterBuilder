using System.Collections.Generic;
using Characters.Attributes;
using Characters.Physical;

namespace Characters.Races
{
    public interface ICharacterRace
    {
        bool Equals(object obj);
        int GetHashCode();
        IAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute);
        ISpeed Speed();
        HitPoints BonusHitPoints();
        List<Proficiency> Proficiencies();
        TextOf Name();
    }
}