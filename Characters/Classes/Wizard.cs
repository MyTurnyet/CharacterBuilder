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
        public override List<ISkill> Skills(IAttributeSet attributeSet)
        {
            List<ISkill> skills = new List<ISkill>
            {new Arcana((IntellegenceAttribute)attributeSet.MatchesName(CharacterAttributeName.Intelligence)),
                new History((IntellegenceAttribute)attributeSet.MatchesName(CharacterAttributeName.Intelligence)),
                new Insight((WisdomAttribute)attributeSet.MatchesName(CharacterAttributeName.Wisdom)),
                new Investigation((IntellegenceAttribute)attributeSet.MatchesName(CharacterAttributeName.Intelligence)),
                new Medicine((WisdomAttribute)attributeSet.MatchesName(CharacterAttributeName.Wisdom)),
                new Religion((IntellegenceAttribute)attributeSet.MatchesName(CharacterAttributeName.Intelligence))};

            return skills;
        }
    }
}
