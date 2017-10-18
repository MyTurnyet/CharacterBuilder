using System.Collections.Generic;
using Characters.Attributes;
using Characters.Dice;
using Characters.Physical;

namespace Characters.Classes
{
    public class Fighter : CharacterClass
    {
        public Fighter() : base(new TextOf("Fighter")) { }
        public override IHitDie HitDie() => Dice.HitDie.Fighter;
        public override List<IProficiency> Proficiencies() => new List<IProficiency>{
            Proficiency.SimpleWeapons,
            Proficiency.MartialWeapons,
            Proficiency.AllArmor,
            Proficiency.AllShields
        };
        public override List<ISavingThrowAttribute> SavingThrows() => new List<ISavingThrowAttribute>
        {SavingThrowAttribute.Strength,SavingThrowAttribute.Constitution};
        public override List<ISkill> Skills() => new List<ISkill>
            {Skill.Acrobatics,Skill.AnimalHandling,Skill.Athletics,Skill.History,
                Skill.Insight,Skill.Intimidation,Skill.Perception,Skill.Survival};
        public override IHitPoints BaseHitPoints() => HitDie().MaxHitPoints();
    }
}
