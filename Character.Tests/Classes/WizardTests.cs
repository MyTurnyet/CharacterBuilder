using System.Collections.Generic;
using System.Linq;
using Character.Attributes;
using Character.Classes;
using Character.Dice;
using Character.Physical;
using Character.Physical.Proficiencies;
using Character.Physical.Skills;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Character.Tests.Classes
{
    [TestClass]
    public class WizardTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldMatchHitDie()
        {
            //arrange
            Wizard wizard = new Wizard();
            IDie expecteDie =new D6Die();
            //act
            IHitDie hitDie = wizard.HitDie();
            //assert
            hitDie.Should().Be(expecteDie);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldMatchBaseHitPoints()
        {
            //arrange
            Wizard wizard = new Wizard();
            IHitPoints expectHitPoints = new HitPoints(6);
            //act
            IHitPoints baseHitPoints = wizard.BaseHitPoints();
            //assert
            baseHitPoints.Should().Be(expectHitPoints);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnProficiencies()
        {
            //arrange
            List<IProficiency> expectedProf = new List<IProficiency>
            {
                new Dagger(),
                new Darts(),
                new Sling(),
                new Quarterstaff(),
                new LightCrossbow()
            };
            //act
            List<IProficiency> actualProfs = new Wizard().Proficiencies();

            //assert
            actualProfs.All(i => expectedProf.Contains(i)).Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnSavingThrows()
        {
            //assign
            List<ISavingThrowAttribute> expectedThrowAttributes = new List<ISavingThrowAttribute>
            {
                SavingThrowAttribute.Intellegence,
                SavingThrowAttribute.Wisdom
            };
            //act
            List<ISavingThrowAttribute> savingThrows = new Wizard().SavingThrows();
            //assert
            savingThrows.All(i => expectedThrowAttributes.Contains(i)).Should().BeTrue();
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnSkillList()
        {
            //assign
            List<ISkill> expectedSkills = new List<ISkill>
            {
                new Arcana(),
                new History(),
                new Insight(),
                new Investigation(),
                new Medicine(),
                new Religion()
            };
            //act
            List<ISkill> actualSkills = new Wizard().Skills();
            //assert
            actualSkills.All(i => expectedSkills.Contains(i)).Should().BeTrue();
        }

    }
}
