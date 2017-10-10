using System.Text;
using Characters;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests
{
    [TestClass]
    public class TextOfTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldEquate()
        {
            //arrange
            TextOf textOf1 = new TextOf("Test");
            TextOf textOf2 = new TextOf("Test");

            //assert
            textOf2.Should().Be(textOf1);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldTakeStringBuilder()
        {
            //arrange
            StringBuilder sb = new StringBuilder();
            string expectedText = "Test of Stringbuilder";
            TextOf textOf1 = new TextOf(expectedText);

            //act
            textOf1.AddToStringBuilder(sb);

            //assert
            sb.ToString().Should().Be(expectedText);
        }
    }
}
