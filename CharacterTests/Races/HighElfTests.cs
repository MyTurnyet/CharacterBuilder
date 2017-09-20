using Characters.Attributes;
using Characters.Races;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Races
{
    [TestClass]
    public class HighElfTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldApplyRacialBonus()
        {
            //arrange
            ICharacterAttribute strAttribute = new CharacterAttribute(CharacterAttributeName.Strength, new CharacterAttributeScore(12));
            ICharacterAttribute dexAttribute = new CharacterAttribute(CharacterAttributeName.Dexterity, new CharacterAttributeScore(14));
            ICharacterAttribute conAttribute = new CharacterAttribute(CharacterAttributeName.Constitution, new CharacterAttributeScore(2));
            ICharacterAttribute intAttribute = new CharacterAttribute(CharacterAttributeName.Intelligence, new CharacterAttributeScore(5));
            ICharacterAttribute wizAttribute = new CharacterAttribute(CharacterAttributeName.Wisdom, new CharacterAttributeScore(7));
            ICharacterAttribute chrAttribute = new CharacterAttribute(CharacterAttributeName.Charisma, new CharacterAttributeScore(9));

            //act
            ICharacterAttributeScore expectedStr = CharacterRace.HighElf.RacialAttributeAdjustment(strAttribute);
            ICharacterAttributeScore expectedDex = CharacterRace.HighElf.RacialAttributeAdjustment(dexAttribute);
            ICharacterAttributeScore expectedCon = CharacterRace.HighElf.RacialAttributeAdjustment(conAttribute);
            ICharacterAttributeScore expectedInt = CharacterRace.HighElf.RacialAttributeAdjustment(intAttribute);
            ICharacterAttributeScore expectedWiz = CharacterRace.HighElf.RacialAttributeAdjustment(wizAttribute);
            ICharacterAttributeScore expectedChr = CharacterRace.HighElf.RacialAttributeAdjustment(chrAttribute);

            //assert
            expectedStr.Should().Be(new CharacterAttributeScore(0));
            expectedDex.Should().Be(new CharacterAttributeScore(2));
            expectedCon.Should().Be(new CharacterAttributeScore(0));
            expectedInt.Should().Be(new CharacterAttributeScore(1));
            expectedWiz.Should().Be(new CharacterAttributeScore(0));
            expectedChr.Should().Be(new CharacterAttributeScore(0));
        }
    }
}
