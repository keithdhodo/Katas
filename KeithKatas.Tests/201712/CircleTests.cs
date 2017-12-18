using Kata.December2017;
using NUnit.Framework;
using System;

namespace KeithKatas.Tests.December2017
{
    [TestFixture]
    public class CircleTests
    {
        private static double epsilon = 1e-6;

        [Test]
        public void Circle_GetArea_SampleTest()
        {
            Assert.That(Circle.GetArea(new Circle(new Point(10, 10), 30)), Is.EqualTo(2827.433388).Within(epsilon));
            Assert.That(Circle.GetArea(new Circle(new Point(25, -70), 30)), Is.EqualTo(2827.433388).Within(epsilon));
            Assert.That(Circle.GetArea(new Circle(new Point(-15, 5), 0)), Is.EqualTo(0).Within(epsilon));
            Assert.That(Circle.GetArea(new Circle(new Point(-15, 5), 12.5)), Is.EqualTo(490.873852).Within(epsilon));
        }

        [Test]
        public void Circle_GetArea_RandomTest()
        {
            Random rnd = new Random();

            for (int i = 0; i < 100; ++i)
            {
                Point point = new Point(rnd.NextDouble() * 100 - 50, rnd.NextDouble() * 100 - 50);
                Double radius = rnd.NextDouble() * 50;
                Circle circle = new Circle(point, radius);

                Assert.That(Circle.GetArea(circle), Is.EqualTo(CircleArea(circle)).Within(epsilon));
            }
        }

        public static double CircleArea(Circle circle)
        {
            return Math.PI * circle.Radius * circle.Radius;
        }
    }
}
