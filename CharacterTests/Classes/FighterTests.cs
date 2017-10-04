using System.Collections.Generic;
using System.Linq;
using Characters.Attributes;
using Characters.Classes;
using Characters.Dice;
using Characters.Physical;
using Characters.Races;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Classes
{
    [TestClass]
    public class FighterTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldMatchHitDie()
        {
            //arrange
            Fighter fighter = new Fighter();
            IDie expecteDie = Die.d10;
            //act
            IHitDie hitDie = fighter.HitDie();
            //assert
            hitDie.Should().Be(expecteDie);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnHitPointsFromHitDie()
        {
            //arrange
            Fighter fighter = new Fighter();
            HitPoints expectedHitPoints = new HitPoints(10);

            //act
            HitPoints actualHitPoints = fighter.BaseHitPoints();
            //assert
            actualHitPoints.Should().Be(expectedHitPoints);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnProficiencies()
        {
            //arrange
            List<Proficiency> expectedProf = new List<Proficiency>
            {
                Proficiency.SimpleWeapons,
                Proficiency.MartialWeapons,
                Proficiency.AllArmor,
                Proficiency.AllShields
            };
            //act
            List<Proficiency> actualProfs = CharacterClass.Fighter.Proficiencies();

            //assert
            actualProfs.All(i => expectedProf.Contains(i)).Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnSavingThrows()
        {
            //assign
            List<SavingThrowAttribute> expectedThrowAttributes = new List<SavingThrowAttribute>
            {
                SavingThrowAttribute.Strength,
                SavingThrowAttribute.Constitution
            };
            //act
            List<SavingThrowAttribute> savingThrows = CharacterClass.Fighter.SavingThrows();
            //assert
            savingThrows.All(i => expectedThrowAttributes.Contains(i)).Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnSkillList()
        {
            //assign
            List<Skill> expectedSkills = new List<Skill>
            {
                Skill.Acrobatics,
                Skill.AnimalHandling,
                Skill.Athletics,
                Skill.History,
                Skill.Insight,
                Skill.Intimidation,
                Skill.Perception,
                Skill.Survival
            };
            //act
            List<Skill> actualSkills = CharacterClass.Fighter.Skills();
            //assert
            actualSkills.All(i => expectedSkills.Contains(i)).Should().BeTrue();
        }

    }
}
