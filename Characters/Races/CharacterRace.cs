﻿using System.Collections.Generic;
using Characters.Attributes;
using Characters.Display;
using Characters.Physical;
using Characters.Physical.Proficiencies;
using Characters.Physical.Sizes;

namespace Characters.Races
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public abstract class CharacterRace
    {
        private readonly ITextObj _race;

        public static readonly ICharacterRace Human = new Human();
        public static readonly ICharacterRace WoodElf = new WoodElf();
        public static readonly ICharacterRace HighElf = new HighElf();
        public static readonly ICharacterRace HillDwarf = new HillDwarf();
        public static readonly ICharacterRace MountainDwarf = new MountainDwarf();


        internal CharacterRace(ITextObj race)
        {
            _race = race;
        }

        public override bool Equals(object obj) => (CharacterRace) obj != null && Equals((CharacterRace) obj);
        private bool Equals(CharacterRace other) => string.Equals(_race, other._race);
        public abstract IAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute);
        public abstract ISpeed Speed();
        public abstract IHitPoints BonusHitPoints();
        public abstract ISize Size();
        public abstract List<IProficiency> Proficiencies();
        public ITextObj Name()
        {
            return _race;
        }
    }
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
}
