using EverCraft;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EverTests
{
    [TestClass]
    public class ActionTests
    {
        [TestMethod]
        public void IfAttackRollIsHigherThanArmorClassTheAttackIsSuccessful()
        {
            var actions = new Actions();
            actions.Attack();

            var enemy = new Enemy();

            bool attackSuccess = actions.Result > enemy.armorClass;

            Assert.IsTrue(attackSuccess);
        }
    }
}