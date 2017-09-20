using Characters.Attributes;
using Characters.Races;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Races
{
    [TestClass]
    public class HumanTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldAddRacialBonusToDexterity()
        {
            //arrange
            ICharacterAttribute strAttribute = new CharacterAttribute(CharacterAttributeName.Strength, new CharacterAttributeScore(12));
            ICharacterAttribute dexAttribute = new CharacterAttribute(CharacterAttributeName.Dexterity, new CharacterAttributeScore(14));
            ICharacterAttribute conAttribute = new CharacterAttribute(CharacterAttributeName.Constitution, new CharacterAttributeScore(2));
            ICharacterAttribute intAttribute = new CharacterAttribute(CharacterAttributeName.Intelligence, new CharacterAttributeScore(5));
            ICharacterAttribute wizAttribute = new CharacterAttribute(CharacterAttributeName.Wisdom, new CharacterAttributeScore(7));
            ICharacterAttribute chrAttribute = new CharacterAttribute(CharacterAttributeName.Charisma, new CharacterAttributeScore(9));

            //act
            ICharacterAttributeScore expectedStr = CharacterRace.Human.RacialAttributeAdjustment(strAttribute);
            ICharacterAttributeScore expectedDex = CharacterRace.Human.RacialAttributeAdjustment(dexAttribute);
            ICharacterAttributeScore expectedCon = CharacterRace.Human.RacialAttributeAdjustment(conAttribute);
            ICharacterAttributeScore expectedInt = CharacterRace.Human.RacialAttributeAdjustment(intAttribute);
            ICharacterAttributeScore expectedWiz = CharacterRace.Human.RacialAttributeAdjustment(wizAttribute);
            ICharacterAttributeScore expectedChr = CharacterRace.Human.RacialAttributeAdjustment(chrAttribute);

            //assert
            expectedStr.Should().Be(new CharacterAttributeScore(1));
            expectedDex.Should().Be(new CharacterAttributeScore(1));
            expectedCon.Should().Be(new CharacterAttributeScore(1));
            expectedInt.Should().Be(new CharacterAttributeScore(1));
            expectedWiz.Should().Be(new CharacterAttributeScore(1));
            expectedChr.Should().Be(new CharacterAttributeScore(1));
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnSpeed()
        {
            //arrange
            Speed expectedSpeed = new Speed(30);

            //assert
            CharacterRace.Human.Speed().Should().Be(expectedSpeed);
        }
    }
}
