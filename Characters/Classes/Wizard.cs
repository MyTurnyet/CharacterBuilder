using System.Collections.Generic;
using Characters.Attributes;
using Characters.Dice;
using Characters.Display;
using Characters.Physical;
using Characters.Physical.Proficiencies;
using Characters.Physical.Skills;

namespace Characters.Classes
{
    public class Wizard : CharacterClass
    {
        public Wizard() : base(new TextOf("Wizard")) { }
        public override IHitDie HitDie() => Dice.HitDie.Wizard;
        public override List<IProficiency> Proficiencies() => new List<IProficiency>
        {
            new Darts(),
            new Dagger(),
            new Sling(),
            new Quarterstaff(),
            new LightCrossbow()
        };
        public override List<ISavingThrowAttribute> SavingThrows() => new List<ISavingThrowAttribute> { SavingThrowAttribute.Intellegence, SavingThrowAttribute.Wisdom };
        public override List<ISkill> Skills() => new List<ISkill>
            {new Arcana(),new History(),new Insight(),
                new Investigation(),new Medicine(),new Religion()};

        public override IHitPoints BaseHitPoints() => HitDie().MaxHitPoints();
    }
}
