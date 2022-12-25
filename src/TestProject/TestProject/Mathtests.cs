using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja.UnitTest
{
    [TestFixture]
    public class Mathtests
    {
        [Test]
        public void Sum_AddTwoNumber_returnSumofTwoNumber()
        {
            //Arrange 
            Math math = new Math();

            //Act
            var result=math.Sum(2, 3);

            //Assert
            Assert.AreEqual(5,result);
        }
    }
}
