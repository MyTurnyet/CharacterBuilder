using System.Collections.Generic;
using Characters.Attributes;
using Characters.Physical;
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
            ICharacterAttribute strAttribute = new CharacterAttribute(CharacterAttributeName.Strength, new AttributeScore(12));
            ICharacterAttribute dexAttribute = new CharacterAttribute(CharacterAttributeName.Dexterity, new AttributeScore(14));
            ICharacterAttribute conAttribute = new CharacterAttribute(CharacterAttributeName.Constitution, new AttributeScore(2));
            ICharacterAttribute intAttribute = new CharacterAttribute(CharacterAttributeName.Intelligence, new AttributeScore(5));
            ICharacterAttribute wizAttribute = new CharacterAttribute(CharacterAttributeName.Wisdom, new AttributeScore(7));
            ICharacterAttribute chrAttribute = new CharacterAttribute(CharacterAttributeName.Charisma, new AttributeScore(9));

            //act
            IAttributeScore expectedStr = CharacterRace.Human.RacialAttributeAdjustment(strAttribute);
            IAttributeScore expectedDex = CharacterRace.Human.RacialAttributeAdjustment(dexAttribute);
            IAttributeScore expectedCon = CharacterRace.Human.RacialAttributeAdjustment(conAttribute);
            IAttributeScore expectedInt = CharacterRace.Human.RacialAttributeAdjustment(intAttribute);
            IAttributeScore expectedWiz = CharacterRace.Human.RacialAttributeAdjustment(wizAttribute);
            IAttributeScore expectedChr = CharacterRace.Human.RacialAttributeAdjustment(chrAttribute);

            //assert
            expectedStr.Should().Be(new AttributeScore(1));
            expectedDex.Should().Be(new AttributeScore(1));
            expectedCon.Should().Be(new AttributeScore(1));
            expectedInt.Should().Be(new AttributeScore(1));
            expectedWiz.Should().Be(new AttributeScore(1));
            expectedChr.Should().Be(new AttributeScore(1));
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnSpeed()
        {
            //arrange
            Speed expectedSpeed = new Speed(30);

            //assert
            CharacterRace.Human.Speed().Should().Be(expectedSpeed);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnSize()
        {
            //arrange
            ISize actualsSize = CharacterRace.Human.Size();

            //assert
            actualsSize.Should().Be(Size.Medium);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnHitPointBonus()
        {
            CharacterRace.Human.BonusHitPoints().Should().Be(new HitPoints(0));
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnProficiencies()
        {
            //arrange
            //act
            List<IProficiency> actualProfs = CharacterRace.Human.Proficiencies();

            //assert
            actualProfs.Count.Should().Be(0);
        }
    }
}
