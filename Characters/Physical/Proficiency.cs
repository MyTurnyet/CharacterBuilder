using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters.Physical
{
    public class Proficiency
    {
        private readonly string _name;

        //Weapons
        public static Proficiency SimpleWeapons = new Proficiency("Simple Weapons");
        public static Proficiency MartialWeapons = new Proficiency("Martial Weapons");

        public static Proficiency Longsword = new Proficiency("Longsword");
        public static Proficiency Shortsword = new Proficiency("Shortsword");
        public static Proficiency Battleaxe = new Proficiency("Battleaxe");
        public static Proficiency Handaxe = new Proficiency("Handaxe");
        public static Proficiency ThrowingHammer = new Proficiency("Throwing Hammer");
        public static Proficiency Warhammer = new Proficiency("Warhammer");
        public static Proficiency Quarterstaff = new Proficiency("Quarterstaff");
        public static Proficiency Dagger = new Proficiency("Dagger");

        //Ranged Weapons
        public static Proficiency Longbow = new Proficiency("Longbow");
        public static Proficiency Shortbow = new Proficiency("Shortbow");
        public static Proficiency Darts = new Proficiency("Darts");
        public static Proficiency Sling = new Proficiency("Sling");
        public static Proficiency LightCrossbow = new Proficiency("Light Crossbow");

        //Armor
        public static Proficiency AllShields = new Proficiency("All Shields");
        public static Proficiency AllArmor = new Proficiency("All Armor");
        public static Proficiency LightArmor = new Proficiency("Light Armor");
        public static Proficiency MediumArmor = new Proficiency("Medium Armor");

        //NonCombat
        public static Proficiency SmithsTools = new Proficiency("Smith's Tools");
        public static Proficiency BrewersSupplies = new Proficiency("Brewer's Supplies");
        public static Proficiency MasonsTools = new Proficiency("Mason's Tools");

        private Proficiency(string name)
        {
            _name = name;
        }
        public override bool Equals(object obj) => Equals((Proficiency)obj);
        private bool Equals(Proficiency other) => string.Equals(_name, other._name);
        public override int GetHashCode() => (_name != null ? _name.GetHashCode() : 0);
        public static bool operator ==(Proficiency left, Proficiency right) => Equals(left, right);
        public static bool operator !=(Proficiency left, Proficiency right) => !Equals(left, right);
    }
}
