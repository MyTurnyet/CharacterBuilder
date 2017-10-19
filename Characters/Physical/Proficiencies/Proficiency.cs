namespace Characters.Physical.Proficiencies
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public abstract class Proficiency : IProficiency

    {
        private readonly TextOf _name;

        //Weapons
        public static readonly IProficiency SimpleWeapons = new SimpleWeapons();
        public static readonly IProficiency MartialWeapons = new MartialWeapons();

        public static readonly IProficiency Longsword = new Longsword();
        public static readonly IProficiency Shortsword = new Shortsword();
        public static readonly IProficiency Battleaxe = new Battleaxe();
        public static readonly IProficiency Handaxe = new Handaxe();
        public static readonly IProficiency ThrowingHammer = new ThrowingHammer();
        public static readonly IProficiency Warhammer = new Warhammer();
        public static readonly IProficiency Quarterstaff = new Quarterstaff();
        public static readonly IProficiency Dagger = new Dagger();

        //Ranged Weapons
        public static readonly IProficiency Longbow = new Longbow();
        public static readonly IProficiency Shortbow = new Shortbow();
        public static readonly IProficiency Darts = new Darts();
        public static readonly IProficiency Sling = new Sling();
        public static readonly IProficiency LightCrossbow = new LightCrossbow();

        //Armor
        public static readonly IProficiency AllShields = new AllShields();
        public static readonly IProficiency AllArmor = new AllArmor();
        public static readonly IProficiency LightArmor = new LightArmor();
        public static readonly IProficiency MediumArmor = new MediumArmor();

        //NonCombat
        public static readonly IProficiency SmithsTools = new SmithsTools();
        public static readonly IProficiency BrewersSupplies = new BrewersSupplies();
        public static readonly IProficiency MasonsTools = new MasonsTools();
        protected Proficiency():this(new TextOf()){}
        protected Proficiency(TextOf name)
        {
            _name = name;
        }
        public override bool Equals(object obj) => Equals((Proficiency)obj);
        private bool Equals(Proficiency other) => string.Equals(_name, other._name);
        public ITextOf Name() => _name;
    }

#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
}
