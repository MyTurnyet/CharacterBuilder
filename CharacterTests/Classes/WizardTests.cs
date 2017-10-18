using System.Collections.Generic;
using System.Linq;
using Characters.Attributes;
using Characters.Classes;
using Characters.Dice;
using Characters.Physical;
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
            List<Proficiency> expectedProf = new List<Proficiency>
            {
                Proficiency.Dagger,
                Proficiency.Darts,
                Proficiency.Sling,
                Proficiency.Quarterstaff,
                Proficiency.LightCrossbow,
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
                Skill.Arcana,
                Skill.History,
                Skill.Insight,
                Skill.Investigation,
                Skill.Medicine,
                Skill.Religion
            };
            //act
            List<ISkill> actualSkills = CharacterClass.Wizard.Skills();
            //assert
            actualSkills.All(i => expectedSkills.Contains(i)).Should().BeTrue();
        }

    }
}
