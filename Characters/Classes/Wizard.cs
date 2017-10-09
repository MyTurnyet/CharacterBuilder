﻿using System.Collections.Generic;
using Characters.Attributes;
using Characters.Dice;
using Characters.Physical;

namespace Characters.Classes
{
    public class Wizard : CharacterClass
    {
        public Wizard() : base(new TextOf("Wizard")) { }
        public override IHitDie HitDie() => Dice.HitDie.Wizard;
        public override List<Proficiency> Proficiencies() => new List<Proficiency>
        {
            Proficiency.Dagger,
            Proficiency.Darts,
            Proficiency.Sling,
            Proficiency.Quarterstaff,
            Proficiency.LightCrossbow,
        };
        public override List<SavingThrowAttribute> SavingThrows() => new List<SavingThrowAttribute> { SavingThrowAttribute.Intellegence, SavingThrowAttribute.Wisdom };
        public override List<Skill> Skills() => new List<Skill>
            {Skill.Arcana,Skill.History,Skill.Insight,
                Skill.Investigation,Skill.Medicine,Skill.Religion};
    }
}
