namespace Wyzwanie21.Tests
{
    public class TypeTests
    {
        [Test]
        public void ComparisonClassObjects()
        {
            // arrange
            var user1 = GetUser("KUba");
            var user2 = GetUser("Kuba");
            

            // act
            // assert
            Assert.AreNotEqual(user1, user2);
            
        }

        [Test]
        public void ComparisonIntObjects()
        {
            // arrange
            var num1 = 3;
            var num2 = 10-7;


            // act
            // assert
            Assert.AreEqual(num1, num2);

        }

        [Test]
        public void ComparisonStringObjects()
        {
            // arrange
            var name1 = "Kuba";
            var name2 = "Kuba";


            // act
            // assert
            Assert.AreEqual(name1, name2);

        }

        private User GetUser(string name)
        {
            return new User(name);
        }
    }
}
