using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    public class FighterTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldMatchHitDie()
        {
            //arrange
            Fighter fighter = new Fighter();
            IDie expecteDie = new D10Die();
            //act
            IHitDie hitDie = fighter.HitDie();
            //assert
            hitDie.Should().Be(expecteDie);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnHitPointsFromHitDie()
        {
            //arrange
            ICharacterClass fighter = new Fighter();
            IHitPoints expectedHitPoints = new HitPoints(10);

            //act
            IHitPoints actualHitPoints = fighter.BaseHitPoints();
            //assert
            actualHitPoints.Should().Be(expectedHitPoints);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnProficiencies()
        {
            //arrange
            List<IProficiency> expectedProf = new List<IProficiency>
            {
                new SimpleWeapons(),
                new MartialWeapons(),
                new AllArmor(),
                new AllShields()
            };
            //act
            List<IProficiency> actualProfs = new Fighter().Proficiencies();

            //assert
            actualProfs.All(i => expectedProf.Contains(i)).Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnSavingThrows()
        {
            //assign
            List<ISavingThrowAttribute> expectedThrowAttributes = new List<ISavingThrowAttribute>
            {
                SavingThrowAttribute.Strength,
                SavingThrowAttribute.Constitution
            };
            //act
            List<ISavingThrowAttribute> savingThrows = new Fighter().SavingThrows();
            //assert
            savingThrows.All(i => expectedThrowAttributes.Contains(i)).Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnSkillList()
        {
            //assign
            List<ISkill> expectedSkills = new List<ISkill>
            {
                new Acrobatics(),
                new AnimalHandling(),
                new Athletics(),
                new History(),
                new Insight(),
                new Intimidation(),
                new Perception(),
                new Survival()
            };
            //act
            List<ISkill> actualSkills = new Fighter().Skills();
            //assert
            actualSkills.All(i => expectedSkills.Contains(i)).Should().BeTrue();
        }
    }
}
