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
    public class HighElfTests
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
            IAttributeScore expectedStr = CharacterRace.HighElf.RacialAttributeAdjustment(strAttribute);
            IAttributeScore expectedDex = CharacterRace.HighElf.RacialAttributeAdjustment(dexAttribute);
            IAttributeScore expectedCon = CharacterRace.HighElf.RacialAttributeAdjustment(conAttribute);
            IAttributeScore expectedInt = CharacterRace.HighElf.RacialAttributeAdjustment(intAttribute);
            IAttributeScore expectedWiz = CharacterRace.HighElf.RacialAttributeAdjustment(wizAttribute);
            IAttributeScore expectedChr = CharacterRace.HighElf.RacialAttributeAdjustment(chrAttribute);

            //assert
            expectedStr.Should().Be(new AttributeScore(0));
            expectedDex.Should().Be(new AttributeScore(2));
            expectedCon.Should().Be(new AttributeScore(0));
            expectedInt.Should().Be(new AttributeScore(1));
            expectedWiz.Should().Be(new AttributeScore(0));
            expectedChr.Should().Be(new AttributeScore(0));
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnSize()
        {
            //arrange
            ISize actualsSize = CharacterRace.HighElf.Size();

            //assert
            actualsSize.Should().Be(Size.Medium);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnHitPointBonus()
        {
            CharacterRace.HighElf.BonusHitPoints().Should().Be(new HitPoints(0));
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnProficiencies()
        {
            //arrange
            List<IProficiency> expectedProf = new List<IProficiency>
            {
                Proficiency.Longbow,
                Proficiency.Longsword,
                Proficiency.Shortbow,
                Proficiency.Shortsword
            };
            //act
            List<IProficiency> actualProfs = CharacterRace.HighElf.Proficiencies();

            //assert
            actualProfs.All(i => expectedProf.Contains(i)).Should().BeTrue();
        }
    }
}
