using System.Text;
using Characters.Display;
using Characters.Physical;

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
        public static readonly ICharacterRace HalflingLightfoot = new HalflingLightfoot();
        public static readonly ICharacterRace HalflingStout = new HalflingStout();


        internal CharacterRace(ITextObj race)
        {
            _race = race;
        }

        public override bool Equals(object obj) => (CharacterRace) obj != null && Equals((CharacterRace) obj);
        private bool Equals(CharacterRace other) => Equals(_race, other._race);
        public abstract IHitPoints BonusHitPoints();

        public ITextObj Name()
        {
            return _race;
        }
        public void AddJsonToStringbuilder(StringBuilder stringBuilder)
        {
            stringBuilder.Append("\"race\":\"");
            _race.AddToStringBuilder(stringBuilder);
            stringBuilder.Append("\"");
        }


    }
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
}
