﻿using System.Collections.Generic;
using System.Linq;
using Characters;
using Characters.Attributes;
using Characters.Classes;
using Characters.Display;
using Characters.Physical;
using Characters.Physical.Proficiencies;
using Characters.Races;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests
{
    [TestClass]
    public class CharacterSheetTests
    {
        private ICharacterSheet _characterSheet;
        private IAttributeSet _attributeSet;
        private ICharacterAttribute _strAttribute;
        private ICharacterAttribute _dexAttribute;
        private ICharacterAttribute _conAttribute;
        private ICharacterAttribute _intAttribute;
        private ICharacterAttribute _wizAttribute;
        private ICharacterAttribute _chrAttribute;

        [TestInitialize]
        public void Setup()
        {
            SetupAttributes();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldEquateAttributes()
        {
            //assign
            _characterSheet = new CharacterSheet(CharacterClass.Fighter, CharacterRace.WoodElf, _attributeSet);

            //act
            ICharacterAttribute actualAttribute = _characterSheet.Attribute(CharacterAttributeName.Dexterity);
            //assert
            actualAttribute.Should().Be(_dexAttribute);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldApplyRacialBonusToAttributes()
        {
            //arrange
            AttributeScore expectedDexterityScore = new AttributeScore(12);
            AttributeScore expectedWisdomScore = new AttributeScore(9);
            _characterSheet = new CharacterSheet(CharacterClass.Fighter, CharacterRace.WoodElf, _attributeSet);
            //assert
            _characterSheet.Attribute(CharacterAttributeName.Strength).Score().Should().Be(_strAttribute.Score());

            _characterSheet.Attribute(CharacterAttributeName.Dexterity).Score().Should().Be(expectedDexterityScore);
            _characterSheet.Attribute(CharacterAttributeName.Constitution).Score().Should().Be(_conAttribute.Score());
            _characterSheet.Attribute(CharacterAttributeName.Intelligence).Score().Should().Be(_intAttribute.Score());
            _characterSheet.Attribute(CharacterAttributeName.Wisdom).Score().Should().Be(expectedWisdomScore);
            _characterSheet.Attribute(CharacterAttributeName.Charisma).Score().Should().Be(_chrAttribute.Score());
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnStartingHitPointsForHillDwarfFighter()
        {
            //arrange
            IHitPoints expectedHitPoints = new HitPoints(12);
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
            IHitPoints expectedHitPoints = new HitPoints(11);
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
            IHitPoints expectedHitPoints = new HitPoints(7);
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
            IHitPoints expectedHitPoints = new HitPoints(11);
            _characterSheet = new CharacterSheet(CharacterClass.Fighter, CharacterRace.WoodElf, _attributeSet);

            //act
            IHitPoints actualHitPoints = _characterSheet.HitPoints();

            //assert
            actualHitPoints.Should().Be(expectedHitPoints);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnStatsBlock()
        {
            //arrange
            _characterSheet = new CharacterSheet();
            ITextOf expectedText = new TextOf("Test Stats");
            //act
            ITextOf actualTextOf = _characterSheet.StatsList();

            //assert
            actualTextOf.Should().Be(expectedText);
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

        //[TestMethod, TestCategory("Unit")]
        //public void ShouldReturnCorrectStatsList()
        //{
        //    //assign
        //    _characterSheet = new CharacterSheet(CharacterClass.Wizard, CharacterRace.HillDwarf,_attributeSet);
        //    TextOf expectedTextOf = new TextOf("Strength: 10\r\nDexterity: 10");
        //    //act
        //    ITextOf actualTextOf = _characterSheet.StatsList();
        //    //assert
        //    actualTextOf.Should().Be(expectedTextOf);

        //}


        #region Helper Methods
        private void SetupAttributes()
        {
            _strAttribute = new StrengthAttribute(new AttributeScore(16));
            _dexAttribute = new DexterityAttribute(new AttributeScore(10));
            _conAttribute = new ConstitutionAttribute(new AttributeScore(13));
            _intAttribute = new IntellegenceAttribute(new AttributeScore(14));
            _wizAttribute = new WisdomAttribute(new AttributeScore(8));
            _chrAttribute = new CharismaAttribute(new AttributeScore(6));
            _attributeSet = new AttributeSet();
            _attributeSet.MatchesName(CharacterAttributeName.Strength).Set(_strAttribute.Score());
            _attributeSet.MatchesName(CharacterAttributeName.Dexterity).Set(_dexAttribute.Score());
            _attributeSet.MatchesName(CharacterAttributeName.Constitution).Set(_conAttribute.Score());
            _attributeSet.MatchesName(CharacterAttributeName.Intelligence).Set(_intAttribute.Score());
            _attributeSet.MatchesName(CharacterAttributeName.Wisdom).Set(_wizAttribute.Score());
            _attributeSet.MatchesName(CharacterAttributeName.Charisma).Set(_chrAttribute.Score());
        }
        #endregion Helper Methods
    }
}
