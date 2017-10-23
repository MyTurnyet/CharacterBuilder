﻿using System.Collections.Generic;
using Characters.Attributes;
using Characters.Display;
using Characters.Physical;
using Characters.Physical.Proficiencies;

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
        ITextOf Name();
        ISize Size();
    }
}