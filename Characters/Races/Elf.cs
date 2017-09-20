using Characters.Attributes;

namespace Characters.Races
{
    public abstract class Elf : CharacterRace
    {
        internal Elf(string race) : base(race){}
        public override ICharacterAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute) => ApplyDexterityBonus(attribute);
        private CharacterAttributeScore ApplyDexterityBonus(ICharacterAttribute attribute) => !attribute.MatchesName(CharacterAttributeName.Dexterity) ? new CharacterAttributeScore(0) : new CharacterAttributeScore(2);
        public override Speed Speed() => new Speed(30);
    }
}
