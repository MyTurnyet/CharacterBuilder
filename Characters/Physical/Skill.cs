using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters.Physical
{
    public class Skill : ISkill
    {
        private readonly string _skillName;
        public static readonly Skill Acrobatics = new Skill("Acrobatics");
        public static readonly Skill AnimalHandling = new Skill("Animal Handling");
        public static readonly Skill Arcana = new Skill("Arcana");
        public static readonly Skill Athletics = new Skill("Athletics");
        public static readonly Skill Deception = new Skill("Deception");
        public static readonly Skill History = new Skill("History");
        public static readonly Skill Insight = new Skill("Insight");
        public static readonly Skill Intimidation = new Skill("Intimidation");
        public static readonly Skill Investigation = new Skill("Investigation");
        public static readonly Skill Medicine = new Skill("Medicine");
        public static readonly Skill Nature = new Skill("Nature");
        public static readonly Skill Perception = new Skill("Perception");
        public static readonly Skill Performance = new Skill("Performance");
        public static readonly Skill Persuassion= new Skill("Persuassion");
        public static readonly Skill Religion = new Skill("Religion");
        public static readonly Skill SlightOfHand = new Skill("Slight Of Hand");
        public static readonly Skill Stealth = new Skill("Stealth");
        public static readonly Skill Survival = new Skill("Survival");

        private Skill(string skillName)
        {
            _skillName = skillName;
        }

        public override bool Equals(object obj)
        {
            return Equals((Skill)obj);
        }

        private bool Equals(Skill other)
        {
            return string.Equals(_skillName, other._skillName);
        }

        public override int GetHashCode()
        {
            return (_skillName != null ? _skillName.GetHashCode() : 0);
        }

        public static bool operator ==(Skill left, Skill right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Skill left, Skill right)
        {
            return !Equals(left, right);
        }
    }
}
