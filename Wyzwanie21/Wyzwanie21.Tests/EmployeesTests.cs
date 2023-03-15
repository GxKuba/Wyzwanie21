

namespace Wyzwanie21.Tests
{
    public class EmployessTests
    {
        [Test]
        public void WhenUserGetTwoPoints_ThenCorrectSum()
        {
            // arrange
            var user = new User("Kuba","jotpeasdasd");
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(-6);

            // act
            var result = user.Result;


            // assert
            Assert.AreEqual(5, result);
        }
    }
}