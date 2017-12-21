using System.Text;
using Characters.Display;
using Characters.Physical.Proficiencies;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Physical
{
    [TestClass]
    public class ProficiencyTests
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
            allArmor.Name().Should().Be(new TextObj("All Armor"));
            allShields.Name().Should().Be(new TextObj("All Shields"));
            battleaxe.Name().Should().Be(new TextObj("Battleaxe"));
            brewersSupplies.Name().Should().Be(new TextObj("Brewer's Supplies"));
            dagger.Name().Should().Be(new TextObj("Dagger"));
            darts.Name().Should().Be(new TextObj("Darts"));
            handaxe.Name().Should().Be(new TextObj("Handaxe"));
            lightArmor.Name().Should().Be(new TextObj("Light Armor"));
            lightCrossbow.Name().Should().Be(new TextObj("Light Crossbow"));
            longbow.Name().Should().Be(new TextObj("Longbow"));
            longsword.Name().Should().Be(new TextObj("Longsword"));
            martialWeapons.Name().Should().Be(new TextObj("Martial Weapons"));
            masonsTools.Name().Should().Be(new TextObj("Mason's Tools"));
            mediumArmor.Name().Should().Be(new TextObj("Medium Armor"));
            quarterstaff.Name().Should().Be(new TextObj("Quarterstaff"));
            shortbow.Name().Should().Be(new TextObj("Shortbow"));
            shortsword.Name().Should().Be(new TextObj("Shortsword"));
            simpleWeapons.Name().Should().Be(new TextObj("Simple Weapons"));
            sling.Name().Should().Be(new TextObj("Sling"));
            smithsTools.Name().Should().Be(new TextObj("Smith's Tools"));
            throwingHammer.Name().Should().Be(new TextObj("Throwing Hammer"));
            warhammer.Name().Should().Be(new TextObj("Warhammer"));
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldEquate()
        {
            //arrange
            IEquateableProficiency expectedThrowingHammer = new ThrowingHammer();
            IEquateableProficiency actualThrowingHammer = new ThrowingHammer();
            //assert
            actualThrowingHammer.Should().Be(expectedThrowingHammer);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldtestName()
        {
            //arrange
            IProficiency throwingHammer = new ThrowingHammer();
            string expectedProficiencyJson = "Throwing Hammer";
            //act
            StringBuilder stringBuilder = new StringBuilder();
            throwingHammer.AddJsonToStringbuilder(stringBuilder);
            //assert
            stringBuilder.ToString().Should().Be(expectedProficiencyJson);
        }
    }
}
