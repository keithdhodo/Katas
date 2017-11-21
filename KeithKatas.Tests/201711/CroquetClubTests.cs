using Kata.November2017;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace KeithKatas.Tests.November2017
{
    [TestFixture]
    public class CroquetClubTests
    {
        [Test]
        public void CroquetClub_SampleTest()
        {
            Assert.AreEqual(new[] { "Open", "Senior", "Open", "Senior" }, CroquetClub.OpenOrSenior(new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } }));
            Assert.AreEqual(new[] { "Open", "Open", "Open", "Open" }, CroquetClub.OpenOrSenior(new[] { new[] { 3, 12 }, new[] { 55, 1 }, new[] { 91, -2 }, new[] { 54, 23 } }));
            Assert.AreEqual(new[] { "Senior", "Open", "Open", "Open" }, CroquetClub.OpenOrSenior(new[] { new[] { 59, 12 }, new[] { 45, 21 }, new[] { -12, -2 }, new[] { 12, 12 } }));
        }

        [Test]
        public void CroquetClub_EdgeTest()
        {
            Assert.AreEqual(new List<string>().ToArray(), CroquetClub.OpenOrSenior(new int[0][]), "Empty array");
            Assert.AreEqual(new[] { "Open", "Senior" }, CroquetClub.OpenOrSenior(new[] { new[] { 54, 9 }, new[] { 55, 9 } }), "age for 'Senior' should be > 54");
            Assert.AreEqual(new[] { "Open", "Senior" }, CroquetClub.OpenOrSenior(new[] { new[] { 55, 7 }, new[] { 55, 9 } }), "handicap for 'Senior' should be > 7");
        }

        [Test]
        public void CroquetClub_SomeRandomTest()
        {
            var values = new List<Tuple<int[], string>>
            {
                new Tuple<int[], string>(new[] {1, 1}, "Open"),
                new Tuple<int[], string>(new[] {54, 9}, "Open"),
                new Tuple<int[], string>(new[] {90, 7}, "Open"),
                new Tuple<int[], string>(new[] {21, 21}, "Open"),
                new Tuple<int[], string>(new[] {0, 0}, "Open"),
                new Tuple<int[], string>(new[] {55, 10}, "Senior"),
                new Tuple<int[], string>(new[] {90, 8}, "Senior"),
                new Tuple<int[], string>(new[] {90, 9}, "Senior"),
                new Tuple<int[], string>(new[] {60, 12}, "Senior"),
                new Tuple<int[], string>(new[] {75, 11}, "Senior"),
            };

            Random r = new Random();
            for (int t = 0; t < 5; t++)
            {
                var input = new List<int[]>();
                var output = new List<string>();
                for (int k = 0; k < 10; k++)
                {
                    var index = r.Next(0, 9);
                    input.Add(values[index].Item1);
                    output.Add(values[index].Item2);
                }
                Assert.AreEqual(CroquetClub.OpenOrSenior(input.ToArray()), output.ToArray());
            }

        }
    }
}
