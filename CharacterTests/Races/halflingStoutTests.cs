using Characters.Attributes;
using Characters.Races;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Races
{
    [TestClass]
    public class HalflingStoutTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldApplyRacialBonus()
        {
            //arrange
            ICharacterAttribute strAttribute = new CharacterAttribute(CharacterAttributeName.Strength, new AttributeScore(12));
            ICharacterAttribute dexAttribute = new CharacterAttribute(CharacterAttributeName.Dexterity, new AttributeScore(14));
            ICharacterAttribute conAttribute = new CharacterAttribute(CharacterAttributeName.Constitution, new AttributeScore(2));
            ICharacterAttribute intAttribute = new CharacterAttribute(CharacterAttributeName.Intelligence, new AttributeScore(5));
            ICharacterAttribute wizAttribute = new CharacterAttribute(CharacterAttributeName.Wisdom, new AttributeScore(7));
            ICharacterAttribute chrAttribute = new CharacterAttribute(CharacterAttributeName.Charisma, new AttributeScore(9));

            //act
            IAttributeScore expectedStr = CharacterRace.HalflingStout.RacialAttributeAdjustment(strAttribute);
            IAttributeScore expectedDex = CharacterRace.HalflingStout.RacialAttributeAdjustment(dexAttribute);
            IAttributeScore expectedCon = CharacterRace.HalflingStout.RacialAttributeAdjustment(conAttribute);
            IAttributeScore expectedInt = CharacterRace.HalflingStout.RacialAttributeAdjustment(intAttribute);
            IAttributeScore expectedWiz = CharacterRace.HalflingStout.RacialAttributeAdjustment(wizAttribute);
            IAttributeScore expectedChr = CharacterRace.HalflingStout.RacialAttributeAdjustment(chrAttribute);

            //assert
            expectedStr.Should().Be(new AttributeScore(0));
            expectedDex.Should().Be(new AttributeScore(2));
            expectedCon.Should().Be(new AttributeScore(1));
            expectedInt.Should().Be(new AttributeScore(0));
            expectedWiz.Should().Be(new AttributeScore(0));
            expectedChr.Should().Be(new AttributeScore(0));
        }
    }
}
