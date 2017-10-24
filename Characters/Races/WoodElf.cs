using Characters.Attributes;
using Characters.Display;
using Characters.Physical;

namespace Characters.Races
{
    public class WoodElf : Elf
    {
        private readonly ISpeed _fleetFootBonus = new Speed(5);
        public WoodElf() : base(new TextObj("Wood Elf")) { }
        public override IAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute) => (AttributeScore)base.RacialAttributeAdjustment(attribute).Add(ApplyWisdomBonus(attribute));
        private IAttributeScore ApplyWisdomBonus(ICharacterAttribute attribute) => attribute.MatchesName(CharacterAttributeName.Wisdom) ? new AttributeScore(1) : new AttributeScore(0);
        public override ISpeed Speed() => base.Speed().Add(_fleetFootBonus);
        public override IHitPoints BonusHitPoints() => new HitPoints(0);
    }
}
