using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyzwanie21.Tests
{
    
    public class DriverTests
    {
        [Test]
        public void WhenGetStatsCalled_ThenReturnCorrectMax()
        {
            //arrange
            var drv1 = new Driver("ja","ty");
            drv1.AddGrade(5);
            drv1.AddGrade(10);

            //act
            var st = drv1.GetStats();

            //Assert
            Assert.AreEqual(st.Max, 10);
        }

        [Test]
        public void WhenGetStatsCalled_ThenReturnCorrectMin()
        {
            //arrange
            var drv1 = new Driver("ja", "ty");
            drv1.AddGrade(5);
            drv1.AddGrade(10);

            //act
            var st = drv1.GetStats();

            //Assert
            Assert.AreEqual(st.Min, 5);
        }

        [Test]
        public void WhenGetStatsCalled_ThenReturnCorrectAverage()
        {
            //arrange
            var drv1 = new Driver("ja", "ty");
            drv1.AddGrade(10);
            drv1.AddGrade(5);

            //act
            var st = drv1.GetStats();

            //Assert
            Assert.AreEqual(st.Average, 7.5);
        }
    }
}
