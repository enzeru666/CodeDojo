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
            var attackSuccess = false;

            CombatArena.Attack();
            if (CombatArena.AttackHit)
            {
                attackSuccess = true;
            }

            Assert.IsTrue(attackSuccess);

        }

        [TestMethod]
        public void OrcsHaveHigherArmorClassThanOgres()
        {
            var attackSuccess = false;
            Enemy.SpawnOrc();

            CombatArena.Attack();
            if (Enemy.SpawnOrc()
            {
                attackSuccess = true;
            }
            Assert.IsTrue(attackSuccess);

        }
    }
}