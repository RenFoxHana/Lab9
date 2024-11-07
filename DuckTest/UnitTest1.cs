using LibraryForLab9;

namespace DuckTest
{
    public class Tests
    {
        [Test]
        public void Duck_Quack()
        {
            var duck = new Duck("Max", "Red");

            var result = duck.Quack();

            Assert.AreEqual("Max quack.", result);
        }

        [Test]
        public void DuckFarm_AddDuck_IncreasesCount()
        {
            var farm = new Farm();
            var duck = new Duck("Alex", "Yellow");

            farm.AddDuck(duck);
            var ducks = farm.GetDucks();

            Assert.AreEqual("Alex", ducks[0].Name);
        }
    }
}