using System.Collections.Generic;
using System.Linq;
using Characters;
using Characters.Attributes;
using Characters.Classes;
using Characters.Display;
using Characters.Physical;
using Characters.Physical.Proficiencies;
using Characters.Physical.Skills;
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
            _characterSheet = new CharacterSheet(new Fighter(), new WoodElf(), _attributeSet);

            //act
            ICharacterAttribute actualAttribute = _characterSheet.Attribute(CharacterAttributeName.Dexterity);
            //assert
            actualAttribute.Should().Be(new DexterityAttribute());
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldApplyRacialBonusToAttributes()
        {
            //arrange
            AttributeScore expectedDexterityScore = new AttributeScore(12);
            AttributeScore expectedWisdomScore = new AttributeScore(11);
            _characterSheet = new CharacterSheet(new Fighter(), new WoodElf(), _attributeSet);
            //assert
            _characterSheet.Attribute(CharacterAttributeName.Strength).Score().Should().Be(new FakeAttribute().Score());

            _characterSheet.Attribute(CharacterAttributeName.Dexterity).Score().Should().Be(expectedDexterityScore);
            _characterSheet.Attribute(CharacterAttributeName.Constitution).Score().Should().Be(new FakeAttribute().Score());
            _characterSheet.Attribute(CharacterAttributeName.Intelligence).Score().Should().Be(new FakeAttribute().Score());
            _characterSheet.Attribute(CharacterAttributeName.Wisdom).Score().Should().Be(expectedWisdomScore);
            _characterSheet.Attribute(CharacterAttributeName.Charisma).Score().Should().Be(new FakeAttribute().Score());
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnStartingHitPointsForHillDwarfFighter()
        {
            //arrange
            IHitPoints expectedHitPoints = new HitPoints(11);
            _characterSheet = new CharacterSheet(new Fighter(), new HillDwarf(), _attributeSet);

            //act
            IHitPoints actualHitPoints = _characterSheet.HitPoints();

            //assert
            actualHitPoints.Should().Be(expectedHitPoints);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnStartingHitPointsForMountainDwarfFighter()
        {
            //arrange
            IHitPoints expectedHitPoints = new HitPoints(10);
            _characterSheet = new CharacterSheet(new Fighter(), new MountainDwarf(), _attributeSet);

            //act
            IHitPoints actualHitPoints = _characterSheet.HitPoints();

            //assert
            actualHitPoints.Should().Be(expectedHitPoints);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnStartingHitPointsForWoodElfWizard()
        {
            //arrange
            IHitPoints expectedHitPoints = new HitPoints(6);
            _characterSheet = new CharacterSheet(new Wizard(), new WoodElf(), _attributeSet);

            //act
            IHitPoints actualHitPoints = _characterSheet.HitPoints();

            //assert
            actualHitPoints.Should().Be(expectedHitPoints);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnStartingHitPointsForWoodElfFighter()
        {
            //arrange
            IHitPoints expectedHitPoints = new HitPoints(10);
            _characterSheet = new CharacterSheet(new Fighter(), new WoodElf(), _attributeSet);

            //act
            IHitPoints actualHitPoints = _characterSheet.HitPoints();

            //assert
            actualHitPoints.Should().Be(expectedHitPoints);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldShouldReturnProficienciesForDwarfFighter()
        {
            //assign
            _characterSheet = new CharacterSheet(new Fighter(), new HillDwarf(), new FakeAttributeSet());
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
            _characterSheet = new CharacterSheet(new Wizard(), new HillDwarf(), new FakeAttributeSet());
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
            _characterSheet = new CharacterSheet(new Wizard(), new HillDwarf(), new FakeAttributeSet());
            TextObj expectedTextOf = new TextObj("This Works!");
            //act
            ITextObj actualTextOf = _characterSheet.StatsList();
            //assert
            actualTextOf.Should().Be(expectedTextOf);

        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnInvestigationSkillsForHumanWizard()
        {
            //arrange
            _characterSheet = new CharacterSheet(new Wizard(), new Human(), new FakeWizardAttributeSet());
            ICharacterAttribute intAtt = _characterSheet.Attribute(CharacterAttributeName.Intelligence);
            //assert
            List<ISkill> actualSkills = _characterSheet.Skills();
            actualSkills.First(item => item.Name().Equals(new TextObj("Investigation"))).SkillBonus().Should().Be(new AttributeScore(0));
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnMedicineSkillsForHumanWizard()
        {
            //arrange
            _characterSheet = new CharacterSheet(new Wizard(), new Human(), new FakeWizardAttributeSet());
            ICharacterAttribute intAtt = _characterSheet.Attribute(CharacterAttributeName.Intelligence);
            //assert
            List<ISkill> actualSkills = _characterSheet.Skills();
            actualSkills.First(item => item.Name().Equals(new TextObj("Medicine"))).SkillBonus().Should().Be(new AttributeScore(2));
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnActivatedMedicineSkillForHumanWizard()
        {
            //arrange
            _characterSheet = new CharacterSheet(new Wizard(), new Human(), new FakeWizardAttributeSet());
            ICharacterAttribute wisdomAtt = _characterSheet.Attribute(CharacterAttributeName.Wisdom);
            Medicine medicine = new Medicine((WisdomAttribute)wisdomAtt,true);
            //act
            _characterSheet.ActivateSkill(medicine);
            //assert
            List<ISkill> actualSkills = _characterSheet.Skills();
            actualSkills.First(item => item.Name().Equals(new TextObj("Medicine"))).SkillBonus().Should().Be(new AttributeScore(4));
        }
    
    }
}
