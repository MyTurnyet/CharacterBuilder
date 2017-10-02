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
        public static Proficiency Longbow = new Proficiency("Longbow");
        public static Proficiency Shortbow = new Proficiency("Longbow");
        public static Proficiency Longsword = new Proficiency("Longbow");
        public static Proficiency Shortsword = new Proficiency("Longbow");
        public static Proficiency Battleaxe = new Proficiency("Battleaxe");
        public static Proficiency Handaxe = new Proficiency("Handaxe");
        public static Proficiency ThrowingHammer = new Proficiency("Throwing Hammer");
        public static Proficiency Warhammer = new Proficiency("Warhammer");

        //Armor
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
        public override bool Equals(object obj) => Equals((Proficiency) obj);
        private bool Equals(Proficiency other) => string.Equals(_name, other._name);
        public override int GetHashCode() => (_name != null ? _name.GetHashCode() : 0);
        public static bool operator ==(Proficiency left, Proficiency right) => Equals(left, right);
        public static bool operator !=(Proficiency left, Proficiency right) => !Equals(left, right);
    }
}
