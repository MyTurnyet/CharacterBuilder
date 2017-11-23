using System.Collections.Generic;
using Characters.Attributes;
using Characters.Physical;
using Characters.Physical.Proficiencies;
using Characters.Races;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Races
{
    [TestClass]
    public class HalflingLightFootTests
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
            IAttributeScore expectedStr = CharacterRace.HalflingLightfoot.RacialAttributeAdjustment(strAttribute);
            IAttributeScore expectedDex = CharacterRace.HalflingLightfoot.RacialAttributeAdjustment(dexAttribute);
            IAttributeScore expectedCon = CharacterRace.HalflingLightfoot.RacialAttributeAdjustment(conAttribute);
            IAttributeScore expectedInt = CharacterRace.HalflingLightfoot.RacialAttributeAdjustment(intAttribute);
            IAttributeScore expectedWiz = CharacterRace.HalflingLightfoot.RacialAttributeAdjustment(wizAttribute);
            IAttributeScore expectedChr = CharacterRace.HalflingLightfoot.RacialAttributeAdjustment(chrAttribute);

            //assert
            expectedStr.Should().Be(new AttributeScore(0));
            expectedDex.Should().Be(new AttributeScore(2));
            expectedCon.Should().Be(new AttributeScore(0));
            expectedInt.Should().Be(new AttributeScore(0));
            expectedWiz.Should().Be(new AttributeScore(0));
            expectedChr.Should().Be(new AttributeScore(1));
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnSpeed()
        {
            //arrange
            ISpeed expectedSpeed = new Speed(25);

            //act
            ISpeed actualsSpeed = CharacterRace.HalflingLightfoot.Speed();
            //assert
            actualsSpeed.Should().Be(expectedSpeed);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnProficiencies()
        {
            //act
            List<IProficiency> actualProfs = CharacterRace.HalflingLightfoot.Proficiencies();

            //assert
            actualProfs.Count.Should().Be(0);
        }

    }
}
