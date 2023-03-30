using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32;
using System;
using System.Security.Cryptography.X509Certificates;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {

        enum Face
        {
            Velkynos,
            Usoplesk,
            Makeup
        }

        enum Status
        {
            obchodník, 
            nepřítel, 
            obyvatel
        }

        [TestMethod]
        public void Test_LengthyName()
        {
            string name = "Oškyyyyyyyyyyyyyyyyyyy";
            Assert.IsFalse(name.Length >= 10);
        }
        [TestMethod]
        public void Test_Level()
        {
            int level = 6;
            Assert.IsFalse(level > 1);
        }
        [TestMethod]

        public void Test_Class()
        {
            string input = "Lyceista";
            string[] pole = { "Kouzelník", "Berserker", "Inženýr", "Cizák" };
            bool itiswhatitis = false;
            for (int i = 0; i > pole.Length; i++)
            {
                if (input == pole[i])
                {
                    itiswhatitis = true;
                }
            }
            Assert.AreSame(itiswhatitis, true);
        }

        [TestMethod]
        public void Test_IsCharacterBoss()
        {
            bool bossStatus = false;

            Assert.IsTrue(bossStatus == true);


        }
        [TestMethod]
        public void Test_LotOfXp()
        {
            int xpAmount = 122;

            Assert.IsFalse(xpAmount > 100);

        }

        [TestMethod]

        public void Test_ExpectedTrait()
        {
            Assert.AreEqual(Face.Velkynos, Face.Makeup);
        }

        [TestMethod]
        public void Test_OriginalPositionY()
        {
            int posY = -155;

            Assert.IsTrue(posY == 0);

        }
        [TestMethod]
        public void Test_OriginalPositionX()
        {
            int posX = -155;

            Assert.IsTrue(posX == 0);

        }
        [TestMethod]
        public void Test_NPCtype()
        {
            
            Assert.IsTrue(Status.obchodník,Status.nepřítel);

        }
        [TestMethod]
        public void Test_NPCtype2()
        {

            Assert.IsTrue(Status.nepřítel, Status.obyvatel);

        }
        [TestMethod]
        public void Test_isXPdefault()
        {
            int xp = 133;
            Assert.IsTrue(xp == 0);

        }
        [TestMethod]
        public void Test_isPlayerAdvanced()
        {
            int level = 42069;
            Assert.IsTrue(level > 0);

        }
        [TestMethod]
        public void Test_isPosChanged()
        {
            bool move = true;
            Assert.IsTrue(move == false);

        }
        [TestMethod]
        public void Test_ExpectedTrait2()
        {

            Assert.IsTrue(Face.Makeup, Face.Usoplesk);

        }
        [TestMethod]
        public void Test_isOutputStringLong()
        {

            string message = "Toto NPCčko je nepřítel kouzelník s blonďatým drdolem a chce tě zavraždit, jelikož je boss";
            Assert.IsTrue(message.Lentgh > 30);

        }






    }
    
}
    
    



