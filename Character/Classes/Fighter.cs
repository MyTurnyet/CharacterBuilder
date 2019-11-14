using System.Collections.Generic;
using Character.Attributes;
using Character.Dice;
using Character.Display;
using Character.Physical.Proficiencies;
using Character.Physical.Skills;

namespace Character.Classes
{
    public class Fighter : CharacterClassBase, ICharacterClass
    {
        public Fighter() : base(new TextObj("Fighter")) { }
        public override IHitDie HitDie() =>new FigtherHitDie();
        public override List<IProficiency> Proficiencies() => new List<IProficiency> { new SimpleWeapons(), new MartialWeapons(), new AllArmor(), new AllShields() };
        public override List<ISavingThrowAttribute> SavingThrows() => new List<ISavingThrowAttribute> { SavingThrowAttribute.Strength, SavingThrowAttribute.Constitution };
        public override List<ISkill> Skills() => new List<ISkill>
            {new Acrobatics(),new AnimalHandling(),new Athletics(),new History(),
                new Insight(),new Intimidation(),new Perception(),new Survival()};
    }
}
