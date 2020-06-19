using Katas;
using NUnit.Framework;

namespace CodeWars
{
    [TestFixture]
    class KataTestClass
    {
        [TestCase]
        public void BasicTest1()
        {
            kyu6PlentyOfFishInThePond game = new kyu6PlentyOfFishInThePond();
            string shoal = "";
            Assert.AreEqual(1, game.fish(shoal));
        }

        [TestCase]
        public void BasicTest2()
        {
            kyu6PlentyOfFishInThePond game = new kyu6PlentyOfFishInThePond();
            string shoal = "0";
            Assert.AreEqual(1, game.fish(shoal));
        }

        [TestCase]
        public void BasicTest3()
        {
            kyu6PlentyOfFishInThePond game = new kyu6PlentyOfFishInThePond();
            string shoal = "6";
            Assert.AreEqual(1, game.fish(shoal));
        }

        [TestCase]
        public void BasicTest4()
        {
            kyu6PlentyOfFishInThePond game = new kyu6PlentyOfFishInThePond();
            string shoal = "1111";
            Assert.AreEqual(2, game.fish(shoal));
        }

        [TestCase]
        public void BasicTest5()
        {
            kyu6PlentyOfFishInThePond game = new kyu6PlentyOfFishInThePond();
            string shoal = "11112222";
            Assert.AreEqual(3, game.fish(shoal));
        }

        [TestCase]
        public void BasicTest6()
        {
            kyu6PlentyOfFishInThePond game = new kyu6PlentyOfFishInThePond();
            string shoal = "111122223333";
            Assert.AreEqual(4, game.fish(shoal));
        }

        [TestCase]
        public void BasicTest7()
        {
            kyu6PlentyOfFishInThePond game = new kyu6PlentyOfFishInThePond();
            string shoal = "111111111111";
            Assert.AreEqual(3, game.fish(shoal));
        }

        [TestCase]
        public void ExtraTest8()
        {
            kyu6PlentyOfFishInThePond game = new kyu6PlentyOfFishInThePond();
            string shoal = "111111111111111111112222222222";
            Assert.AreEqual(5, game.fish(shoal));
        }

        [TestCase]
        public void BasicTest9()
        {
            kyu6PlentyOfFishInThePond game = new kyu6PlentyOfFishInThePond();
            string shoal = "151128241212192113722321331";
            Assert.AreEqual(5, game.fish(shoal));
        }

        [TestCase]
        public void BasicTest10()
        {
            kyu6PlentyOfFishInThePond game = new kyu6PlentyOfFishInThePond();
            string shoal = "614441785129353531554618368152839734689390953222796956813817188694";
            Assert.AreEqual(13, game.fish(shoal));
        }
    }
}