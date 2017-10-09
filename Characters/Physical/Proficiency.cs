namespace Characters.Physical
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public class Proficiency : IProficiency

    {
        private readonly TextOf _name;

        //Weapons
        public static readonly Proficiency SimpleWeapons = new Proficiency(new TextOf("Simple Weapons"));
        public static readonly Proficiency MartialWeapons = new Proficiency(new TextOf("Martial Weapons"));

        public static readonly Proficiency Longsword = new Proficiency(new TextOf("Longsword"));
        public static readonly Proficiency Shortsword = new Proficiency(new TextOf("Shortsword"));
        public static readonly Proficiency Battleaxe = new Proficiency(new TextOf("Battleaxe"));
        public static readonly Proficiency Handaxe = new Proficiency(new TextOf("Handaxe"));
        public static readonly Proficiency ThrowingHammer = new Proficiency(new TextOf("Throwing Hammer"));
        public static readonly Proficiency Warhammer = new Proficiency(new TextOf("Warhammer"));
        public static readonly Proficiency Quarterstaff = new Proficiency(new TextOf("Quarterstaff"));
        public static readonly Proficiency Dagger = new Proficiency(new TextOf("Dagger"));

        //Ranged Weapons
        public static readonly Proficiency Longbow = new Proficiency(new TextOf("Longbow"));
        public static readonly Proficiency Shortbow = new Proficiency(new TextOf("Shortbow"));
        public static readonly Proficiency Darts = new Proficiency(new TextOf("Darts"));
        public static readonly Proficiency Sling = new Proficiency(new TextOf("Sling"));
        public static readonly Proficiency LightCrossbow = new Proficiency(new TextOf("Light Crossbow"));

        //Armor
        public static readonly Proficiency AllShields = new Proficiency(new TextOf("All Shields"));
        public static readonly Proficiency AllArmor = new Proficiency(new TextOf("All Armor"));
        public static readonly Proficiency LightArmor = new Proficiency(new TextOf("Light Armor"));
        public static readonly Proficiency MediumArmor = new Proficiency(new TextOf("Medium Armor"));

        //NonCombat
        public static readonly Proficiency SmithsTools = new Proficiency(new TextOf("Smith's Tools"));
        public static readonly Proficiency BrewersSupplies = new Proficiency(new TextOf("Brewer's Supplies"));
        public static readonly Proficiency MasonsTools = new Proficiency(new TextOf("Mason's Tools"));

        private Proficiency(TextOf name)
        {
            _name = name;
        }
        public override bool Equals(object obj) => Equals((Proficiency)obj);
        private bool Equals(Proficiency other) => string.Equals(_name, other._name);
    }
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
}
