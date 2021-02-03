
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TraningCodeWars.Licao;

namespace TraningCodeWars.Test
{
    [TestFixture]
    public class KataDivisorsTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new int[] { 2, 3, 4, 6, 8, 12 }, KataDivisors.Divisors(24));
            Assert.AreEqual(new int[] { 3, 5 }, KataDivisors.Divisors(15));
            Assert.AreEqual(new int[] { 2, 4, 8 }, KataDivisors.Divisors(16));
            Assert.AreEqual(new int[] { 11, 23 }, KataDivisors.Divisors(253));
        }
    }
}
