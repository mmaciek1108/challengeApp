using CSzarpKurs;

namespace challengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void WhenComparingReferencType_ShouldNotEqual()
        {
            //arrange
            var user1 = GetUser("Tecumseh", "Tecumseh", 69);
            var user2 = GetUser("Tecumseh", "Tecumseh", 69);
        
            //act
        
            //assert
            Assert.AreNotEqual(user1, user2);
        }

        private Employee GetUser(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }

        [Test]
        public void WhenComparingValueTypes_ShouldEqual()
        {
            //arrange
            int number1 = 1;
            int number2 = 2;
        
            //act
        
            //assert
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void WhenComparingValueString_ShouldEqual()
        {
            //arrange
            string nazwa1 = "indianin";
            string nazwa2 = "indianin";
        
            //act
        
            //assert
            Assert.AreEqual(nazwa1, nazwa2);
        }

        [Test]
        public void WhenComparingValueFloat_ShouldEqual()
        {
            //arrange
            float numberFloat1 = 3.5f;
            float numberFloat2 = 3.5f;
            //act
        
            //assert
            Assert.AreEqual(numberFloat1, numberFloat2);
        }



    }
}