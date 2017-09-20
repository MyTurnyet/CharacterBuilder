using Characters.Attributes;

namespace Characters.Races
{
    public class Human : CharacterRace
    {
        public Human() : base("Human"){}
        public override ICharacterAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute) => new CharacterAttributeScore(1);
        public override Speed Speed() => new Speed(30);
    }
}
