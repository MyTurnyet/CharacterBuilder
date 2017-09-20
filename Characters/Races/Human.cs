﻿using Characters.Attributes;

namespace Characters.Races
{
    public class Human : CharacterRace
    {
        public Human() : base("Human"){}
        public override IAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute) => new AttributeScore(1);
        public override ISpeed Speed() => new Speed(30);
    }
}
