using System;
using System.Collections.Generic;
using System.Linq;
using Characters.Attributes;
using Characters.Physical.Skills;
using CharacterTests.Fakes;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Physical.Skills
{
    [TestClass]
    public class BaseSkillSetTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnSkillsList()
        {
            //arrange
            FakeAttributeSet fakeAttributeSet = new FakeAttributeSet();
            BaseSkillSet baseSkillSet = new BaseSkillSet(fakeAttributeSet);
            //act
            IEnumerable<ISkill> skillList = baseSkillSet.Skills();
            //assert
            skillList.Count().Should().Be(18);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnSkillswithCorrectValues()
        {
            //arrange
            FakeAttributeSet fakeAttributeSet = new FakeAttributeSet();
            BaseSkillSet baseSkillSet = new BaseSkillSet(fakeAttributeSet);
            //act
            List<ISkill> skillList = baseSkillSet.Skills();
            //assert
            skillList[0].SkillBonus().Should().Be(new AttributeScore(0));
        }

    }
}
