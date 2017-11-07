using System.Collections.Generic;
using Characters.Attributes;
using Characters.Dice;
using Characters.Display;
using Characters.Physical;
using Characters.Physical.Proficiencies;
using Characters.Physical.Skills;
using Characters.Races;

namespace Characters.Classes
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
