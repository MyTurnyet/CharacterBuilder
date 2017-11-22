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
            IAttributeSet fakeAttributeSet = new FakeWizardAttributeSet();
            BaseSkillSet baseSkillSet = new BaseSkillSet(fakeAttributeSet);
            //act
            List<ISkill> skillList = baseSkillSet.Skills();
            //assert
            skillList[0].SkillBonus().Should().Be(new AttributeScore(-1));
            skillList[1].SkillBonus().Should().Be(new AttributeScore(-1));
            skillList[3].SkillBonus().Should().Be(new AttributeScore(0));
            skillList[4].SkillBonus().Should().Be(new AttributeScore(0));
            skillList[5].SkillBonus().Should().Be(new AttributeScore(0));
            skillList[6].SkillBonus().Should().Be(new AttributeScore(0));
            skillList[7].SkillBonus().Should().Be(new AttributeScore(0));
            skillList[8].SkillBonus().Should().Be(new AttributeScore(0));
            skillList[9].SkillBonus().Should().Be(new AttributeScore(0));
            skillList[10].SkillBonus().Should().Be(new AttributeScore(0));
            skillList[11].SkillBonus().Should().Be(new AttributeScore(0));
            skillList[12].SkillBonus().Should().Be(new AttributeScore(0));
            skillList[13].SkillBonus().Should().Be(new AttributeScore(2));
            skillList[14].SkillBonus().Should().Be(new AttributeScore(2));
            skillList[15].SkillBonus().Should().Be(new AttributeScore(2));
            skillList[16].SkillBonus().Should().Be(new AttributeScore(2));
            skillList[17].SkillBonus().Should().Be(new AttributeScore(2));
        }

    }
}
