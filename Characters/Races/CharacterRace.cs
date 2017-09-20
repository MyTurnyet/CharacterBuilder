using Characters.Attributes;

namespace Characters.Races
{
   public abstract class CharacterRace : ICharacterRace
    {
        private readonly string _race;

        public static readonly CharacterRace Human = new Human();
        public static readonly CharacterRace WoodElf = new WoodElf();
        public static readonly CharacterRace HighElf = new HighElf();
        public static readonly CharacterRace HillDwarf = new HillDwarf();
        public static readonly CharacterRace MountainDwarf = new MountainDwarf();


        internal CharacterRace(string race)
        {
            _race = race;
        }
        public override bool Equals(object obj) => (CharacterRace)obj != null && ((CharacterRace)obj)._race == _race;
        protected bool Equals(CharacterRace other) => string.Equals(_race, other._race);
        public override int GetHashCode() => (_race != null ? _race.GetHashCode() : 0);
        public abstract IAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute);
        public abstract Speed Speed();
        public static bool operator ==(CharacterRace left, CharacterRace right) => Equals(left, right);
        public static bool operator !=(CharacterRace left, CharacterRace right) => !Equals(left, right);

    }
}
