using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EverTests
{
    [TestClass]
    public class CharacterTests
    {
        [TestMethod]
        public void ConfirmDefaultHitPoints()
        {
            var character = new Character();

            Assert.AreEqual(character.hitPoints, 5);
        }

        [TestMethod]
        public void ConfirmDefaultArmorClass()
        {
            var character = new Character();

            Assert.AreEqual(character.armorClass, 10);
        }
    }
}