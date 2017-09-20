using System;
using Characters.Attributes;
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
            ICharacterAttribute strAttribute = new CharacterAttribute(CharacterAttributeName.Strength, new CharacterAttributeScore(12));
            ICharacterAttribute dexAttribute = new CharacterAttribute(CharacterAttributeName.Dexterity, new CharacterAttributeScore(14));
            ICharacterAttribute conAttribute = new CharacterAttribute(CharacterAttributeName.Constitution, new CharacterAttributeScore(2));
            ICharacterAttribute intAttribute = new CharacterAttribute(CharacterAttributeName.Intelligence, new CharacterAttributeScore(5));
            ICharacterAttribute wizAttribute = new CharacterAttribute(CharacterAttributeName.Wisdom, new CharacterAttributeScore(7));
            ICharacterAttribute chrAttribute = new CharacterAttribute(CharacterAttributeName.Charisma, new CharacterAttributeScore(9));

            //act
            ICharacterAttributeScore expectedStr = CharacterRace.MountainDwarf.RacialAttributeAdjustment(strAttribute);
            ICharacterAttributeScore expectedDex = CharacterRace.MountainDwarf.RacialAttributeAdjustment(dexAttribute);
            ICharacterAttributeScore expectedCon = CharacterRace.MountainDwarf.RacialAttributeAdjustment(conAttribute);
            ICharacterAttributeScore expectedInt = CharacterRace.MountainDwarf.RacialAttributeAdjustment(intAttribute);
            ICharacterAttributeScore expectedWiz = CharacterRace.MountainDwarf.RacialAttributeAdjustment(wizAttribute);
            ICharacterAttributeScore expectedChr = CharacterRace.MountainDwarf.RacialAttributeAdjustment(chrAttribute);

            //assert
            expectedStr.Should().Be(new CharacterAttributeScore(2));
            expectedDex.Should().Be(new CharacterAttributeScore(0));
            expectedCon.Should().Be(new CharacterAttributeScore(2));
            expectedInt.Should().Be(new CharacterAttributeScore(0));
            expectedWiz.Should().Be(new CharacterAttributeScore(0));
            expectedChr.Should().Be(new CharacterAttributeScore(0));
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnSpeed()
        {
            //arrange
            Speed expectedSpeed = new Speed(25);

            //act
            Speed actualsSpeed = CharacterRace.HillDwarf.Speed();
            //assert
            actualsSpeed.Should().Be(expectedSpeed);
        }
    }
}
