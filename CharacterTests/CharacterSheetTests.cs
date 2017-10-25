using System.Collections.Generic;
using System.Linq;
using Characters;
using Characters.Attributes;
using Characters.Classes;
using Characters.Display;
using Characters.Physical;
using Characters.Physical.Proficiencies;
using Characters.Races;
using CharacterTests.Fakes;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests
{
    [TestClass]
    public class CharacterSheetTests
    {
        private ICharacterSheet _characterSheet;
        private readonly IAttributeSet _attributeSet = new FakeAttributeSet();

        [TestInitialize]
        public void Setup()
        {
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldEquateAttributes()
        {
            //assign
            _characterSheet = new CharacterSheet(CharacterClass.Fighter, CharacterRace.WoodElf, _attributeSet);

            //act
            ICharacterAttribute actualAttribute = _characterSheet.Attribute(CharacterAttributeName.Dexterity);
            //assert
            actualAttribute.Should().Be(new DexterityAttribute());
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldApplyRacialBonusToAttributes()
        {
            //arrange
            AttributeScore expectedDexterityScore = new AttributeScore(2);
            AttributeScore expectedWisdomScore = new AttributeScore(1);
            _characterSheet = new CharacterSheet(CharacterClass.Fighter, CharacterRace.WoodElf, _attributeSet);
            //assert
            _characterSheet.Attribute(CharacterAttributeName.Strength).Score().Should().Be(new StrengthAttribute().Score());

            _characterSheet.Attribute(CharacterAttributeName.Dexterity).Score().Should().Be(expectedDexterityScore);
            _characterSheet.Attribute(CharacterAttributeName.Constitution).Score().Should().Be(new ConstitutionAttribute().Score());
            _characterSheet.Attribute(CharacterAttributeName.Intelligence).Score().Should().Be(new IntellegenceAttribute().Score());
            _characterSheet.Attribute(CharacterAttributeName.Wisdom).Score().Should().Be(expectedWisdomScore);
            _characterSheet.Attribute(CharacterAttributeName.Charisma).Score().Should().Be(new CharismaAttribute().Score());
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnStartingHitPointsForHillDwarfFighter()
        {
            //arrange
            IHitPoints expectedHitPoints = new HitPoints(6);
            _characterSheet = new CharacterSheet(CharacterClass.Fighter, CharacterRace.HillDwarf, _attributeSet);

            //act
            IHitPoints actualHitPoints = _characterSheet.HitPoints();

            //assert
            actualHitPoints.Should().Be(expectedHitPoints);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnStartingHitPointsForMountainDwarfFighter()
        {
            //arrange
            IHitPoints expectedHitPoints = new HitPoints(5);
            _characterSheet = new CharacterSheet(CharacterClass.Fighter, CharacterRace.MountainDwarf, _attributeSet);

            //act
            IHitPoints actualHitPoints = _characterSheet.HitPoints();

            //assert
            actualHitPoints.Should().Be(expectedHitPoints);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnStartingHitPointsForWoodElfWizard()
        {
            //arrange
            IHitPoints expectedHitPoints = new HitPoints(1);
            _characterSheet = new CharacterSheet(CharacterClass.Wizard, CharacterRace.WoodElf, _attributeSet);

            //act
            IHitPoints actualHitPoints = _characterSheet.HitPoints();

            //assert
            actualHitPoints.Should().Be(expectedHitPoints);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnStartingHitPointsForWoodElfFighter()
        {
            //arrange
            IHitPoints expectedHitPoints = new HitPoints(5);
            _characterSheet = new CharacterSheet(CharacterClass.Fighter, CharacterRace.WoodElf, _attributeSet);

            //act
            IHitPoints actualHitPoints = _characterSheet.HitPoints();

            //assert
            actualHitPoints.Should().Be(expectedHitPoints);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldShouldReturnProficienciesForDwarfFighter()
        {
            //assign
            _characterSheet = new CharacterSheet(CharacterClass.Fighter, CharacterRace.HillDwarf);
            List<IProficiency> expectedProficiencies = new List<IProficiency>
            {
                new Battleaxe(),
                new Handaxe(),
                new ThrowingHammer()  ,
                new Warhammer(),
                new BrewersSupplies(),
                new MasonsTools(),
                new SmithsTools(),
                new SimpleWeapons(),
                new MartialWeapons(),
                new AllArmor(),
                new AllShields()
            };

            //act
            List<IProficiency> actualProficiencies = _characterSheet.Proficiencies();
            //assert
            actualProficiencies.All(i => expectedProficiencies.Contains(i)).Should().BeTrue();
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldShouldReturnProficienciesForDwarfWizard()
        {
            //assign
            _characterSheet = new CharacterSheet(CharacterClass.Wizard, CharacterRace.HillDwarf);
            List<IProficiency> expectedProficiencies = new List<IProficiency>
            {
                new Battleaxe(),
                new Handaxe(),
                new ThrowingHammer(),
                new Warhammer(),
                new BrewersSupplies(),
                new MasonsTools(),
                new SmithsTools(),
                new Dagger(),
                new Darts(),
                new Sling(),
                new Quarterstaff(),
                new LightCrossbow(),
            };

            //act
            List<IProficiency> actualProficiencies = _characterSheet.Proficiencies();
            //assert
            actualProficiencies.All(i => expectedProficiencies.Contains(i)).Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnCorrectStatsList()
        {
            //assign
            _characterSheet = new CharacterSheet(CharacterClass.Wizard, CharacterRace.HillDwarf, new FakeAttributeSet());
            TextObj expectedTextOf = new TextObj("This Works!");
            //act
            ITextObj actualTextOf = _characterSheet.StatsList();
            //assert
            actualTextOf.Should().Be(expectedTextOf);

        }

    }
}
