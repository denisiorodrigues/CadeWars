using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TraningCodeWars.Licao;

namespace TraningCodeWars.Test
{
    [TestFixture]
    public class DnaStrandTest
    {
        [TestCase]
        public void test01()
        {
            Assert.AreEqual("TTTT", DnaStrand.MakeComplement("AAAA"));
        }
        [TestCase]
        public void test02()
        {
            Assert.AreEqual("TAACG", DnaStrand.MakeComplement("ATTGC"));
        }
        [TestCase]
        public void test03()
        {
            Assert.AreEqual("CATA", DnaStrand.MakeComplement("GTAT"));
        }
    }
}
