using Microsoft.VisualStudio.TestTools.UnitTesting;
using AndrewKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndrewKata.Tests
{
    [TestClass()]
    public class RandomNumberGeneratorTests
    {
        [TestMethod()]
        public void GenerateRandomNumberTest()
        {
            RandomNumberGenerator kata1 = new RandomNumberGenerator();
            RandomNumberGenerator kata2 = new RandomNumberGenerator();
            Assert.AreNotEqual(kata1.GenerateRandomNumber(), kata2.GenerateRandomNumber());
        }
    }
}