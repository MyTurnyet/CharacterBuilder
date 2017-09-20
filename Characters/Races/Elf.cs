using Characters.Attributes;

namespace Characters.Races
{
    public abstract class Elf : CharacterRace
    {
        internal Elf(string race) : base(race){}
        public override IAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute) => ApplyDexterityBonus(attribute);
        private AttributeScore ApplyDexterityBonus(ICharacterAttribute attribute) => !attribute.MatchesName(CharacterAttributeName.Dexterity) ? new AttributeScore(0) : new AttributeScore(2);
        public override Speed Speed() => new Speed(30);
    }
}
