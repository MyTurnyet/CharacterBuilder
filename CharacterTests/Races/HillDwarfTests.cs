using Characters.Attributes;
using Characters.Physical;
using Characters.Races;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Races
{
    [TestClass]
    public class HillDwarfTests
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
            IAttributeScore expectedStr = CharacterRace.HillDwarf.RacialAttributeAdjustment(strAttribute);
            IAttributeScore expectedDex = CharacterRace.HillDwarf.RacialAttributeAdjustment(dexAttribute);
            IAttributeScore expectedCon = CharacterRace.HillDwarf.RacialAttributeAdjustment(conAttribute);
            IAttributeScore expectedInt = CharacterRace.HillDwarf.RacialAttributeAdjustment(intAttribute);
            IAttributeScore expectedWiz = CharacterRace.HillDwarf.RacialAttributeAdjustment(wizAttribute);
            IAttributeScore expectedChr = CharacterRace.HillDwarf.RacialAttributeAdjustment(chrAttribute);

            //assert
            expectedStr.Should().Be(new AttributeScore(0));
            expectedDex.Should().Be(new AttributeScore(0));
            expectedCon.Should().Be(new AttributeScore(2));
            expectedInt.Should().Be(new AttributeScore(0));
            expectedWiz.Should().Be(new AttributeScore(1));
            expectedChr.Should().Be(new AttributeScore(0));
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnSpeed()
        {
            //arrange
            ISpeed expectedSpeed = new Speed(25);

            //act
            ISpeed actualsSpeed = CharacterRace.HillDwarf.Speed();
            //assert
            actualsSpeed.Should().Be(expectedSpeed);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnSize()
        {
            //arrange
            CharacterRace.HillDwarf.Size().Should().Be(Size.Small);
            //act

            //assert
        }
    }
}
