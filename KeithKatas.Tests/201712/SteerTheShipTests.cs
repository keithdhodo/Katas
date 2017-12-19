using Kata.December2017;
using NUnit.Framework;
using System;

namespace KeithKatas.Tests.December2017
{
    [TestFixture]
    public class SteerTheShipTests
    {
        [Test]
        public void SteerTheShip_Steer_ExampleTestCases()
        {
            Assert.AreEqual("R: 45", SteerTheShip.Steer(1, 1));
            Assert.AreEqual("R: 90", SteerTheShip.Steer(1, 0));
            Assert.AreEqual("L: 30", SteerTheShip.Steer(-1, Math.Sqrt(3)));

            Assert.IsTrue(SteerTheShip.Steer(0, 1) == "R: 0" || SteerTheShip.Steer(0, 1) == "L: 0");
            Assert.IsTrue(SteerTheShip.Steer(0, -1) == "R: 180" || SteerTheShip.Steer(0, -1) == "L: 180");
        }

        [Test]
        public void SteerTheShip_Steer_NiceAngles()
        {
            // q1
            Assert.IsTrue(SteerTheShip.Steer(0, 1) == "R: 0" || SteerTheShip.Steer(0, 1) == "L: 0");
            Assert.AreEqual("R: 30", SteerTheShip.Steer(1, Math.Sqrt(3)));
            Assert.AreEqual("R: 45", SteerTheShip.Steer(1, 1));
            Assert.AreEqual("R: 60", SteerTheShip.Steer(Math.Sqrt(3), 1));

            // q2
            Assert.AreEqual("R: 90", SteerTheShip.Steer(1, 0));
            Assert.AreEqual("R: 120", SteerTheShip.Steer(Math.Sqrt(3), -1));
            Assert.AreEqual("R: 135", SteerTheShip.Steer(1, -1));
            Assert.AreEqual("R: 150", SteerTheShip.Steer(1, -Math.Sqrt(3)));

            // q3
            Assert.IsTrue(SteerTheShip.Steer(0, -1) == "R: 180" || SteerTheShip.Steer(0, -1) == "L: 180");
            Assert.AreEqual("L: 150", SteerTheShip.Steer(-1, -Math.Sqrt(3)));
            Assert.AreEqual("L: 135", SteerTheShip.Steer(-1, -1));
            Assert.AreEqual("L: 120", SteerTheShip.Steer(-Math.Sqrt(3), -1));

            // q4
            Assert.AreEqual("L: 90", SteerTheShip.Steer(-1, 0));
            Assert.AreEqual("L: 60", SteerTheShip.Steer(-Math.Sqrt(3), 1));
            Assert.AreEqual("L: 45", SteerTheShip.Steer(-1, 1));
            Assert.AreEqual("L: 30", SteerTheShip.Steer(-1, Math.Sqrt(3)));
        }

        [Test]
        public void SteerTheShip_Steer_LotsOfCoords()
        {
            for (var y = -100; y <= 100; y++)
            {
                for (var x = -100; x <= 100; x++)
                {
                    if (x == 0) continue;

                    Assert.AreEqual(MySteer(x, y), SteerTheShip.Steer(x, y));
                }
            }
        }

        [Test]
        public void SteerTheShip_Steer_RandomCoords()
        {
            var random = new Random();
            for (var i = 0; i < 100; i++)
            {
                var x = GetRandomDouble(random);
                var y = GetRandomDouble(random);

                while (x == 0)
                    x = GetRandomDouble(random);

                Assert.AreEqual(MySteer(x, y), SteerTheShip.Steer(x, y));
            }
        }

        private double GetRandomDouble(Random r)
        {
            return Math.Round(r.NextDouble() * (100 - -100) + -100, 2);
        }

        private String MySteer(double x, double y)
        {
            var rad = Math.Atan2(y, x);
            var deg = rad * (180 / Math.PI);

            var angle = 90 - deg;
            var direction = angle < 0 || angle > 180 ? "L" : "R";
            var result = angle > 180 ? 360 - angle : angle;

            return $"{direction}: {Math.Round(Math.Abs(result), 2)}";
        }
    }
}
