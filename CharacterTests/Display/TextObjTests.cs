using Characters.Display;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Display
{
    [TestClass]
    public class TextObjTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldEquate()
        {
            //arrange
            TextObj textOf1 = new TextObj("Test");
            TextObj textOf2 = new TextObj("Test");

            //assert
            textOf2.Should().Be(textOf1);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldEquateHashcode()
        {
            //arrange
            TextObj textOf1 = new TextObj("Test");
            TextObj textOf2 = new TextObj("Test");

            //assert
            textOf2.GetHashCode().Should().Be(textOf1.GetHashCode());
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnStringEmptyWhenUsingEmptyConstructor()
        {
            //assign
            TextObj expectedTextObj = new TextObj(string.Empty);
            TextObj actualTextObj = new TextObj();

            //assert
            actualTextObj.Should().Be(expectedTextObj);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldAppendTextOfObjects()
        {
            //arrange
            ITextObj textObj = new TextObj("test");
            ITextObj textObjAppend = new TextObj("output");
            ITextObj expected = new TextObj("testoutput");
            //act
            ITextObj actual = textObj.Append(textObjAppend);
            //assert
            actual.Should().Be(expected);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnNewLine()
        {
            //arrange
            ITextObj newlineTextObj = new NewLineTextObj();
            ITextObj expectedTextObj = new TextObj("\r\n");
            //assert
            newlineTextObj.Should().Be(expectedTextObj);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldAppendNewLine()
        {
            //arrange
            ITextObj textObj = new TextObj("test");
            ITextObj newLineObj = new NewLineTextObj();
            ITextObj expectedTextObj = new TextObj("test\r\ntest");
            //act
            ITextObj actualTextObj = textObj.Append(newLineObj).Append(textObj);
            //assert
            actualTextObj.Should().Be(expectedTextObj);
        }
    }
}

