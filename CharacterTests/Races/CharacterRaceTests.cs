using Characters.Display;
using Characters.Races;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Races
{
    [TestClass]
    public class CharacterRaceTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldEquate()
        {
            //assign
            ICharacterRace race = CharacterRace.Human;
            ICharacterRace race2 = CharacterRace.Human;

            //assert
            race2.Should().Be(race);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate()
        {
            //assign
            ICharacterRace race = CharacterRace.Human;
            ICharacterRace race2 = CharacterRace.WoodElf;

            //assert
            race2.Should().NotBe(race);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName()
        {
            //assign
            ICharacterRace race = CharacterRace.Human;
         
            //assert
            ITextObj name = race.Name();
            name.Should().Be(new TextObj("Human"));
        }
    }
}
