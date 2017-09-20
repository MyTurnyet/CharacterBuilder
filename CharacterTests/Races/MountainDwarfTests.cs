using Characters.Attributes;
using Characters.Physical;
using Characters.Races;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Races
{
    [TestClass]
    public class MountainDwarfTests
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
            IAttributeScore expectedStr = CharacterRace.MountainDwarf.RacialAttributeAdjustment(strAttribute);
            IAttributeScore expectedDex = CharacterRace.MountainDwarf.RacialAttributeAdjustment(dexAttribute);
            IAttributeScore expectedCon = CharacterRace.MountainDwarf.RacialAttributeAdjustment(conAttribute);
            IAttributeScore expectedInt = CharacterRace.MountainDwarf.RacialAttributeAdjustment(intAttribute);
            IAttributeScore expectedWiz = CharacterRace.MountainDwarf.RacialAttributeAdjustment(wizAttribute);
            IAttributeScore expectedChr = CharacterRace.MountainDwarf.RacialAttributeAdjustment(chrAttribute);

            //assert
            expectedStr.Should().Be(new AttributeScore(2));
            expectedDex.Should().Be(new AttributeScore(0));
            expectedCon.Should().Be(new AttributeScore(2));
            expectedInt.Should().Be(new AttributeScore(0));
            expectedWiz.Should().Be(new AttributeScore(0));
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
    }
}
