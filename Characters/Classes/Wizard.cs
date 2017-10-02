using System.Collections.Generic;
using Characters.Attributes;
using Characters.Dice;
using Characters.Physical;

namespace Characters.Classes
{
    public class Wizard : CharacterClass
    {
        public Wizard() : base("Wizard"){}
        public override HitDie HitDie() => Dice.HitDie.d6;
        public override List<Proficiency> Proficiencies() => new List<Proficiency>
        {
            Proficiency.Dagger,
            Proficiency.Darts,
            Proficiency.Sling,
            Proficiency.Quarterstaff,
            Proficiency.LightCrossbow,
        };
        public override List<SavingThrowAttribute> SavingThrows() => new List<SavingThrowAttribute> { SavingThrowAttribute.Intellegence, SavingThrowAttribute.Wisdom };
    }
}
