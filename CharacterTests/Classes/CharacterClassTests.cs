using Characters.Classes;
using Characters.Display;
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
            ICharacterClass classFighter = new Fighter();
            ICharacterClass classFighter2 = new Fighter();

            //assert
            classFighter2.Should().Be(classFighter);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate()
        {
            //assign
            ICharacterClass classFighter = new Fighter();
            ICharacterClass classWizard = new Wizard();

            //assert
            classWizard.Should().NotBe(classFighter);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName()
        {
            //arrange
            ICharacterClass classFighter = new Fighter();
            //act
            ITextObj actualName = classFighter.Name();
            //assert
            actualName.Should().Be(new TextObj("Fighter"));
        }


    }
}
