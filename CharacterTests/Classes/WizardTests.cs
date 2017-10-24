using System.Collections.Generic;
using System.Linq;
using Characters.Attributes;
using Characters.Classes;
using Characters.Dice;
using Characters.Physical;
using Characters.Physical.Proficiencies;
using Characters.Physical.Skills;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Classes
{
    [TestClass]
    public class WizardTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldMatchHitDie()
        {
            //arrange
            Wizard wizard = new Wizard();
            IDie expecteDie = Die.d6;
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
            List<IProficiency> actualProfs = CharacterClass.Wizard.Proficiencies();

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
            List<ISavingThrowAttribute> savingThrows = CharacterClass.Wizard.SavingThrows();
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
            List<ISkill> actualSkills = CharacterClass.Wizard.Skills();
            //assert
            actualSkills.All(i => expectedSkills.Contains(i)).Should().BeTrue();
        }

    }
}
