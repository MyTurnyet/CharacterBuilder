using System.Collections.Generic;
using System.Linq;
using Characters.Attributes;
using Characters.Physical;
using Characters.Races;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Races
{
    [TestClass]
    public class WoodElfTests
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
            IAttributeScore expectedStr = CharacterRace.WoodElf.RacialAttributeAdjustment(strAttribute);
            IAttributeScore expectedDex = CharacterRace.WoodElf.RacialAttributeAdjustment(dexAttribute);
            IAttributeScore expectedCon = CharacterRace.WoodElf.RacialAttributeAdjustment(conAttribute);
            IAttributeScore expectedInt = CharacterRace.WoodElf.RacialAttributeAdjustment(intAttribute);
            IAttributeScore expectedWiz = CharacterRace.WoodElf.RacialAttributeAdjustment(wizAttribute);
            IAttributeScore expectedChr = CharacterRace.WoodElf.RacialAttributeAdjustment(chrAttribute);

            //assert
            expectedStr.Should().Be(new AttributeScore(0));
            expectedDex.Should().Be(new AttributeScore(2));
            expectedCon.Should().Be(new AttributeScore(0));
            expectedInt.Should().Be(new AttributeScore(0));
            expectedWiz.Should().Be(new AttributeScore(1));
            expectedChr.Should().Be(new AttributeScore(0));
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnSpeed()
        {
            //arrange
            ISpeed expectedSpeed = new Speed(35);

            //act
            ISpeed actualsSpeed = CharacterRace.WoodElf.Speed();
            //assert
            actualsSpeed.Should().Be(expectedSpeed);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnProficiencies()
        {
            //arrange
            List<Proficiency> expectedProf = new List<Proficiency>
            {
                Proficiency.Longbow,
                Proficiency.Longsword,
                Proficiency.Shortbow,
                Proficiency.Shortsword
            };
            //act
            List<Proficiency> actualProfs = CharacterRace.WoodElf.Proficiencies();

            //assert
            actualProfs.All(i => expectedProf.Contains(i)).Should().BeTrue();
        }
    }
}
