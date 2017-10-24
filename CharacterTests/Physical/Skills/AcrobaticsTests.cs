using System;
using Characters.Attributes;
using Characters.Display;
using Characters.Physical.Skills;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Physical.Skills
{
    [TestClass]
    public class AcrobaticsTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName()
        {
            //assign
            ISkill actualSkillBase = new Acrobatics();
            //act
            ITextOf name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextOf("Acrobatics"));
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnBaseAttribute()
        {
            //arrange
            ISkill acrobatics = new Acrobatics();
            ICharacterAttribute dexterityAttribute = new DexterityAttribute();
            //act
            ICharacterAttribute actualAttribute = acrobatics.BaseAttribute();

            //assert
            actualAttribute.Should().Be(dexterityAttribute);
        }
    }
}
