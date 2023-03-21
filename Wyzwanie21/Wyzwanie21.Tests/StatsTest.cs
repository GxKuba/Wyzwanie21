using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyzwanie21.Tests
{
    
    public class StatsTest
    {
        [Test]
        public void MathTestDriver()
        {
            var drv1 = new Driver("ja","ty");
            drv1.AddGrade(-150);
            drv1.AddGrade(10);
            var st = drv1.GetStats();


            
        }


    }
}
