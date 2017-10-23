using Characters.Physical.Proficiencies;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Physical
{
    [TestClass]
    public class EquatableProficiencyTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldEquate()
        {
            //assert
            AllArmor allArmor = new AllArmor();
            (allArmor == new AllArmor()).Should().BeTrue();
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate()
        {
            //assert
            AllArmor allArmor = new AllArmor();
            AllShields allShields = new AllShields();   
            (allArmor != allShields).Should().BeTrue();
        }
    }
}
