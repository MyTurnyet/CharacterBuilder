using Characters.Display;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Display
{
    [TestClass]
    public class TextOfTests
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
            //ITextObjAppendable textObj = new TextObj("test");
            //ITextObjAppendable textObjAppend = new TextObj("output");
            //ITextObjAppendable expected = new TextObj("testoutput");
            ////act
            ////ITextObjAppendable actual = textObj.Append(textObjAppend);
            ////assert
            //actual.Should().Be(expected);
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
            //ITextObjAppendable textObj = new TextObj("test");
            //ITextObj newLineObj = new NewLineTextObj();
            //ITextObjAppendable expectedTextObj = new TextObj("test\r\ntest");
            ////act
            //ITextObjAppendable actualTextObj = textObj.Append(newLineObj).Append(textObj);
            ////assert
            //actualTextObj.Should().Be(expectedTextObj);
        }
    }
}

