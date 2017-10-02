using System.Collections.Generic;
using System.Linq;
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
            Die expecteDie = Die.d6;
            //act
            Die hitDie = wizard.HitDie();
            //assert
            hitDie.Should().Be(expecteDie);
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
            List<Proficiency> actualProfs = CharacterClass.Wizard.Proficiencies();

            //assert
            actualProfs.All(i => expectedProf.Contains(i)).Should().BeTrue();
        }

    }
}
