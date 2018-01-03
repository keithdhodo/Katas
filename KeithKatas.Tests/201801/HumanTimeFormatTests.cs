using KeithKatas.January2018;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeithKatas.Tests.January2018
{
    [TestFixture]
    public class HumanTimeFormatTests
    {
        [Test]
        public void HumanTimeFormat_FormatDuration_Test1()
        {
            Assert.AreEqual("now", HumanTimeFormat.FormatDuration(0));
        }

        [Test]
        public void HumanTimeFormat_FormatDuration_Test2()
        {
            Assert.AreEqual("1 second", HumanTimeFormat.FormatDuration(1));
        }

        [Test]
        public void HumanTimeFormat_FormatDuration_Test3()
        {
            Assert.AreEqual("1 minute and 2 seconds", HumanTimeFormat.FormatDuration(62));
        }

        [Test]
        public void HumanTimeFormat_FormatDuration_Test4()
        {
            Assert.AreEqual("2 minutes", HumanTimeFormat.FormatDuration(120));
        }

        [Test]
        public void HumanTimeFormat_FormatDuration_Test5()
        {
            Assert.AreEqual("1 hour, 1 minute and 2 seconds", HumanTimeFormat.FormatDuration(3662));
        }
    }
}
