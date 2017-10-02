using System.Collections.Generic;
using Characters.Attributes;
using Characters.Dice;
using Characters.Physical;

namespace Characters.Classes
{
    public class Fighter:CharacterClass
    {
        public Fighter() : base("Fighter"){}
        public override HitDie HitDie() => Dice.HitDie.d10;
        public override List<Proficiency> Proficiencies() => new List<Proficiency>{
            Proficiency.SimpleWeapons,
            Proficiency.MartialWeapons,
            Proficiency.AllArmor,
            Proficiency.AllShields
        };
        public override List<SavingThrowAttribute> SavingThrows() => new List<SavingThrowAttribute>
        {SavingThrowAttribute.Strength,SavingThrowAttribute.Constitution};
        public HitPoints BaseHitPoints() => HitDie().MaxHitPoints();
    }
}
