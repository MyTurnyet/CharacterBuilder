using System;
using Characters;
using Characters.Physical.Proficiencies;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Physical
{
    [TestClass]
    public class IProficiencyTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnCorrectName()
        {
            //arrange
            AllArmor allArmor = new AllArmor();
            AllShields allShields = new AllShields();
            Battleaxe battleaxe = new Battleaxe();
            BrewersSupplies brewersSupplies = new BrewersSupplies();
            Dagger dagger = new Dagger();
            Darts darts = new Darts();
            Handaxe handaxe = new Handaxe();
            LightArmor lightArmor = new LightArmor();
            LightCrossbow lightCrossbow = new LightCrossbow();
            Longbow longbow = new Longbow();
            Longsword longsword = new Longsword();
            MartialWeapons martialWeapons = new MartialWeapons();
            MasonsTools masonsTools = new MasonsTools();
            MediumArmor mediumArmor = new MediumArmor();
            Quarterstaff quarterstaff = new Quarterstaff();
            Shortbow shortbow = new Shortbow();
            Shortsword shortsword = new Shortsword();
            SimpleWeapons simpleWeapons = new SimpleWeapons();
            Sling sling = new Sling();
            SmithsTools smithsTools = new SmithsTools();
            ThrowingHammer throwingHammer = new ThrowingHammer();
            Warhammer warhammer = new Warhammer();

            //assert
            allArmor.Name.Should().Be(new TextOf("All Armor"));
            allShields.Name.Should().Be(new TextOf("All Shields"));
            battleaxe.Name.Should().Be(new TextOf("Battleaxe"));
            brewersSupplies.Name.Should().Be(new TextOf("Brewer's Supplies"));
            dagger.Name.Should().Be(new TextOf("Dagger"));
            darts.Name.Should().Be(new TextOf("Darts"));
            handaxe.Name.Should().Be(new TextOf("Handaxe"));
            lightArmor.Name.Should().Be(new TextOf("Light Armor"));
            lightCrossbow.Name.Should().Be(new TextOf("Light Crossbow"));
            longbow.Name.Should().Be(new TextOf("Longbow"));
            longsword.Name.Should().Be(new TextOf("Longsword"));
            martialWeapons.Name.Should().Be(new TextOf("Martial Weapons"));
            masonsTools.Name.Should().Be(new TextOf("Mason's Tools"));
            mediumArmor.Name.Should().Be(new TextOf("Medium Armor"));
            quarterstaff.Name.Should().Be(new TextOf("Quarterstaff"));
            shortbow.Name.Should().Be(new TextOf("Shortbow"));
            shortsword.Name.Should().Be(new TextOf("Shortsword"));
            simpleWeapons.Name.Should().Be(new TextOf("Simple Weapons"));
            sling.Name.Should().Be(new TextOf("Sling"));
            smithsTools.Name.Should().Be(new TextOf("Smith's Tools"));
            throwingHammer.Name.Should().Be(new TextOf("Throwing Hammer"));
            warhammer.Name.Should().Be(new TextOf("Warhammer"));
        }
    }
}
