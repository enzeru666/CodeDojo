using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EverTests
{
    [TestClass]
    public class CharacterTests
    {
        private Character character;

        [TestInitialize]
        public void Setup() => 
            character = new Character("Franko");

        [TestMethod]
        public void CharacterMustHaveAName() => 
            Assert.AreEqual("Franko", character.Name);

        [TestMethod]
        public void StartsWithDefaultHitPoints() => 
            Assert.AreEqual(5, character.hitPoints);

        [TestMethod]
        public void StartsWithDefaultArmourPoints() => 
            Assert.AreEqual(10, character.armorClass);
        
        [TestMethod]
        public void AlignmentDefaultsToNeutral() => 
            Assert.AreEqual(Alignment.Neutral, character.Alignment);

        [TestMethod]
        public void AlignmentMayBeChanged() => 
            Assert.AreEqual(Alignment.Evil, character.Alignment = Alignment.Evil);
    }
}