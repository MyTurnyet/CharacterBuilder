namespace Characters.Physical
{
    public class Proficiency : IProficiency
    {
        private readonly string _name;

        //Weapons
        public static readonly Proficiency SimpleWeapons = new Proficiency("Simple Weapons");
        public static readonly Proficiency MartialWeapons = new Proficiency("Martial Weapons");

        public static readonly Proficiency Longsword = new Proficiency("Longsword");
        public static readonly Proficiency Shortsword = new Proficiency("Shortsword");
        public static readonly Proficiency Battleaxe = new Proficiency("Battleaxe");
        public static readonly Proficiency Handaxe = new Proficiency("Handaxe");
        public static readonly Proficiency ThrowingHammer = new Proficiency("Throwing Hammer");
        public static readonly Proficiency Warhammer = new Proficiency("Warhammer");
        public static readonly Proficiency Quarterstaff = new Proficiency("Quarterstaff");
        public static readonly Proficiency Dagger = new Proficiency("Dagger");

        //Ranged Weapons
        public static readonly Proficiency Longbow = new Proficiency("Longbow");
        public static readonly Proficiency Shortbow = new Proficiency("Shortbow");
        public static readonly Proficiency Darts = new Proficiency("Darts");
        public static readonly Proficiency Sling = new Proficiency("Sling");
        public static readonly Proficiency LightCrossbow = new Proficiency("Light Crossbow");

        //Armor
        public static readonly Proficiency AllShields = new Proficiency("All Shields");
        public static readonly Proficiency AllArmor = new Proficiency("All Armor");
        public static readonly Proficiency LightArmor = new Proficiency("Light Armor");
        public static readonly Proficiency MediumArmor = new Proficiency("Medium Armor");

        //NonCombat
        public static readonly Proficiency SmithsTools = new Proficiency("Smith's Tools");
        public static readonly Proficiency BrewersSupplies = new Proficiency("Brewer's Supplies");
        public static readonly Proficiency MasonsTools = new Proficiency("Mason's Tools");

        private Proficiency(string name)
        {
            _name = name;
        }
#pragma warning disable 659
        public override bool Equals(object obj) => Equals((Proficiency)obj);
#pragma warning restore 659
        private bool Equals(Proficiency other) => string.Equals(_name, other._name);
    }
}
