using Characters;
using Characters.Classes;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Classes
{
    [TestClass]
    public class CharacterClassTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldEquate()
        {
            //assign
            ICharacterClass classFighter = CharacterClass.Fighter;
            ICharacterClass classFighter2 = CharacterClass.Fighter;

            //assert
            classFighter2.Should().Be(classFighter);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate()
        {
            //assign
            ICharacterClass classFighter = CharacterClass.Fighter;
            ICharacterClass classWizard = CharacterClass.Wizard;

            //assert
            classWizard.Should().NotBe(classFighter);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName()
        {
            //arrange
            ICharacterClass classFighter = CharacterClass.Fighter;
            //act
            ITextOf actualName = classFighter.Name();
            //assert
            actualName.Should().Be(new TextOf("Fighter"));
        }


    }
}
