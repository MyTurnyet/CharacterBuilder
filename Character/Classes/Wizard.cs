using System.Collections.Generic;
using Character.Attributes;
using Character.Dice;
using Character.Display;
using Character.Physical.Proficiencies;
using Character.Physical.Skills;

namespace Character.Classes
{
    public class Wizard : CharacterClassBase, ICharacterClass
    {
        public Wizard() : base(new TextObj("Wizard")) { }
        public override IHitDie HitDie() => new WizardHitDie();
        public override List<IProficiency> Proficiencies() => new List<IProficiency>
        {
            new Darts(),
            new Dagger(),
            new Sling(),
            new Quarterstaff(),
            new LightCrossbow()
        };
        public override List<ISavingThrowAttribute> SavingThrows() => new List<ISavingThrowAttribute> { SavingThrowAttribute.Intellegence, SavingThrowAttribute.Wisdom };
        public override List<ISkill> Skills() => new List<ISkill> { new Arcana(), new History(), new Insight(), new Investigation(), new Medicine(), new Religion() };
    }
}
