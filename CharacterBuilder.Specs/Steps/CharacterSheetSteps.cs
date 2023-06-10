using System;
using System.Collections.Generic;
using System.Text;
using Character;
using Character.Attributes;
using Character.Classes;
using Character.Races;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace CharacterBuilder.Specs.Steps
{
    [Binding]
    public class CharacterSheetSteps
    {
        private ICharacterRace _characterRace;
        private ICharacterClass _characterClass;
        private readonly IAttributeSet _attributeSet = new EmptyAttributeSet();
        private CharacterSheet _characterSheet;

        [Given(@"a Wood Elf")]
        public void GivenAWoodElf()
        {
            _characterRace = new WoodElf();
        }

        [Given(@"the class of Fighter")]
        public void GivenTheClassOfFighter()
        {
            _characterClass = new Fighter();
        }

        [Given(@"Attributes of Strength (.*)")]
        public void GivenAttributesOfStrength(int p0)
        {
            _attributeSet.SetAttribute(CharacterAttributeName.Strength, new AttributeScore(p0));
        }

        [Given(@"Attributes of Dexterity (.*)")]
        public void GivenAttributesOfDexterity(int p0)
        {
            _attributeSet.SetAttribute(CharacterAttributeName.Dexterity, new AttributeScore(p0));
        }

        [Given(@"Attributes of Intelligence (.*)")]
        public void GivenAttributesOfIntelligence(int p0)
        {
            _attributeSet.SetAttribute(CharacterAttributeName.Intelligence, new AttributeScore(p0));

        }

        [Given(@"Attributes of Wisdom (.*)")]
        public void GivenAttributesOfWisdom(int p0)
        {
            _attributeSet.SetAttribute(CharacterAttributeName.Wisdom, new AttributeScore(p0));

        }

        [Given(@"Attributes of Charisma (.*)")]
        public void GivenAttributesOfCharisma(int p0)
        {
            _attributeSet.SetAttribute(CharacterAttributeName.Charisma, new AttributeScore(p0));

        }

        [Given(@"Attributes of Constitution (.*)")]
        public void GivenAttributesOfConstitution(int p0)
        {
            _attributeSet.SetAttribute(CharacterAttributeName.Constitution, new AttributeScore(p0));

        }

        [When(@"the Character is created")]
        public void WhenTheCharacterIsCreated()
        {
            _characterSheet = new CharacterSheet(_characterClass, _characterRace, _attributeSet);
        }

        [Then(@"the JSON output will be correct")]
        public void ThenTheJSONOutputWillBeCorrect()
        {
            StringBuilder builder = new StringBuilder();
            _characterSheet.AddJsonToStringbuilder(builder);
            builder.ToString().Should().Be("{characterSheet:{\"race\":\"Wood Elf\",\"class\":\"Fighter\",\"characterAttributes\":[{\"characterAttribute\":\"STR\",\"value\":10},{\"characterAttribute\":\"DEX\",\"value\":10},{\"characterAttribute\":\"INT\",\"value\":10},{\"characterAttribute\":\"WIS\",\"value\":10},{\"characterAttribute\":\"CHR\",\"value\":10},{\"characterAttribute\":\"CON\",\"value\":10},],\"Proficiencies\":[\"Character.Physical.Proficiencies.SimpleWeapons\",\"Character.Physical.Proficiencies.MartialWeapons\",\"Character.Physical.Proficiencies.AllArmor\",\"Character.Physical.Proficiencies.AllShields\",\"Character.Physical.Proficiencies.Longsword\",\"Character.Physical.Proficiencies.Shortbow\",\"Character.Physical.Proficiencies.Shortsword\",\"Character.Physical.Proficiencies.Longbow\"],}}");
        }
    }
}