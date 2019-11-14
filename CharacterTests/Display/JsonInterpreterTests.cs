using System;
using Characters.Attributes;
using Characters.Display;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Display
{
    [TestClass]
    public class JsonIterpreterTests    
    {
        [TestMethod]
        public void ShouldSerializeObject()
        {
            IJsonInterpreter wrapper = new JsonWrapper();
            EmptyAttributeSet attributeSet = new EmptyAttributeSet();
            string expectedJson = "{\"characterAttributes\":[{\"characterAttribute\":\"STR\",\"value\":0},{\"characterAttribute\":\"DEX\",\"value\":0},{\"characterAttribute\":\"CON\",\"value\":0},{\"characterAttribute\":\"INT\",\"value\":0},{\"characterAttribute\":\"WIS\",\"value\":0},{\"characterAttribute\":\"CHR\",\"value\":0},]}";

            string actualJson = wrapper.Serialize(attributeSet);

            actualJson.Should().Be(expectedJson);
        }
    }
}
