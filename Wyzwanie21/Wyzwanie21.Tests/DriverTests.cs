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
        public void StringContainsTest()
        {
            //arrange
            var supvis = new Supervisor("BOb", "Bas");
            supvis.AddGrade("2+"); // 25
            supvis.AddGrade("-3"); // 35
            supvis.AddGrade("4"); // 60
            supvis.AddGrade("1");
            //act
            var stats = supvis.GetStats();
            //assert
            Assert.AreEqual(30, stats.Average);
        }
    }
}
