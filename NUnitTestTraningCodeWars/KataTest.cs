using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestTraningCodeWars
{
    public class KataTest
    {
        [Test]
        public void EmptyTest()
        {
            Assert.AreEqual("", Kata.UniqueInOrder(""));
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("ABCDAB", Kata.UniqueInOrder("AAAABBBCCDAABBB"));
        }


        [Test]
        public void TestArray()
        {
            int[] arrayNumeros = { 1, 2, 3, 3 };
            int[] result = { 1, 2, 3 };
            Assert.AreEqual(result, Kata.UniqueInOrder(arrayNumeros));
        }
    }
}
