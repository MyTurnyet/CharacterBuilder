using System.Collections.Generic;
using Characters.Attributes;
using Characters.Physical;

namespace Characters.Races
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public abstract class CharacterRace : ICharacterRace
    {
        private readonly TextOf _race;

        public static readonly CharacterRace Human = new Human();
        public static readonly CharacterRace WoodElf = new WoodElf();
        public static readonly CharacterRace HighElf = new HighElf();
        public static readonly CharacterRace HillDwarf = new HillDwarf();
        public static readonly CharacterRace MountainDwarf = new MountainDwarf();


        internal CharacterRace(TextOf race)
        {
            _race = race;
        }

        public override bool Equals(object obj) => (CharacterRace) obj != null && Equals((CharacterRace) obj);
        private bool Equals(CharacterRace other) => string.Equals(_race, other._race);
        public abstract IAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute);
        public abstract ISpeed Speed();
        public abstract HitPoints BonusHitPoints();
        public abstract Size Size();
        public abstract List<Proficiency> Proficiencies();
    }
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
}
