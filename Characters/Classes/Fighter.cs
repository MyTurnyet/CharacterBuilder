using System.Collections.Generic;
using Characters.Attributes;
using Characters.Dice;
using Characters.Physical;

namespace Characters.Classes
{
    public class Fighter : CharacterClass
    {
        public Fighter() : base("Fighter") { }
        public override IHitDie HitDie() => Dice.HitDie.Fighter;
        public override List<Proficiency> Proficiencies() => new List<Proficiency>{
            Proficiency.SimpleWeapons,
            Proficiency.MartialWeapons,
            Proficiency.AllArmor,
            Proficiency.AllShields
        };
        public override List<SavingThrowAttribute> SavingThrows() => new List<SavingThrowAttribute>
        {SavingThrowAttribute.Strength,SavingThrowAttribute.Constitution};
        public override List<Skill> Skills() => new List<Skill>
            {Skill.Acrobatics,Skill.AnimalHandling,Skill.Athletics,Skill.History,
                Skill.Insight,Skill.Intimidation,Skill.Perception,Skill.Survival};
        public HitPoints BaseHitPoints() => HitDie().MaxHitPoints();
    }
}
